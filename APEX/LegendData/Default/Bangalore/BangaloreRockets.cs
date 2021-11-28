using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreRockets
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreRockets_col;
        public ReallyData[] BangaloreRockets_nml;
        public ReallyData[] BangaloreRockets_gls;
        public ReallyData[] BangaloreRockets_spc;
        public ReallyData[] BangaloreRockets_ao;
        public ReallyData[] BangaloreRockets_cav;
        public ReallyData[] BangaloreRockets_ilm;

        public BangaloreRockets()
        {
            //int i = 1;

            BangaloreRockets_col = new ReallyData[3];
            BangaloreRockets_nml = new ReallyData[3];
            BangaloreRockets_gls = new ReallyData[3];
            BangaloreRockets_spc = new ReallyData[3];
            BangaloreRockets_ao = new ReallyData[3];
            BangaloreRockets_cav = new ReallyData[3];
            BangaloreRockets_ilm = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreRockets_col[1].name = "col";
            BangaloreRockets_col[1].seek = 8519094272;
            BangaloreRockets_col[1].length = 524288;
            BangaloreRockets_col[1].seeklength = 128;

            BangaloreRockets_col[2].name = "col";
            BangaloreRockets_col[2].seek = 8519618560;
            BangaloreRockets_col[2].length = 2097152;
            BangaloreRockets_col[2].seeklength = 128;

            BangaloreRockets_nml[1].name = "nml";
            BangaloreRockets_nml[1].seek = 8521715712;
            BangaloreRockets_nml[1].length = 1048576;
            BangaloreRockets_nml[1].seeklength = 128;

            BangaloreRockets_nml[2].name = "nml";
            BangaloreRockets_nml[2].seek = 8522764288;
            BangaloreRockets_nml[2].length = 4194304;
            BangaloreRockets_nml[2].seeklength = 128;

            BangaloreRockets_gls[1].name = "gls";
            BangaloreRockets_gls[1].seek = 8526958592;
            BangaloreRockets_gls[1].length = 524288;
            BangaloreRockets_gls[1].seeklength = 128;

            BangaloreRockets_gls[2].name = "gls";
            BangaloreRockets_gls[2].seek = 8527482880;
            BangaloreRockets_gls[2].length = 2097152;
            BangaloreRockets_gls[2].seeklength = 128;

            BangaloreRockets_spc[1].name = "spc";
            BangaloreRockets_spc[1].seek = 8529580032;
            BangaloreRockets_spc[1].length = 524288;
            BangaloreRockets_spc[1].seeklength = 128;

            BangaloreRockets_spc[2].name = "spc";
            BangaloreRockets_spc[2].seek = 8530104320;
            BangaloreRockets_spc[2].length = 2097152;
            BangaloreRockets_spc[2].seeklength = 128;

            BangaloreRockets_ao[1].name = "ao";
            BangaloreRockets_ao[1].seek = 8534822912;
            BangaloreRockets_ao[1].length = 524288;
            BangaloreRockets_ao[1].seeklength = 128;

            BangaloreRockets_ao[2].name = "ao";
            BangaloreRockets_ao[2].seek = 8535347200;
            BangaloreRockets_ao[2].length = 2097152;
            BangaloreRockets_ao[2].seeklength = 128;

            BangaloreRockets_cav[1].name = "cav";
            BangaloreRockets_cav[1].seek = 8537444352;
            BangaloreRockets_cav[1].length = 524288;
            BangaloreRockets_cav[1].seeklength = 128;

            BangaloreRockets_cav[2].name = "cav";
            BangaloreRockets_cav[2].seek = 8537968640;
            BangaloreRockets_cav[2].length = 2097152;
            BangaloreRockets_cav[2].seeklength = 128;

            BangaloreRockets_ilm[1].name = "ilm";
            BangaloreRockets_ilm[1].seek = 8532201472;
            BangaloreRockets_ilm[1].length = 524288;
            BangaloreRockets_ilm[1].seeklength = 128;

            BangaloreRockets_ilm[2].name = "ilm";
            BangaloreRockets_ilm[2].seek = 8532725760;
            BangaloreRockets_ilm[2].length = 2097152;
            BangaloreRockets_ilm[2].seeklength = 128;
        }
    }
}
