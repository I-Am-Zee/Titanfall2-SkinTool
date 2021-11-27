using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundVMA
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundVMA_col;
        public ReallyData[] BloodhoundVMA_nml;
        public ReallyData[] BloodhoundVMA_gls;
        public ReallyData[] BloodhoundVMA_spc;
        public ReallyData[] BloodhoundVMA_ao;
        public ReallyData[] BloodhoundVMA_cav;

        public BloodhoundVMA()
        {
            //int i = 1;

            BloodhoundVMA_col = new ReallyData[3];
            BloodhoundVMA_nml = new ReallyData[3];
            BloodhoundVMA_gls = new ReallyData[3];
            BloodhoundVMA_spc = new ReallyData[3];
            BloodhoundVMA_ao = new ReallyData[3];
            BloodhoundVMA_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundVMA_col[1].name = "col";
            BloodhoundVMA_col[1].seek = 6416306176;
            BloodhoundVMA_col[1].length = 524288;
            BloodhoundVMA_col[1].seeklength = 128;

            BloodhoundVMA_col[2].name = "col";
            BloodhoundVMA_col[2].seek = 6416830464;
            BloodhoundVMA_col[2].length = 2097152;
            BloodhoundVMA_col[2].seeklength = 128;

            BloodhoundVMA_nml[1].name = "nml";
            BloodhoundVMA_nml[1].seek = 6418927616;
            BloodhoundVMA_nml[1].length = 1048576;
            BloodhoundVMA_nml[1].seeklength = 128;

            BloodhoundVMA_nml[2].name = "nml";
            BloodhoundVMA_nml[2].seek = 6419976192;
            BloodhoundVMA_nml[2].length = 4194304;
            BloodhoundVMA_nml[2].seeklength = 128;

            BloodhoundVMA_gls[1].name = "gls";
            BloodhoundVMA_gls[1].seek = 6424170496;
            BloodhoundVMA_gls[1].length = 524288;
            BloodhoundVMA_gls[1].seeklength = 128;

            BloodhoundVMA_gls[2].name = "gls";
            BloodhoundVMA_gls[2].seek = 6424694784;
            BloodhoundVMA_gls[2].length = 2097152; 
            BloodhoundVMA_gls[2].seeklength = 128;

            BloodhoundVMA_spc[1].name = "spc";
            BloodhoundVMA_spc[1].seek = 6426791936;
            BloodhoundVMA_spc[1].length = 524288;
            BloodhoundVMA_spc[1].seeklength = 128;

            BloodhoundVMA_spc[2].name = "spc";
            BloodhoundVMA_spc[2].seek = 6427316224;
            BloodhoundVMA_spc[2].length = 2097152;
            BloodhoundVMA_spc[2].seeklength = 128;

            BloodhoundVMA_ao[1].name = "ao";
            BloodhoundVMA_ao[1].seek = 6429413376;
            BloodhoundVMA_ao[1].length = 524288;
            BloodhoundVMA_ao[1].seeklength = 128;

            BloodhoundVMA_ao[2].name = "ao";
            BloodhoundVMA_ao[2].seek = 6429937664;
            BloodhoundVMA_ao[2].length = 2097152;
            BloodhoundVMA_ao[2].seeklength = 128;

            BloodhoundVMA_cav[0].name = "cav";
            BloodhoundVMA_cav[0].seek = 6432034816;
            BloodhoundVMA_cav[0].length = 131072;
            BloodhoundVMA_cav[0].seeklength = 128;

            BloodhoundVMA_cav[1].name = "cav";
            BloodhoundVMA_cav[1].seek = 6432165888;
            BloodhoundVMA_cav[1].length = 524288;
            BloodhoundVMA_cav[1].seeklength = 128;
        }
    }
}
