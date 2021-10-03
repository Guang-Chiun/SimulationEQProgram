using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationEQProgram
{
    public class Glass
    {
        public string GlassID { get; set; }
        public string Recipe_ID { get; set; }
        public string ProcessType { get; set; }
        public int EQID { get; set; }
        public string GlassName { get; set; }
        public int Model_Num { get; set; }
        public int Panel_Num { get; set; }
        public int DefectNum { get; set; }
        public string TactTime { get; set; }
        public bool NGGlass { get; set; }
        public bool MaskCommonDefect { get; set; }
        public bool GlassCommonDefect { get; set; }
        public bool IsFileUpload { get; set; }
        public int S_Size_Defect_Num { get; set; }
        public int M_Size_Defect_Num { get; set; }
        public int L_Size_Defect_Num { get; set; }
        public int O_Size_Defect_Num { get; set; }
        public int GlassImage { get; set; }
        public int GlassLevel { get; set; }
    }
}
