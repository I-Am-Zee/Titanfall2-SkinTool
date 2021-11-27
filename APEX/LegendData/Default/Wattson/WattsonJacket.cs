using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Wattson
{
    class WattsonJacket
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] WattsonJacket_col;
        public ReallyData[] WattsonJacket_nml;
        public ReallyData[] WattsonJacket_gls;
        public ReallyData[] WattsonJacket_spc;
        public ReallyData[] WattsonJacket_ao;
        public ReallyData[] WattsonJacket_cav;

        public WattsonJacket()
        {
            //int i = 1;

            WattsonJacket_col = new ReallyData[3];
            WattsonJacket_nml = new ReallyData[3];
            WattsonJacket_gls = new ReallyData[3];
            WattsonJacket_spc = new ReallyData[3];
            WattsonJacket_ao = new ReallyData[3];
            WattsonJacket_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            WattsonJacket_col[0].name = "col";
            WattsonJacket_col[0].seek = 2208632832;
            WattsonJacket_col[0].length = 131072;
            WattsonJacket_col[0].seeklength = 128;

            WattsonJacket_col[1].name = "col";
            WattsonJacket_col[1].seek = 2208763904;
            WattsonJacket_col[1].length = 524288;
            WattsonJacket_col[1].seeklength = 128;

            //nml
            WattsonJacket_nml[0].name = "nml";
            WattsonJacket_nml[0].seek = 2209288192;
            WattsonJacket_nml[0].length = 262144;
            WattsonJacket_nml[0].seeklength = 128;

            WattsonJacket_nml[1].name = "nml";
            WattsonJacket_nml[1].seek = 2209550336;
            WattsonJacket_nml[1].length = 1048576;
            WattsonJacket_nml[1].seeklength = 128;

            //gls
            WattsonJacket_gls[0].name = "gls";
            WattsonJacket_gls[0].seek = 2210598912;
            WattsonJacket_gls[0].length = 131072;
            WattsonJacket_gls[0].seeklength = 128;

            WattsonJacket_gls[1].name = "gls";
            WattsonJacket_gls[1].seek = 2210729984;
            WattsonJacket_gls[1].length = 524288;
            WattsonJacket_gls[1].seeklength = 128;

            //spc
            WattsonJacket_spc[0].name = "spc";
            WattsonJacket_spc[0].seek = 2211254272;
            WattsonJacket_spc[0].length = 131072;
            WattsonJacket_spc[0].seeklength = 128;

            WattsonJacket_spc[1].name = "spc";
            WattsonJacket_spc[1].seek = 2211385344;
            WattsonJacket_spc[1].length = 524288;
            WattsonJacket_spc[1].seeklength = 128;

            //ao
            WattsonJacket_ao[0].name = "ao";
            WattsonJacket_ao[0].seek = 2212564992;
            WattsonJacket_ao[0].length = 131072;
            WattsonJacket_ao[0].seeklength = 128;

            WattsonJacket_ao[1].name = "ao";
            WattsonJacket_ao[1].seek = 2212696064;
            WattsonJacket_ao[1].length = 524288;
            WattsonJacket_ao[1].seeklength = 128;

            //cav
            WattsonJacket_cav[0].name = "cav";
            WattsonJacket_cav[0].seek = 2211909632;
            WattsonJacket_cav[0].length = 131072;
            WattsonJacket_cav[0].seeklength = 128;

            WattsonJacket_cav[1].name = "cav";
            WattsonJacket_cav[1].seek = 2212040704;
            WattsonJacket_cav[1].length = 524288;
            WattsonJacket_cav[1].seeklength = 128;
        }
    }
}
