using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SimulationEQProgram
{
    /// <summary>
    /// 寫一個列舉記錄要傳送的資訊類別
    /// </summary>
    public enum ESocketSendInfo
    {
        CHECK_LOGIC_INFO = 1,
        WARNING_INFO = 2
    }

    public enum EWarningType
    {
        CCDError = 8,
        LoadError = 16,
        UnloadError = 32,
        SoftError = 64,
    }

    public partial class Form1 : Form
    {
        Socket clientSocket = null;
        static Boolean isListen = true;   //是否有在監聽資訊
        Thread thDataFromServer;
        IPAddress ipAddress;
        int port;

        public Form1()
        {
            InitializeComponent();
            ipAddress = IPAddress.Loopback;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendWarningMessage();
        }

        /// <summary>
        /// 寫一個函數統一，傳送到Server相關都寫在這裡
        /// </summary>
        /// <param name="eSocketSendInfo"></param>
        /// <param name="sInfo"></param>
        private void SendSocketInfoToServer(ESocketSendInfo eSocketSendInfo, string sInfo)
        {
            //要先檢查是否成功連線
            Byte[] bytesSend = new Byte[4096];
            string sendInfo;
            switch (eSocketSendInfo)
            {               
                case ESocketSendInfo.CHECK_LOGIC_INFO:               
                    sendInfo = $"{(int)ESocketSendInfo.CHECK_LOGIC_INFO}${sInfo}";
                    bytesSend = Encoding.UTF8.GetBytes(sendInfo);
                    if (clientSocket != null && clientSocket.Connected)
                    {
                        clientSocket.Send(bytesSend);
                        txtEQID.Enabled = false;
                        txtPassword.Enabled = false;
                        thDataFromServer = new Thread(DataFromServer);   //開啟接收Server端數據執行緒
                        thDataFromServer.IsBackground = true;
                        thDataFromServer.Start();
                    }
                    else
                    {
                        MessageBox.Show("監控系統已關閉");
                    }
                    break;
                
                case ESocketSendInfo.WARNING_INFO:
                    sendInfo = $"{(int)ESocketSendInfo.WARNING_INFO}${sInfo}";
                    bytesSend = Encoding.UTF8.GetBytes(sendInfo);
                    if (clientSocket != null && clientSocket.Connected)
                    {                      
                        clientSocket.Send(bytesSend);
                    }
                    else
                    {
                        MessageBox.Show("監控系統已關閉");
                    }
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 2021-08-12 發送警報訊息，這裡要改為抓取視窗上勾選的錯誤訊息
        /// </summary>
        private void SendWarningMessage()
        {
            string sWarningInfo = "";
            //foreach (CheckBox c in grpWarningType.Controls.OfType<CheckBox>())
            //{
            //    if (c.Checked)
            //        sWarningInfo += $"{c.Text};";                       
            //}

            if (chkCCDError.Checked)
                sWarningInfo += $"{(int)EWarningType.CCDError};";
            if (chkLoadError.Checked)
                sWarningInfo += $"{(int)EWarningType.LoadError};";
            if (chkUnloadError.Checked)
                sWarningInfo += $"{(int)EWarningType.UnloadError};";
            if (chkSoftwareError.Checked)
                sWarningInfo += $"{(int)EWarningType.SoftError};";

            if (!String.IsNullOrEmpty(sWarningInfo))
            {
                string sInfo = $"{txtEQID.Text.Trim()},{sWarningInfo}";
                SendSocketInfoToServer(ESocketSendInfo.WARNING_INFO, sInfo);
            }                 
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEQID.Text.Trim()))
            {
                MessageBox.Show("請輸入機台ID");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                MessageBox.Show("請輸入密碼");
                return;
            }
            if (CheckStringHasKeyWord(txtEQID.Text) || CheckStringHasKeyWord(txtPassword.Text))
            {
                MessageBox.Show("注意EQID或是密碼包含關鍵字");
                return;
            }

            //開始連線部分
            if (clientSocket == null || !clientSocket.Connected)
            {
                try
                {
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    string sIP = txtMonitorSystemIP.Text.ToString().Trim();
                    string sPort = txtPort.Text.ToString().Trim();
                    if (!String.IsNullOrWhiteSpace(sIP))
                    {
                        try
                        {
                            ipAddress = IPAddress.Parse(sIP);
                            port = Convert.ToInt32(sPort);
                        }
                        catch
                        {
                            MessageBox.Show("請輸入正確的IP, port");
                            return;
                        }
                    }
                    else
                    {
                        ipAddress = IPAddress.Loopback;
                    }

                    //Callback寫在這
                    //AsyncCallback 委託，連接完成後調用的方法，也是異部
                    //AsyncCallback是一個帶參數的委託，參數類型為IAsyncResult
                    AsyncCallback requestCallback = (ar) =>
                    {
                        if (ar.IsCompleted)   //判斷異部操作是否執行完畢
                        {
                            //Byte[] bytesSend = new Byte[4096];
                            txtEQID.BeginInvoke(new Action(() =>
                            {                           
                                //注意檢查帳號密碼的機制，是要先連線後，才可以檢查                                                      
                                string EQID = txtEQID.Text.Trim();
                                string Password = txtPassword.Text.Trim();
                                SendSocketInfoToServer(ESocketSendInfo.CHECK_LOGIC_INFO, $"{EQID},{Password}");
                            }));

                            if (clientSocket != null && clientSocket.Connected)
                            {
                                SetUIEnable(false);
                            }
                        }
                    };

                    //Socket.BeginConnect:開始對遠端主機連接的異部請求
                    clientSocket.BeginConnect(ipAddress, port, requestCallback, null);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("監控系統已連接");
            }
        }

        /// <summary>
        /// 將Server端的Boardcast資訊顯示到txtReceiveMsg上
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMsg(String msg)
        {
            txtReceiveMsg.BeginInvoke(new Action(() =>
            {
                txtReceiveMsg.Text += Environment.NewLine + msg;          
            }));
        }

        /// <summary>
        /// 開啟一執行緒接收Server端傳來的訊息
        /// </summary>
        private void DataFromServer()
        {
            ShowMsg("Connected to the Chat Server...");
            isListen = true;
            try
            {
                while (isListen)
                {
                    Byte[] bytesFrom = new Byte[4096];
                    Int32 len = clientSocket.Receive(bytesFrom);
                    String dataFromClient = Encoding.UTF8.GetString(bytesFrom, 0, len);
                    if (!String.IsNullOrWhiteSpace(dataFromClient))
                    {
                        //收到BoardCast的「Server has closed」指令，表示Server端已關閉，clientSocket也要同時關閉
                        if (CheckStringHasKeyWord(dataFromClient.ToString()))
                        {
                            clientSocket.Close();
                            clientSocket = null;

                            txtReceiveMsg.BeginInvoke(new Action(() =>
                            {
                                txtReceiveMsg.Text += Environment.NewLine + "監控系統已關閉";
                            }));

                            SetUIEnable(true);
                            thDataFromServer.Abort();                         
                            return;
                        }

                        //這裡會接收Server端回傳的錯誤訊息，回傳字串由#...#夾擊而成表示為錯誤訊息，必須關閉clientSocket
                        if (dataFromClient.StartsWith("#") && dataFromClient.EndsWith("#"))
                        {                         
                            String ErrorInfo = dataFromClient.Substring(1, dataFromClient.Length - 2);
                            this.BeginInvoke(new Action(() =>
                            {
                                MessageBox.Show(ErrorInfo);
                            }));

                            isListen = false;                                                      
                            clientSocket.Send(Encoding.UTF8.GetBytes("$"));
                            clientSocket.Close();
                            clientSocket = null;
                            SetUIEnable(true);                         
                        }                      
                        else
                        {
                            //這裡是正確接收訊息的部分
                            ShowMsg(dataFromClient);
                        }
                    }
                }
            }
            catch (SocketException ex)
            {
                isListen = false;
                if (clientSocket != null && clientSocket.Connected)
                {
                    clientSocket.Send(Encoding.UTF8.GetBytes("$"));
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 視窗關閉表示client中斷了，要關閉Server端的clientSocket物件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Send(Encoding.UTF8.GetBytes("$"));
                Thread.Sleep(1500);   //2021-10-02要先等一下再關閉clientSocket
                clientSocket.Close();
                clientSocket = null;
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                thDataFromServer.Abort();
                clientSocket.Send(Encoding.UTF8.GetBytes("$"));
                Thread.Sleep(1500);   //2021-10-02要先等一下再關閉clientSocket

                clientSocket.Close();
                clientSocket = null;
           
                txtReceiveMsg.BeginInvoke(new Action(() =>
                {
                    txtReceiveMsg.Text += Environment.NewLine + "Server連接已斷開";                  
                }));

                SetUIEnable(true);            
            }
        }

        /// <summary>
        /// 設定UI可否輸入資訊
        /// </summary>
        /// <param name="bEnable"></param>
        private void SetUIEnable(bool bEnable)
        {
            txtEQID.BeginInvoke(new Action(() =>
            {
                txtEQID.Enabled = bEnable;
            }));

            txtPassword.BeginInvoke(new Action(() =>
            {
                txtPassword.Enabled = bEnable;
            }));

            txtMonitorSystemIP.BeginInvoke(new Action(() =>
            {
                txtMonitorSystemIP.Enabled = bEnable;
            }));

            txtPort.BeginInvoke(new Action(() =>
            {
                txtPort.Enabled = bEnable;
            }));
        }

        private bool CheckStringHasKeyWord(string sMsg)
        {
            //前17個字是Server has closed表示斷開了，EQID, Password等項目不可包含關鍵字
            if (sMsg.Length >= 17 && sMsg.Substring(0, 17).Equals("Server has closed"))
            {
                return true;
            }
            return false;
        }

        private void btnInsertGlassInfo_Click(object sender, EventArgs e)
        {         
            try
            {
                string EQID = txtEQID.Text.Trim();
                if (String.IsNullOrEmpty(EQID))
                {
                    MessageBox.Show("請先輸入EQ ID");
                    return;
                }

                int ClientEQID = Convert.ToInt32(EQID.Substring(2, EQID.Length - 2));
                Glass glass = new Glass()
                {
                    Recipe_ID = tbRecipeID.Text,
                    ProcessType = this.GetProcessType(),
                    EQID = ClientEQID,
                    GlassName = tbGlassName.Text,
                    Model_Num = 1,
                    Panel_Num = 18,
                    DefectNum = Convert.ToInt32(tbDefectNum.Text),
                    TactTime = DateTime.Now.ToString("HH:mm:ss"),
                    NGGlass = chkNGGlass.Checked,
                    MaskCommonDefect = chkMaskCommon.Checked,
                    GlassCommonDefect = chkGlassCommon.Checked,
                    IsFileUpload = chkIsFileUpload.Checked,
                    S_Size_Defect_Num = Convert.ToInt32(tbSSizeDefectNum.Text),
                    M_Size_Defect_Num = Convert.ToInt32(tbMSizeDefectNum.Text),
                    L_Size_Defect_Num = Convert.ToInt32(tbLSizeDefectNum.Text),
                    O_Size_Defect_Num = Convert.ToInt32(tbOSizeDefectNum.Text),
                    GlassLevel = GetGlassLevel()
                };

                if (glass.S_Size_Defect_Num + glass.M_Size_Defect_Num + glass.L_Size_Defect_Num + glass.O_Size_Defect_Num 
                    != glass.DefectNum)
                {
                    MessageBox.Show("S+M+L+O 總和錯誤");
                    return;
                }

                SQLServerConnect.InsertInfoToGlassTable(glass);
                Console.WriteLine("Insert OK");              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private int GetGlassLevel()
        {
            int GlassLevel = -1;
            foreach (Control ctrl in this.grpGlassLevel.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        GlassLevel = radioButton.TabIndex;
                }
            }
            return GlassLevel;
        }

        private string GetProcessType()
        {
            string processType = String.Empty;
            foreach (Control ctrl in this.grpProcessType.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        processType = radioButton.Text;
                }
            }
            return processType;
        }

        private void btnGenerateGlassName_Click(object sender, EventArgs e)
        {
            //隨機產生Glass Name
            Random ran = new Random();
            char RandonChar = Convert.ToChar(ran.Next(65, 90));
            int RandomValue = ran.Next(100000000, 999999999);
            string GenerateGlassName = $"{RandonChar}{RandomValue}";
            tbGlassName.Text = GenerateGlassName;
        }

        private void btnGenerateDefectNum_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int DefectNum = ran.Next(100, 1500);
            List<int> DifferentSizeNum = CreateRandomNumbersWithSum(4, DefectNum).ToList<int>();
            DifferentSizeNum.Sort();
            DifferentSizeNum.Reverse();
            tbDefectNum.Text = DefectNum.ToString();
            tbSSizeDefectNum.Text = DifferentSizeNum[0].ToString();
            tbMSizeDefectNum.Text = DifferentSizeNum[1].ToString();
            tbLSizeDefectNum.Text = DifferentSizeNum[2].ToString();
            tbOSizeDefectNum.Text = DifferentSizeNum[3].ToString();

            //2021-09-29 判定Glass Level條件
            float SSizeRatio = (float)(DifferentSizeNum[0] + DifferentSizeNum[1]) / DefectNum;
            if ((DefectNum > 1000 && SSizeRatio < 0.7f)
                || chkMaskCommon.Checked 
                || chkGlassCommon.Checked)
                rbGlassLevelNG.Checked = true;
            else if (DefectNum > 1000 && SSizeRatio >= 0.7f)
                rbGlassLevelRepair.Checked = true;
            else
                rbGlassLevelOK.Checked = true;
        }

        private int[] CreateRandomNumbersWithSum(int k, int sum)
        {
            Random rnd = new Random();
            int[] x = new int[k + 1];

            // the endpoints of the interval
            x[0] = 0;
            x[k] = sum;

            // generate the k - 1 random sectioning points
            for (int i = 1; i < k; i++)
            {
                x[i] = rnd.Next(0, sum + 1);
            }

            // sort the sectioning points
            Array.Sort(x);

            // obtain the k numbers with sum s
            int[] N = new int[k];
            for (int i = 0; i < k; i++)
            {
                N[i] = x[i + 1] - x[i];
            }
            return N;
        }

        private void txt_KeyPress_Restrict(object sender, KeyPressEventArgs e)
        {
            if (  ((int)e.KeyChar < 48 | (int)e.KeyChar > 57)
                & ((int)e.KeyChar < 65 | (int)e.KeyChar > 90)
                & ((int)e.KeyChar < 97 | (int)e.KeyChar > 122)
                & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }

}
