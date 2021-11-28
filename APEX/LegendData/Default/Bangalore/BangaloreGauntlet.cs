using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreGauntlet
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreGauntlet_col;
        public ReallyData[] BangaloreGauntlet_nml;
        public ReallyData[] BangaloreGauntlet_gls;
        public ReallyData[] BangaloreGauntlet_spc;
        public ReallyData[] BangaloreGauntlet_ao;
        public ReallyData[] BangaloreGauntlet_cav;

        public BangaloreGauntlet()
        {
            //int i = 1;

            BangaloreGauntlet_col = new ReallyData[3];
            BangaloreGauntlet_nml = new ReallyData[3];
            BangaloreGauntlet_gls = new ReallyData[3];
            BangaloreGauntlet_spc = new ReallyData[3];
            BangaloreGauntlet_ao = new ReallyData[3];
            BangaloreGauntlet_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreGauntlet_col[1].name = "col";
            BangaloreGauntlet_col[1].seek = 3229159424;
            BangaloreGauntlet_col[1].length = 524288;
            BangaloreGauntlet_col[1].seeklength = 128;

            BangaloreGauntlet_col[2].name = "col";
            BangaloreGauntlet_col[2].seek = 3229683712;
            BangaloreGauntlet_col[2].length = 2097152;
            BangaloreGauntlet_col[2].seeklength = 128;

            BangaloreGauntlet_nml[1].name = "nml";
            BangaloreGauntlet_nml[1].seek = 3231780864;
            BangaloreGauntlet_nml[1].length = 1048576;
            BangaloreGauntlet_nml[1].seeklength = 128;

            BangaloreGauntlet_nml[2].name = "nml";
            BangaloreGauntlet_nml[2].seek = 3232829440;
            BangaloreGauntlet_nml[2].length = 4194304;
            BangaloreGauntlet_nml[2].seeklength = 128;

            BangaloreGauntlet_gls[1].name = "gls";
            BangaloreGauntlet_gls[1].seek = 3237023744;
            BangaloreGauntlet_gls[1].length = 524288;
            BangaloreGauntlet_gls[1].seeklength = 128;

            BangaloreGauntlet_gls[2].name = "gls";
            BangaloreGauntlet_gls[2].seek = 3237548032;
            BangaloreGauntlet_gls[2].length = 2097152; 
            BangaloreGauntlet_gls[2].seeklength = 128;

            BangaloreGauntlet_spc[1].name = "spc";
            BangaloreGauntlet_spc[1].seek = 3239645184;
            BangaloreGauntlet_spc[1].length = 524288;
            BangaloreGauntlet_spc[1].seeklength = 128;

            BangaloreGauntlet_spc[2].name = "spc";
            BangaloreGauntlet_spc[2].seek = 3240169472;
            BangaloreGauntlet_spc[2].length = 2097152;
            BangaloreGauntlet_spc[2].seeklength = 128;

            BangaloreGauntlet_ao[1].name = "ao";
            BangaloreGauntlet_ao[1].seek = 3242266624;
            BangaloreGauntlet_ao[1].length = 524288;
            BangaloreGauntlet_ao[1].seeklength = 128;

            BangaloreGauntlet_ao[2].name = "ao";
            BangaloreGauntlet_ao[2].seek = 3242790912;
            BangaloreGauntlet_ao[2].length = 2097152;
            BangaloreGauntlet_ao[2].seeklength = 128;

            BangaloreGauntlet_cav[0].name = "cav";
            BangaloreGauntlet_cav[0].seek = 3244888064;
            BangaloreGauntlet_cav[0].length = 131072;
            BangaloreGauntlet_cav[0].seeklength = 128;

            BangaloreGauntlet_cav[1].name = "cav";
            BangaloreGauntlet_cav[1].seek = 3245019136;
            BangaloreGauntlet_cav[1].length = 524288;
            BangaloreGauntlet_cav[1].seeklength = 128;
        }
    }
}
