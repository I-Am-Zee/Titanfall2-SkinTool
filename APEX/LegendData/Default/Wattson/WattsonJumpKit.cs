using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Wattson
{
    class WattsonJumpKit
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] WattsonJumpKit_col;
        public ReallyData[] WattsonJumpKit_nml;
        public ReallyData[] WattsonJumpKit_gls;
        public ReallyData[] WattsonJumpKit_spc;
        public ReallyData[] WattsonJumpKit_ao;
        public ReallyData[] WattsonJumpKit_cav;

        public WattsonJumpKit()
        {
            //int i = 1;

            WattsonJumpKit_col = new ReallyData[3];
            WattsonJumpKit_nml = new ReallyData[3];
            WattsonJumpKit_gls = new ReallyData[3];
            WattsonJumpKit_spc = new ReallyData[3];
            WattsonJumpKit_ao = new ReallyData[3];
            WattsonJumpKit_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            WattsonJumpKit_col[0].name = "col";
            WattsonJumpKit_col[0].seek = 2300383232;
            WattsonJumpKit_col[0].length = 131072;
            WattsonJumpKit_col[0].seeklength = 128;

            WattsonJumpKit_col[1].name = "col";
            WattsonJumpKit_col[1].seek = 2300514304;
            WattsonJumpKit_col[1].length = 524288;
            WattsonJumpKit_col[1].seeklength = 128;

            //nml
            WattsonJumpKit_nml[0].name = "nml";
            WattsonJumpKit_nml[0].seek = 2301038592;
            WattsonJumpKit_nml[0].length = 262144;
            WattsonJumpKit_nml[0].seeklength = 128;

            WattsonJumpKit_nml[1].name = "nml";
            WattsonJumpKit_nml[1].seek = 2301300736;
            WattsonJumpKit_nml[1].length = 1048576;
            WattsonJumpKit_nml[1].seeklength = 128;

            //gls
            WattsonJumpKit_gls[0].name = "gls";
            WattsonJumpKit_gls[0].seek = 2302349312;
            WattsonJumpKit_gls[0].length = 131072;
            WattsonJumpKit_gls[0].seeklength = 128;

            WattsonJumpKit_gls[1].name = "gls";
            WattsonJumpKit_gls[1].seek = 2302480384;
            WattsonJumpKit_gls[1].length = 524288;
            WattsonJumpKit_gls[1].seeklength = 128;

            //spc
            WattsonJumpKit_spc[0].name = "spc";
            WattsonJumpKit_spc[0].seek = 2303004672;
            WattsonJumpKit_spc[0].length = 131072;
            WattsonJumpKit_spc[0].seeklength = 128;

            WattsonJumpKit_spc[1].name = "spc";
            WattsonJumpKit_spc[1].seek = 2303135744;
            WattsonJumpKit_spc[1].length = 524288;
            WattsonJumpKit_spc[1].seeklength = 128;

            //ao
            WattsonJumpKit_ao[0].name = "ao";
            WattsonJumpKit_ao[0].seek = 2304315392;
            WattsonJumpKit_ao[0].length = 131072;
            WattsonJumpKit_ao[0].seeklength = 128;

            WattsonJumpKit_ao[1].name = "ao";
            WattsonJumpKit_ao[1].seek = 2304446464;
            WattsonJumpKit_ao[1].length = 524288;
            WattsonJumpKit_ao[1].seeklength = 128;

            //cav
            WattsonJumpKit_cav[0].name = "cav";
            WattsonJumpKit_cav[0].seek = 2303660032;
            WattsonJumpKit_cav[0].length = 131072;
            WattsonJumpKit_cav[0].seeklength = 128;

            WattsonJumpKit_cav[1].name = "cav";
            WattsonJumpKit_cav[1].seek = 2303791104;
            WattsonJumpKit_cav[1].length = 524288;
            WattsonJumpKit_cav[1].seeklength = 128;
        }
    }
}
