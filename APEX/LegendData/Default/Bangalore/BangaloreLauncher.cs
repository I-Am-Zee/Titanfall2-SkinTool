using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreLauncher
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreLauncher_col;
        public ReallyData[] BangaloreLauncher_nml;
        public ReallyData[] BangaloreLauncher_spc;
        public ReallyData[] BangaloreLauncher_ao;
        public ReallyData[] BangaloreLauncher_cav;

        public BangaloreLauncher()
        {
            //int i = 1;

            BangaloreLauncher_col = new ReallyData[3];
            BangaloreLauncher_nml = new ReallyData[3];
            BangaloreLauncher_spc = new ReallyData[3];
            BangaloreLauncher_ao = new ReallyData[3];
            BangaloreLauncher_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreLauncher_col[0].name = "col";
            BangaloreLauncher_col[0].seek = 3407745024;
            BangaloreLauncher_col[0].length = 131072;
            BangaloreLauncher_col[0].seeklength = 128;

            BangaloreLauncher_col[1].name = "col";
            BangaloreLauncher_col[1].seek = 3407876096;
            BangaloreLauncher_col[1].length = 524288;
            BangaloreLauncher_col[1].seeklength = 128;

            BangaloreLauncher_nml[0].name = "nml";
            BangaloreLauncher_nml[0].seek = 3408400384;
            BangaloreLauncher_nml[0].length = 262144;
            BangaloreLauncher_nml[0].seeklength = 128;

            BangaloreLauncher_nml[1].name = "nml";
            BangaloreLauncher_nml[1].seek = 3408662528;
            BangaloreLauncher_nml[1].length = 1048576;
            BangaloreLauncher_nml[1].seeklength = 128;

            BangaloreLauncher_spc[0].name = "spc";
            BangaloreLauncher_spc[0].seek = 3410366464;
            BangaloreLauncher_spc[0].length = 131072;
            BangaloreLauncher_spc[0].seeklength = 128;

            BangaloreLauncher_spc[1].name = "spc";
            BangaloreLauncher_spc[1].seek = 3410497536;
            BangaloreLauncher_spc[1].length = 524288;
            BangaloreLauncher_spc[1].seeklength = 128;

            BangaloreLauncher_ao[0].name = "ao";
            BangaloreLauncher_ao[0].seek = 3409711104;
            BangaloreLauncher_ao[0].length = 131072;
            BangaloreLauncher_ao[0].seeklength = 128;

            BangaloreLauncher_ao[1].name = "ao";
            BangaloreLauncher_ao[1].seek = 3409842176;
            BangaloreLauncher_ao[1].length = 524288;
            BangaloreLauncher_ao[1].seeklength = 128;

            BangaloreLauncher_cav[0].name = "cav";
            BangaloreLauncher_cav[0].seek = 3411021824;
            BangaloreLauncher_cav[0].length = 131072;
            BangaloreLauncher_cav[0].seeklength = 128;

            BangaloreLauncher_cav[1].name = "cav";
            BangaloreLauncher_cav[1].seek = 3411152896;
            BangaloreLauncher_cav[1].length = 524288;
            BangaloreLauncher_cav[1].seeklength = 128;
        }
    }
}
