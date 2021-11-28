using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bangalore
{
    class BangaloreVM
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BangaloreVM_col;
        public ReallyData[] BangaloreVM_nml;
        public ReallyData[] BangaloreVM_gls;
        public ReallyData[] BangaloreVM_spc;
        public ReallyData[] BangaloreVM_ao;
        public ReallyData[] BangaloreVM_cav;

        public BangaloreVM()
        {
            //int i = 1;

            BangaloreVM_col = new ReallyData[3];
            BangaloreVM_nml = new ReallyData[3];
            BangaloreVM_gls = new ReallyData[3];
            BangaloreVM_spc = new ReallyData[3];
            BangaloreVM_ao = new ReallyData[3];
            BangaloreVM_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BangaloreVM_col[1].name = "col";
            BangaloreVM_col[1].seek = 6315380736;
            BangaloreVM_col[1].length = 524288;
            BangaloreVM_col[1].seeklength = 128;

            BangaloreVM_col[2].name = "col";
            BangaloreVM_col[2].seek = 6315905024;
            BangaloreVM_col[2].length = 2097152;
            BangaloreVM_col[2].seeklength = 128;

            BangaloreVM_nml[1].name = "nml";
            BangaloreVM_nml[1].seek = 6318002176;
            BangaloreVM_nml[1].length = 1048576;
            BangaloreVM_nml[1].seeklength = 128;

            BangaloreVM_nml[2].name = "nml";
            BangaloreVM_nml[2].seek = 6319050752;
            BangaloreVM_nml[2].length = 4194304;
            BangaloreVM_nml[2].seeklength = 128;

            BangaloreVM_gls[1].name = "gls";
            BangaloreVM_gls[1].seek = 6323245056;
            BangaloreVM_gls[1].length = 524288;
            BangaloreVM_gls[1].seeklength = 128;

            BangaloreVM_gls[2].name = "gls";
            BangaloreVM_gls[2].seek = 6323769344;
            BangaloreVM_gls[2].length = 2097152; 
            BangaloreVM_gls[2].seeklength = 128;

            BangaloreVM_spc[1].name = "spc";
            BangaloreVM_spc[1].seek = 6325866496;
            BangaloreVM_spc[1].length = 524288;
            BangaloreVM_spc[1].seeklength = 128;

            BangaloreVM_spc[2].name = "spc";
            BangaloreVM_spc[2].seek = 6326390784;
            BangaloreVM_spc[2].length = 2097152;
            BangaloreVM_spc[2].seeklength = 128;

            BangaloreVM_ao[0].name = "ao";
            BangaloreVM_ao[0].seek = 6328487936;
            BangaloreVM_ao[0].length = 131072;
            BangaloreVM_ao[0].seeklength = 128;

            BangaloreVM_ao[1].name = "ao";
            BangaloreVM_ao[1].seek = 6328619008;
            BangaloreVM_ao[1].length = 524288;
            BangaloreVM_ao[1].seeklength = 128;

            BangaloreVM_cav[1].name = "cav";
            BangaloreVM_cav[1].seek = 6329143296;
            BangaloreVM_cav[1].length = 131072;
            BangaloreVM_cav[1].seeklength = 128;

            BangaloreVM_cav[2].name = "cav";
            BangaloreVM_cav[2].seek = 6329274368;
            BangaloreVM_cav[2].length = 524288;
            BangaloreVM_cav[2].seeklength = 128;
        }
    }
}
