using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SimulationEQProgram
{
    public static class SQLServerConnect
    {
        public static string GetConnectionInformation()
        {
            string sServerName = "localhost\\SQLEXPRESS";   //LAPTOP-FEM2RE78\\SQLEXPRESS   localhost
            string sDataBase = "AOIDB";
            string sID = "sa";
            string sPassword = "123456789";
            int TimeOut = 10;
            string connString = $"server={sServerName};database={sDataBase};uid={sID};pwd={sPassword};connect timeout={TimeOut}";
            return connString;
        }

        public static void InsertInfoToGlassTable(Glass glass)
        {
            using (SqlConnection sqlconnection = new SqlConnection(GetConnectionInformation()))
            {                
                SqlCommand sqlCommand = new SqlCommand("proc_InsertGlassInfo", sqlconnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlconnection.Open();

                sqlCommand.Parameters.Add(new SqlParameter("@RecipeID", SqlDbType.VarChar));
                sqlCommand.Parameters["@RecipeID"].Value = glass.Recipe_ID;

                sqlCommand.Parameters.Add(new SqlParameter("@ProcessType", SqlDbType.VarChar));
                sqlCommand.Parameters["@ProcessType"].Value = glass.ProcessType;

                sqlCommand.Parameters.Add(new SqlParameter("@EQID", SqlDbType.Int));
                sqlCommand.Parameters["@EQID"].Value = glass.EQID;

                sqlCommand.Parameters.Add(new SqlParameter("@GlassName", SqlDbType.NVarChar));
                sqlCommand.Parameters["@GlassName"].Value = glass.GlassName;

                sqlCommand.Parameters.Add(new SqlParameter("@ModelNum", SqlDbType.Int));
                sqlCommand.Parameters["@ModelNum"].Value = glass.Model_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@PanelNum", SqlDbType.Int));
                sqlCommand.Parameters["@PanelNum"].Value = glass.Panel_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@DefectNum", SqlDbType.Int));
                sqlCommand.Parameters["@DefectNum"].Value = glass.DefectNum;

                sqlCommand.Parameters.Add(new SqlParameter("@TactTime", SqlDbType.NVarChar));
                string myDateString = DateTime.Now.ToString("HH:mm:ss");
                sqlCommand.Parameters["@TactTime"].Value = glass.TactTime;

                sqlCommand.Parameters.Add(new SqlParameter("@NGGlass", SqlDbType.Bit));
                sqlCommand.Parameters["@NGGlass"].Value = glass.NGGlass;

                sqlCommand.Parameters.Add(new SqlParameter("@MaskCommonDefect", SqlDbType.Bit));
                sqlCommand.Parameters["@MaskCommonDefect"].Value = glass.MaskCommonDefect;

                sqlCommand.Parameters.Add(new SqlParameter("@GlassCommonDefect", SqlDbType.Bit));
                sqlCommand.Parameters["@GlassCommonDefect"].Value = glass.GlassCommonDefect;

                sqlCommand.Parameters.Add(new SqlParameter("@IsFileUpload", SqlDbType.Bit));
                sqlCommand.Parameters["@IsFileUpload"].Value = glass.IsFileUpload;

                sqlCommand.Parameters.Add(new SqlParameter("@S_Size_DefectNum", SqlDbType.Int));
                sqlCommand.Parameters["@S_Size_DefectNum"].Value = glass.S_Size_Defect_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@M_Size_DefectNum", SqlDbType.Int));
                sqlCommand.Parameters["@M_Size_DefectNum"].Value = glass.M_Size_Defect_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@L_Size_DefectNum", SqlDbType.Int));
                sqlCommand.Parameters["@L_Size_DefectNum"].Value = glass.L_Size_Defect_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@O_Size_DefectNum", SqlDbType.Int));
                sqlCommand.Parameters["@O_Size_DefectNum"].Value = glass.O_Size_Defect_Num;

                sqlCommand.Parameters.Add(new SqlParameter("@GlassImage", SqlDbType.Image));
                sqlCommand.Parameters["@GlassImage"].Value = null;

                sqlCommand.Parameters.Add(new SqlParameter("@GlassLevel", SqlDbType.Int));
                sqlCommand.Parameters["@GlassLevel"].Value = glass.GlassLevel;

                sqlCommand.ExecuteNonQuery();      
            }
        }
    }
}
