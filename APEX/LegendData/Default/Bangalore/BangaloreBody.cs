using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreBody
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreBody_col;
        public ReallyData[] BangaloreBody_nml;
        public ReallyData[] BangaloreBody_gls;
        public ReallyData[] BangaloreBody_spc;
        public ReallyData[] BangaloreBody_ao;
        public ReallyData[] BangaloreBody_cav;

        public BangaloreBody()
        {
            //int i = 1;

            BangaloreBody_col = new ReallyData[3];
            BangaloreBody_nml = new ReallyData[3];
            BangaloreBody_gls = new ReallyData[3];
            BangaloreBody_spc = new ReallyData[3];
            BangaloreBody_ao = new ReallyData[3];
            BangaloreBody_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreBody_col[1].name = "col";
            BangaloreBody_col[1].seek = 3014201344;
            BangaloreBody_col[1].length = 524288;
            BangaloreBody_col[1].seeklength = 128;

            BangaloreBody_col[2].name = "col";
            BangaloreBody_col[2].seek = 3014725632;
            BangaloreBody_col[2].length = 2097152;
            BangaloreBody_col[2].seeklength = 128;

            BangaloreBody_nml[1].name = "nml";
            BangaloreBody_nml[1].seek = 3016822784;
            BangaloreBody_nml[1].length = 1048576;
            BangaloreBody_nml[1].seeklength = 128;

            BangaloreBody_nml[2].name = "nml";
            BangaloreBody_nml[2].seek = 3017871360;
            BangaloreBody_nml[2].length = 4194304;
            BangaloreBody_nml[2].seeklength = 128;

            BangaloreBody_gls[1].name = "gls";
            BangaloreBody_gls[1].seek = 3022065664;
            BangaloreBody_gls[1].length = 524288;
            BangaloreBody_gls[1].seeklength = 128;

            BangaloreBody_gls[2].name = "gls";
            BangaloreBody_gls[2].seek = 3022589952;
            BangaloreBody_gls[2].length = 2097152; 
            BangaloreBody_gls[2].seeklength = 128;

            BangaloreBody_spc[1].name = "spc";
            BangaloreBody_spc[1].seek = 263196672;
            BangaloreBody_spc[1].length = 524288;
            BangaloreBody_spc[1].seeklength = 128;

            BangaloreBody_spc[2].name = "spc";
            BangaloreBody_spc[2].seek = 3024687104;
            BangaloreBody_spc[2].length = 2097152;
            BangaloreBody_spc[2].seeklength = 128;

            BangaloreBody_ao[1].name = "ao";
            BangaloreBody_ao[1].seek = 3035172864;
            BangaloreBody_ao[1].length = 524288;
            BangaloreBody_ao[1].seeklength = 128;

            BangaloreBody_ao[2].name = "ao";
            BangaloreBody_ao[2].seek = 3035697152;
            BangaloreBody_ao[2].length = 2097152;
            BangaloreBody_ao[2].seeklength = 128;

            BangaloreBody_cav[1].name = "cav";
            BangaloreBody_cav[1].seek = 3037794304;
            BangaloreBody_cav[1].length = 524288;
            BangaloreBody_cav[1].seeklength = 128;

            BangaloreBody_cav[2].name = "cav";
            BangaloreBody_cav[2].seek = 3038318592;
            BangaloreBody_cav[2].length = 2097152;
            BangaloreBody_cav[2].seeklength = 128;
        }
    }
}
