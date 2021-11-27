using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Wattson
{
    class WattsonGear
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] WattsonGear_col;
        public ReallyData[] WattsonGear_nml;
        public ReallyData[] WattsonGear_gls;
        public ReallyData[] WattsonGear_spc;
        public ReallyData[] WattsonGear_ao;
        public ReallyData[] WattsonGear_cav;
        public ReallyData[] WattsonGear_ilm;

        public WattsonGear()
        {
            //int i = 1;

            WattsonGear_col = new ReallyData[3];
            WattsonGear_nml = new ReallyData[3];
            WattsonGear_gls = new ReallyData[3];
            WattsonGear_spc = new ReallyData[3];
            WattsonGear_ao = new ReallyData[3];
            WattsonGear_cav = new ReallyData[3];
            WattsonGear_ilm = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            WattsonGear_col[0].name = "col";
            WattsonGear_col[0].seek = 2422280192;
            WattsonGear_col[0].length = 131072;
            WattsonGear_col[0].seeklength = 128;

            WattsonGear_col[1].name = "col";
            WattsonGear_col[1].seek = 2422411264;
            WattsonGear_col[1].length = 524288;
            WattsonGear_col[1].seeklength = 128;

            WattsonGear_nml[0].name = "nml";
            WattsonGear_nml[0].seek = 2422935552;
            WattsonGear_nml[0].length = 262144;
            WattsonGear_nml[0].seeklength = 128;

            WattsonGear_nml[1].name = "nml";
            WattsonGear_nml[1].seek = 2423197696;
            WattsonGear_nml[1].length = 1048576;
            WattsonGear_nml[1].seeklength = 128;

            WattsonGear_gls[0].name = "gls";
            WattsonGear_gls[0].seek = 2424246272;
            WattsonGear_gls[0].length = 131072; // 20000
            WattsonGear_gls[0].seeklength = 128;

            WattsonGear_gls[1].name = "gls";
            WattsonGear_gls[1].seek = 2424377344;
            WattsonGear_gls[1].length = 524288; 
            WattsonGear_gls[1].seeklength = 128;

            WattsonGear_spc[0].name = "spc";
            WattsonGear_spc[0].seek = 2424901632;
            WattsonGear_spc[0].length = 131072;
            WattsonGear_spc[0].seeklength = 128;

            WattsonGear_spc[1].name = "spc";
            WattsonGear_spc[1].seek = 2425032704;
            WattsonGear_spc[1].length = 524288;
            WattsonGear_spc[1].seeklength = 128;

            WattsonGear_ao[0].name = "ao";
            WattsonGear_ao[0].seek = 2426212352;
            WattsonGear_ao[0].length = 131072;
            WattsonGear_ao[0].seeklength = 128;

            WattsonGear_ao[1].name = "ao";
            WattsonGear_ao[1].seek = 2426998784;
            WattsonGear_ao[1].length = 524288;
            WattsonGear_ao[1].seeklength = 128;

            WattsonGear_cav[0].name = "cav";
            WattsonGear_cav[0].seek = 2426867712;
            WattsonGear_cav[0].length = 131072;
            WattsonGear_cav[0].seeklength = 128;

            WattsonGear_cav[1].name = "cav";
            WattsonGear_cav[1].seek = 2426343424;
            WattsonGear_cav[1].length = 524288;
            WattsonGear_cav[1].seeklength = 128;

            WattsonGear_ilm[0].name = "ilm";
            WattsonGear_ilm[0].seek = 2425556992;
            WattsonGear_ilm[0].length = 131072;
            WattsonGear_ilm[0].seeklength = 128;

            WattsonGear_ilm[1].name = "ilm";
            WattsonGear_ilm[1].seek = 2425688064;
            WattsonGear_ilm[1].length = 524288;
            WattsonGear_ilm[1].seeklength = 128;
        }
    }
}
