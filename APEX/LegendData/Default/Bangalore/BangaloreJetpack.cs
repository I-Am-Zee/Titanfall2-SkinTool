using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreJetpack
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreJetpack_col;
        public ReallyData[] BangaloreJetpack_nml;
        public ReallyData[] BangaloreJetpack_gls;
        public ReallyData[] BangaloreJetpack_spc;
        public ReallyData[] BangaloreJetpack_ao;
        public ReallyData[] BangaloreJetpack_cav;

        public BangaloreJetpack()
        {
            //int i = 1;

            BangaloreJetpack_col = new ReallyData[3];
            BangaloreJetpack_nml = new ReallyData[3];
            BangaloreJetpack_gls = new ReallyData[3];
            BangaloreJetpack_spc = new ReallyData[3];
            BangaloreJetpack_ao = new ReallyData[3];
            BangaloreJetpack_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreJetpack_col[0].name = "col";
            BangaloreJetpack_col[0].seek = 3361542144;
            BangaloreJetpack_col[0].length = 131072;
            BangaloreJetpack_col[0].seeklength = 128;

            BangaloreJetpack_col[1].name = "col";
            BangaloreJetpack_col[1].seek = 3361673216;
            BangaloreJetpack_col[1].length = 524288;
            BangaloreJetpack_col[1].seeklength = 128;

            BangaloreJetpack_nml[0].name = "nml";
            BangaloreJetpack_nml[0].seek = 3362197504;
            BangaloreJetpack_nml[0].length = 262144;
            BangaloreJetpack_nml[0].seeklength = 128;

            BangaloreJetpack_nml[1].name = "nml";
            BangaloreJetpack_nml[1].seek = 3362459648;
            BangaloreJetpack_nml[1].length = 1048576;
            BangaloreJetpack_nml[1].seeklength = 128;

            BangaloreJetpack_gls[0].name = "gls";
            BangaloreJetpack_gls[0].seek = 3363508224;
            BangaloreJetpack_gls[0].length = 131072;
            BangaloreJetpack_gls[0].seeklength = 128;

            BangaloreJetpack_gls[1].name = "gls";
            BangaloreJetpack_gls[1].seek = 3363639296;
            BangaloreJetpack_gls[1].length = 524288; 
            BangaloreJetpack_gls[1].seeklength = 128;

            BangaloreJetpack_spc[0].name = "spc";
            BangaloreJetpack_spc[0].seek = 3364163584;
            BangaloreJetpack_spc[0].length = 131072;
            BangaloreJetpack_spc[0].seeklength = 128;

            BangaloreJetpack_spc[1].name = "spc";
            BangaloreJetpack_spc[1].seek = 3364294656;
            BangaloreJetpack_spc[1].length = 524288;
            BangaloreJetpack_spc[1].seeklength = 128;

            BangaloreJetpack_ao[0].name = "ao";
            BangaloreJetpack_ao[0].seek = 3364818944;
            BangaloreJetpack_ao[0].length = 131072;
            BangaloreJetpack_ao[0].seeklength = 128;

            BangaloreJetpack_ao[1].name = "ao";
            BangaloreJetpack_ao[1].seek = 3364950016;
            BangaloreJetpack_ao[1].length = 524288;
            BangaloreJetpack_ao[1].seeklength = 128;

            BangaloreJetpack_cav[0].name = "cav";
            BangaloreJetpack_cav[0].seek = 3365474304;
            BangaloreJetpack_cav[0].length = 131072;
            BangaloreJetpack_cav[0].seeklength = 128;

            BangaloreJetpack_cav[1].name = "cav";
            BangaloreJetpack_cav[1].seek = 3365605376;
            BangaloreJetpack_cav[1].length = 524288;
            BangaloreJetpack_cav[1].seeklength = 128;
        }
    }
}
