using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Wattson
{
    class WattsonViewModel
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] WattsonViewModel_col;
        public ReallyData[] WattsonViewModel_nml;
        public ReallyData[] WattsonViewModel_gls;
        public ReallyData[] WattsonViewModel_spc;
        public ReallyData[] WattsonViewModel_ao;
        public ReallyData[] WattsonViewModel_cav;
        public ReallyData[] WattsonViewModel_ilm;

        public WattsonViewModel()
        {
            //int i = 1;

            WattsonViewModel_col = new ReallyData[3];
            WattsonViewModel_nml = new ReallyData[3];
            WattsonViewModel_gls = new ReallyData[3];
            WattsonViewModel_spc = new ReallyData[3];
            WattsonViewModel_ao = new ReallyData[3];
            WattsonViewModel_cav = new ReallyData[3];
            WattsonViewModel_ilm = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            WattsonViewModel_col[1].name = "col";
            WattsonViewModel_col[1].seek = 8540065792;
            WattsonViewModel_col[1].length = 524288;
            WattsonViewModel_col[1].seeklength = 128;

            WattsonViewModel_col[2].name = "col";
            WattsonViewModel_col[2].seek = 8540590080;
            WattsonViewModel_col[2].length = 2097152;
            WattsonViewModel_col[2].seeklength = 128;

            //nml
            WattsonViewModel_nml[1].name = "nml";
            WattsonViewModel_nml[1].seek = 8542687232;
            WattsonViewModel_nml[1].length = 1048576;
            WattsonViewModel_nml[1].seeklength = 128;

            WattsonViewModel_nml[2].name = "nml";
            WattsonViewModel_nml[2].seek = 8543735808;
            WattsonViewModel_nml[2].length = 4194304;
            WattsonViewModel_nml[2].seeklength = 128;

            //gls
            WattsonViewModel_gls[1].name = "gls";
            WattsonViewModel_gls[1].seek = 8547930112;
            WattsonViewModel_gls[1].length = 524288;
            WattsonViewModel_gls[1].seeklength = 128;

            WattsonViewModel_gls[2].name = "gls";
            WattsonViewModel_gls[2].seek = 8548454400;
            WattsonViewModel_gls[2].length = 2097152;
            WattsonViewModel_gls[2].seeklength = 128;

            //spc
            WattsonViewModel_spc[1].name = "spc";
            WattsonViewModel_spc[1].seek = 8550551552;
            WattsonViewModel_spc[1].length = 524288;
            WattsonViewModel_spc[1].seeklength = 128;

            WattsonViewModel_spc[2].name = "spc";
            WattsonViewModel_spc[2].seek = 8551075840;
            WattsonViewModel_spc[2].length = 2097152;
            WattsonViewModel_spc[2].seeklength = 128;

            //ao
            WattsonViewModel_ao[1].name = "ao";
            WattsonViewModel_ao[1].seek = 8558415872;
            WattsonViewModel_ao[1].length = 524288;
            WattsonViewModel_ao[1].seeklength = 128;

            WattsonViewModel_ao[2].name = "ao";
            WattsonViewModel_ao[2].seek = 8558940160;
            WattsonViewModel_ao[2].length = 2097152;
            WattsonViewModel_ao[2].seeklength = 128;

            //cav
            WattsonViewModel_cav[1].name = "cav";
            WattsonViewModel_cav[1].seek = 8555794432;
            WattsonViewModel_cav[1].length = 524288;
            WattsonViewModel_cav[1].seeklength = 128;

            WattsonViewModel_cav[2].name = "cav";
            WattsonViewModel_cav[2].seek = 8556318720;
            WattsonViewModel_cav[2].length = 2097152;
            WattsonViewModel_cav[2].seeklength = 128;

            //ilm
            WattsonViewModel_ilm[0].name = "ilm";
            WattsonViewModel_ilm[0].seek = 8553172992;
            WattsonViewModel_ilm[0].length = 524288;
            WattsonViewModel_ilm[0].seeklength = 128;

            WattsonViewModel_ilm[1].name = "ilm";
            WattsonViewModel_ilm[1].seek = 8553697280;
            WattsonViewModel_ilm[1].length = 2097152;
            WattsonViewModel_ilm[1].seeklength = 128;
        }
    }
}
