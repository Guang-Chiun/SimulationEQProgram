namespace SimulationEQProgram
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMsg = new System.Windows.Forms.Label();
            this.txtEQID = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtReceiveMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.txtMonitorSystemIP = new System.Windows.Forms.TextBox();
            this.btnBreak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.grpWarningType = new System.Windows.Forms.GroupBox();
            this.chkSoftwareError = new System.Windows.Forms.CheckBox();
            this.chkUnloadError = new System.Windows.Forms.CheckBox();
            this.chkLoadError = new System.Windows.Forms.CheckBox();
            this.chkCCDError = new System.Windows.Forms.CheckBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpGlassLevel = new System.Windows.Forms.GroupBox();
            this.rbGlassLevelNG = new System.Windows.Forms.RadioButton();
            this.rbGlassLevelRepair = new System.Windows.Forms.RadioButton();
            this.rbGlassLevelOK = new System.Windows.Forms.RadioButton();
            this.btnGenerateDefectNum = new System.Windows.Forms.Button();
            this.btnGenerateGlassName = new System.Windows.Forms.Button();
            this.chkIsFileUpload = new System.Windows.Forms.CheckBox();
            this.grpProcessType = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbOSizeDefectNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLSizeDefectNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMSizeDefectNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSSizeDefectNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNGGlass = new System.Windows.Forms.CheckBox();
            this.tbRecipeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkGlassCommon = new System.Windows.Forms.CheckBox();
            this.chkMaskCommon = new System.Windows.Forms.CheckBox();
            this.tbDefectNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGlassName = new System.Windows.Forms.TextBox();
            this.btnInsertGlassInfo = new System.Windows.Forms.Button();
            this.grpWarningType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpGlassLevel.SuspendLayout();
            this.grpProcessType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("新細明體-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMsg.Location = new System.Drawing.Point(17, 28);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(112, 15);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "請輸入機台ID：";
            // 
            // txtEQID
            // 
            this.txtEQID.Location = new System.Drawing.Point(151, 28);
            this.txtEQID.Multiline = true;
            this.txtEQID.Name = "txtEQID";
            this.txtEQID.ShortcutsEnabled = false;
            this.txtEQID.Size = new System.Drawing.Size(120, 30);
            this.txtEQID.TabIndex = 1;
            this.txtEQID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Restrict);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(20, 182);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(251, 30);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "連線至監控系統";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtReceiveMsg
            // 
            this.txtReceiveMsg.Location = new System.Drawing.Point(25, 296);
            this.txtReceiveMsg.Multiline = true;
            this.txtReceiveMsg.Name = "txtReceiveMsg";
            this.txtReceiveMsg.ReadOnly = true;
            this.txtReceiveMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceiveMsg.Size = new System.Drawing.Size(621, 242);
            this.txtReceiveMsg.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 221);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(251, 28);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "發送警報";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("新細明體-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelIP.Location = new System.Drawing.Point(17, 99);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(114, 15);
            this.labelIP.TabIndex = 6;
            this.labelIP.Text = "輸入監控系統IP:";
            // 
            // txtMonitorSystemIP
            // 
            this.txtMonitorSystemIP.Location = new System.Drawing.Point(151, 99);
            this.txtMonitorSystemIP.Multiline = true;
            this.txtMonitorSystemIP.Name = "txtMonitorSystemIP";
            this.txtMonitorSystemIP.Size = new System.Drawing.Size(120, 30);
            this.txtMonitorSystemIP.TabIndex = 7;
            this.txtMonitorSystemIP.Text = "127.0.0.1";
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(20, 218);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(251, 30);
            this.btnBreak.TabIndex = 8;
            this.btnBreak.Text = "中斷連線";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "輸入監控系統Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(151, 134);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 30);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "8080";
            // 
            // grpWarningType
            // 
            this.grpWarningType.Controls.Add(this.chkSoftwareError);
            this.grpWarningType.Controls.Add(this.chkUnloadError);
            this.grpWarningType.Controls.Add(this.chkLoadError);
            this.grpWarningType.Controls.Add(this.chkCCDError);
            this.grpWarningType.Controls.Add(this.btnSend);
            this.grpWarningType.Location = new System.Drawing.Point(354, 12);
            this.grpWarningType.Name = "grpWarningType";
            this.grpWarningType.Size = new System.Drawing.Size(292, 265);
            this.grpWarningType.TabIndex = 11;
            this.grpWarningType.TabStop = false;
            this.grpWarningType.Text = "警報表";
            // 
            // chkSoftwareError
            // 
            this.chkSoftwareError.AutoSize = true;
            this.chkSoftwareError.Location = new System.Drawing.Point(16, 101);
            this.chkSoftwareError.Name = "chkSoftwareError";
            this.chkSoftwareError.Size = new System.Drawing.Size(89, 19);
            this.chkSoftwareError.TabIndex = 9;
            this.chkSoftwareError.Text = "軟體異常";
            this.chkSoftwareError.UseVisualStyleBackColor = true;
            // 
            // chkUnloadError
            // 
            this.chkUnloadError.AutoSize = true;
            this.chkUnloadError.Location = new System.Drawing.Point(16, 76);
            this.chkUnloadError.Name = "chkUnloadError";
            this.chkUnloadError.Size = new System.Drawing.Size(89, 19);
            this.chkUnloadError.TabIndex = 8;
            this.chkUnloadError.Text = "出片異常";
            this.chkUnloadError.UseVisualStyleBackColor = true;
            // 
            // chkLoadError
            // 
            this.chkLoadError.AutoSize = true;
            this.chkLoadError.Location = new System.Drawing.Point(16, 49);
            this.chkLoadError.Name = "chkLoadError";
            this.chkLoadError.Size = new System.Drawing.Size(89, 19);
            this.chkLoadError.TabIndex = 7;
            this.chkLoadError.Text = "進片異常";
            this.chkLoadError.UseVisualStyleBackColor = true;
            // 
            // chkCCDError
            // 
            this.chkCCDError.AutoSize = true;
            this.chkCCDError.Location = new System.Drawing.Point(16, 24);
            this.chkCCDError.Name = "chkCCDError";
            this.chkCCDError.Size = new System.Drawing.Size(117, 19);
            this.chkCCDError.TabIndex = 6;
            this.chkCCDError.Text = "CCD取像問題";
            this.chkCCDError.UseVisualStyleBackColor = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("新細明體-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPassword.Location = new System.Drawing.Point(17, 64);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(97, 15);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "請輸入密碼：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 64);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(120, 30);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Restrict);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMsg);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtEQID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.btnBreak);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.txtMonitorSystemIP);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 264);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "連線物件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpGlassLevel);
            this.groupBox2.Controls.Add(this.btnGenerateDefectNum);
            this.groupBox2.Controls.Add(this.btnGenerateGlassName);
            this.groupBox2.Controls.Add(this.chkIsFileUpload);
            this.groupBox2.Controls.Add(this.grpProcessType);
            this.groupBox2.Controls.Add(this.tbOSizeDefectNum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbLSizeDefectNum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMSizeDefectNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbSSizeDefectNum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkNGGlass);
            this.groupBox2.Controls.Add(this.tbRecipeID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkGlassCommon);
            this.groupBox2.Controls.Add(this.chkMaskCommon);
            this.groupBox2.Controls.Add(this.tbDefectNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbGlassName);
            this.groupBox2.Controls.Add(this.btnInsertGlassInfo);
            this.groupBox2.Location = new System.Drawing.Point(670, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 525);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Server";
            // 
            // grpGlassLevel
            // 
            this.grpGlassLevel.Controls.Add(this.rbGlassLevelNG);
            this.grpGlassLevel.Controls.Add(this.rbGlassLevelRepair);
            this.grpGlassLevel.Controls.Add(this.rbGlassLevelOK);
            this.grpGlassLevel.Location = new System.Drawing.Point(32, 408);
            this.grpGlassLevel.Name = "grpGlassLevel";
            this.grpGlassLevel.Size = new System.Drawing.Size(257, 51);
            this.grpGlassLevel.TabIndex = 21;
            this.grpGlassLevel.TabStop = false;
            this.grpGlassLevel.Text = "Glass Level";
            // 
            // rbGlassLevelNG
            // 
            this.rbGlassLevelNG.AutoSize = true;
            this.rbGlassLevelNG.Location = new System.Drawing.Point(172, 24);
            this.rbGlassLevelNG.Name = "rbGlassLevelNG";
            this.rbGlassLevelNG.Size = new System.Drawing.Size(48, 19);
            this.rbGlassLevelNG.TabIndex = 2;
            this.rbGlassLevelNG.Text = "NG";
            this.rbGlassLevelNG.UseVisualStyleBackColor = true;
            // 
            // rbGlassLevelRepair
            // 
            this.rbGlassLevelRepair.AutoSize = true;
            this.rbGlassLevelRepair.Location = new System.Drawing.Point(90, 24);
            this.rbGlassLevelRepair.Name = "rbGlassLevelRepair";
            this.rbGlassLevelRepair.Size = new System.Drawing.Size(65, 19);
            this.rbGlassLevelRepair.TabIndex = 1;
            this.rbGlassLevelRepair.Text = "Repair";
            this.rbGlassLevelRepair.UseVisualStyleBackColor = true;
            // 
            // rbGlassLevelOK
            // 
            this.rbGlassLevelOK.AutoSize = true;
            this.rbGlassLevelOK.Checked = true;
            this.rbGlassLevelOK.Location = new System.Drawing.Point(15, 25);
            this.rbGlassLevelOK.Name = "rbGlassLevelOK";
            this.rbGlassLevelOK.Size = new System.Drawing.Size(48, 19);
            this.rbGlassLevelOK.TabIndex = 0;
            this.rbGlassLevelOK.TabStop = true;
            this.rbGlassLevelOK.Text = "OK";
            this.rbGlassLevelOK.UseVisualStyleBackColor = true;
            // 
            // btnGenerateDefectNum
            // 
            this.btnGenerateDefectNum.Location = new System.Drawing.Point(238, 172);
            this.btnGenerateDefectNum.Name = "btnGenerateDefectNum";
            this.btnGenerateDefectNum.Size = new System.Drawing.Size(74, 24);
            this.btnGenerateDefectNum.TabIndex = 25;
            this.btnGenerateDefectNum.Text = "Generate";
            this.btnGenerateDefectNum.UseVisualStyleBackColor = true;
            this.btnGenerateDefectNum.Click += new System.EventHandler(this.btnGenerateDefectNum_Click);
            // 
            // btnGenerateGlassName
            // 
            this.btnGenerateGlassName.Location = new System.Drawing.Point(238, 131);
            this.btnGenerateGlassName.Name = "btnGenerateGlassName";
            this.btnGenerateGlassName.Size = new System.Drawing.Size(74, 24);
            this.btnGenerateGlassName.TabIndex = 24;
            this.btnGenerateGlassName.Text = "Generate";
            this.btnGenerateGlassName.UseVisualStyleBackColor = true;
            this.btnGenerateGlassName.Click += new System.EventHandler(this.btnGenerateGlassName_Click);
            // 
            // chkIsFileUpload
            // 
            this.chkIsFileUpload.AutoSize = true;
            this.chkIsFileUpload.Location = new System.Drawing.Point(164, 345);
            this.chkIsFileUpload.Name = "chkIsFileUpload";
            this.chkIsFileUpload.Size = new System.Drawing.Size(110, 19);
            this.chkIsFileUpload.TabIndex = 21;
            this.chkIsFileUpload.Text = "Is File Upload";
            this.chkIsFileUpload.UseVisualStyleBackColor = true;
            // 
            // grpProcessType
            // 
            this.grpProcessType.Controls.Add(this.rbBlue);
            this.grpProcessType.Controls.Add(this.rbGreen);
            this.grpProcessType.Controls.Add(this.radioButton1);
            this.grpProcessType.Location = new System.Drawing.Point(23, 68);
            this.grpProcessType.Name = "grpProcessType";
            this.grpProcessType.Size = new System.Drawing.Size(257, 51);
            this.grpProcessType.TabIndex = 20;
            this.grpProcessType.TabStop = false;
            this.grpProcessType.Text = "Process Type";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(168, 24);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(54, 19);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(92, 24);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(62, 19);
            this.rbGreen.TabIndex = 1;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbOSizeDefectNum
            // 
            this.tbOSizeDefectNum.Location = new System.Drawing.Point(164, 304);
            this.tbOSizeDefectNum.Name = "tbOSizeDefectNum";
            this.tbOSizeDefectNum.Size = new System.Drawing.Size(68, 25);
            this.tbOSizeDefectNum.TabIndex = 19;
            this.tbOSizeDefectNum.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "O Size Defect Num : ";
            // 
            // tbLSizeDefectNum
            // 
            this.tbLSizeDefectNum.Location = new System.Drawing.Point(164, 273);
            this.tbLSizeDefectNum.Name = "tbLSizeDefectNum";
            this.tbLSizeDefectNum.Size = new System.Drawing.Size(68, 25);
            this.tbLSizeDefectNum.TabIndex = 17;
            this.tbLSizeDefectNum.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "L Size Defect Num : ";
            // 
            // tbMSizeDefectNum
            // 
            this.tbMSizeDefectNum.Location = new System.Drawing.Point(164, 240);
            this.tbMSizeDefectNum.Name = "tbMSizeDefectNum";
            this.tbMSizeDefectNum.Size = new System.Drawing.Size(68, 25);
            this.tbMSizeDefectNum.TabIndex = 15;
            this.tbMSizeDefectNum.Text = "40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "M Size Defect Num : ";
            // 
            // tbSSizeDefectNum
            // 
            this.tbSSizeDefectNum.Location = new System.Drawing.Point(164, 204);
            this.tbSSizeDefectNum.Name = "tbSSizeDefectNum";
            this.tbSSizeDefectNum.Size = new System.Drawing.Size(68, 25);
            this.tbSSizeDefectNum.TabIndex = 13;
            this.tbSSizeDefectNum.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "S Size Defect Num : ";
            // 
            // chkNGGlass
            // 
            this.chkNGGlass.AutoSize = true;
            this.chkNGGlass.Location = new System.Drawing.Point(33, 345);
            this.chkNGGlass.Name = "chkNGGlass";
            this.chkNGGlass.Size = new System.Drawing.Size(97, 19);
            this.chkNGGlass.TabIndex = 11;
            this.chkNGGlass.Text = "NG Glass ? ";
            this.chkNGGlass.UseVisualStyleBackColor = true;
            // 
            // tbRecipeID
            // 
            this.tbRecipeID.Location = new System.Drawing.Point(129, 33);
            this.tbRecipeID.Name = "tbRecipeID";
            this.tbRecipeID.Size = new System.Drawing.Size(152, 25);
            this.tbRecipeID.TabIndex = 10;
            this.tbRecipeID.Text = "F1350";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recipe ID : ";
            // 
            // chkGlassCommon
            // 
            this.chkGlassCommon.AutoSize = true;
            this.chkGlassCommon.Location = new System.Drawing.Point(164, 380);
            this.chkGlassCommon.Name = "chkGlassCommon";
            this.chkGlassCommon.Size = new System.Drawing.Size(115, 19);
            this.chkGlassCommon.TabIndex = 8;
            this.chkGlassCommon.Text = "Glass Common";
            this.chkGlassCommon.UseVisualStyleBackColor = true;
            // 
            // chkMaskCommon
            // 
            this.chkMaskCommon.AutoSize = true;
            this.chkMaskCommon.Location = new System.Drawing.Point(33, 380);
            this.chkMaskCommon.Name = "chkMaskCommon";
            this.chkMaskCommon.Size = new System.Drawing.Size(116, 19);
            this.chkMaskCommon.TabIndex = 7;
            this.chkMaskCommon.Text = "Mask Common";
            this.chkMaskCommon.UseVisualStyleBackColor = true;
            // 
            // tbDefectNum
            // 
            this.tbDefectNum.Location = new System.Drawing.Point(164, 173);
            this.tbDefectNum.Name = "tbDefectNum";
            this.tbDefectNum.Size = new System.Drawing.Size(68, 25);
            this.tbDefectNum.TabIndex = 6;
            this.tbDefectNum.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Defect Num : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "GlassName : ";
            // 
            // tbGlassName
            // 
            this.tbGlassName.Location = new System.Drawing.Point(129, 131);
            this.tbGlassName.Name = "tbGlassName";
            this.tbGlassName.Size = new System.Drawing.Size(103, 25);
            this.tbGlassName.TabIndex = 3;
            this.tbGlassName.Text = "A123456789";
            // 
            // btnInsertGlassInfo
            // 
            this.btnInsertGlassInfo.Location = new System.Drawing.Point(33, 476);
            this.btnInsertGlassInfo.Name = "btnInsertGlassInfo";
            this.btnInsertGlassInfo.Size = new System.Drawing.Size(279, 28);
            this.btnInsertGlassInfo.TabIndex = 2;
            this.btnInsertGlassInfo.Text = "Insert Info";
            this.btnInsertGlassInfo.UseVisualStyleBackColor = true;
            this.btnInsertGlassInfo.Click += new System.EventHandler(this.btnInsertGlassInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpWarningType);
            this.Controls.Add(this.txtReceiveMsg);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "機台端模擬程式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grpWarningType.ResumeLayout(false);
            this.grpWarningType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpGlassLevel.ResumeLayout(false);
            this.grpGlassLevel.PerformLayout();
            this.grpProcessType.ResumeLayout(false);
            this.grpProcessType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.TextBox txtEQID;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtReceiveMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox txtMonitorSystemIP;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox grpWarningType;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkLoadError;
        private System.Windows.Forms.CheckBox chkCCDError;
        private System.Windows.Forms.CheckBox chkSoftwareError;
        private System.Windows.Forms.CheckBox chkUnloadError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsertGlassInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGlassName;
        private System.Windows.Forms.CheckBox chkGlassCommon;
        private System.Windows.Forms.CheckBox chkMaskCommon;
        private System.Windows.Forms.TextBox tbDefectNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRecipeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpProcessType;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox tbOSizeDefectNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLSizeDefectNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMSizeDefectNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSSizeDefectNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNGGlass;
        private System.Windows.Forms.CheckBox chkIsFileUpload;
        private System.Windows.Forms.Button btnGenerateGlassName;
        private System.Windows.Forms.Button btnGenerateDefectNum;
        private System.Windows.Forms.GroupBox grpGlassLevel;
        private System.Windows.Forms.RadioButton rbGlassLevelNG;
        private System.Windows.Forms.RadioButton rbGlassLevelRepair;
        private System.Windows.Forms.RadioButton rbGlassLevelOK;
    }
}

