using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Wattson
{
    class WattsonSuit
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] WattsonSuit_col;
        public ReallyData[] WattsonSuit_nml;
        public ReallyData[] WattsonSuit_gls;
        public ReallyData[] WattsonSuit_spc;
        public ReallyData[] WattsonSuit_ao;
        public ReallyData[] WattsonSuit_cav;

        public WattsonSuit()
        {
            //int i = 1;

            WattsonSuit_col = new ReallyData[3];
            WattsonSuit_nml = new ReallyData[3];
            WattsonSuit_gls = new ReallyData[3];
            WattsonSuit_spc = new ReallyData[3];
            WattsonSuit_ao = new ReallyData[3];
            WattsonSuit_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            WattsonSuit_col[0].name = "col";
            WattsonSuit_col[0].seek = 2318077952;
            WattsonSuit_col[0].length = 131072; // 20000
            WattsonSuit_col[0].seeklength = 128;

            WattsonSuit_col[1].name = "col";
            WattsonSuit_col[1].seek = 2318209024;
            WattsonSuit_col[1].length = 524288; // 80000
            WattsonSuit_col[1].seeklength = 128;

            //nml
            WattsonSuit_nml[0].name = "nml";
            WattsonSuit_nml[0].seek = 2318733312;
            WattsonSuit_nml[0].length = 262144;
            WattsonSuit_nml[0].seeklength = 128;

            WattsonSuit_nml[1].name = "nml";
            WattsonSuit_nml[1].seek = 2318995456;
            WattsonSuit_nml[1].length = 1048576;
            WattsonSuit_nml[1].seeklength = 128;

            //gls
            WattsonSuit_gls[0].name = "gls";
            WattsonSuit_gls[0].seek = 2320044032;
            WattsonSuit_gls[0].length = 131072;
            WattsonSuit_gls[0].seeklength = 128;

            WattsonSuit_gls[1].name = "gls";
            WattsonSuit_gls[1].seek = 2320175104;
            WattsonSuit_gls[1].length = 524288;
            WattsonSuit_gls[1].seeklength = 128;

            //spc
            WattsonSuit_spc[0].name = "spc";
            WattsonSuit_spc[0].seek = 2320699392;
            WattsonSuit_spc[0].length = 131072;
            WattsonSuit_spc[0].seeklength = 128;

            WattsonSuit_spc[1].name = "spc";
            WattsonSuit_spc[1].seek = 2320830464;
            WattsonSuit_spc[1].length = 524288;
            WattsonSuit_spc[1].seeklength = 128;

            //ao
            WattsonSuit_ao[0].name = "ao";
            WattsonSuit_ao[0].seek = 2322010112;
            WattsonSuit_ao[0].length = 131072;
            WattsonSuit_ao[0].seeklength = 128;

            WattsonSuit_ao[1].name = "ao";
            WattsonSuit_ao[1].seek = 2322141184;
            WattsonSuit_ao[1].length = 524288;
            WattsonSuit_ao[1].seeklength = 128;

            //cav
            WattsonSuit_cav[0].name = "cav";
            WattsonSuit_cav[0].seek = 2321354752;
            WattsonSuit_cav[0].length = 131072;
            WattsonSuit_cav[0].seeklength = 128;

            WattsonSuit_cav[1].name = "cav";
            WattsonSuit_cav[1].seek = 2321485824;
            WattsonSuit_cav[1].length = 524288;
            WattsonSuit_cav[1].seeklength = 128;
        }
    }
}
