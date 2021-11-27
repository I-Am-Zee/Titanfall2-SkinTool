using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundVMG
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundVMG_col;
        public ReallyData[] BloodhoundVMG_nml;
        public ReallyData[] BloodhoundVMG_gls;
        public ReallyData[] BloodhoundVMG_spc;
        public ReallyData[] BloodhoundVMG_ao;
        public ReallyData[] BloodhoundVMG_cav;

        public BloodhoundVMG()
        {
            //int i = 1;

            BloodhoundVMG_col = new ReallyData[3];
            BloodhoundVMG_nml = new ReallyData[3];
            BloodhoundVMG_gls = new ReallyData[3];
            BloodhoundVMG_spc = new ReallyData[3];
            BloodhoundVMG_ao = new ReallyData[3];
            BloodhoundVMG_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundVMG_col[0].name = "col";
            BloodhoundVMG_col[0].seek = 6503469056;
            BloodhoundVMG_col[0].length = 131072;
            BloodhoundVMG_col[0].seeklength = 128;

            BloodhoundVMG_col[1].name = "col";
            BloodhoundVMG_col[1].seek = 6503600128;
            BloodhoundVMG_col[1].length = 524288;
            BloodhoundVMG_col[1].seeklength = 128;

            BloodhoundVMG_nml[0].name = "nml";
            BloodhoundVMG_nml[0].seek = 6504124416;
            BloodhoundVMG_nml[0].length = 262144;
            BloodhoundVMG_nml[0].seeklength = 128;

            BloodhoundVMG_nml[1].name = "nml";
            BloodhoundVMG_nml[1].seek = 6504386560;
            BloodhoundVMG_nml[1].length = 1048576;
            BloodhoundVMG_nml[1].seeklength = 128;

            BloodhoundVMG_gls[0].name = "gls";
            BloodhoundVMG_gls[0].seek = 6505435136;
            BloodhoundVMG_gls[0].length = 131072;
            BloodhoundVMG_gls[0].seeklength = 128;

            BloodhoundVMG_gls[1].name = "gls";
            BloodhoundVMG_gls[1].seek = 6505566208;
            BloodhoundVMG_gls[1].length = 524288; 
            BloodhoundVMG_gls[1].seeklength = 128;

            BloodhoundVMG_spc[0].name = "spc";
            BloodhoundVMG_spc[0].seek = 6506090496;
            BloodhoundVMG_spc[0].length = 131072;
            BloodhoundVMG_spc[0].seeklength = 128;

            BloodhoundVMG_spc[1].name = "spc";
            BloodhoundVMG_spc[1].seek = 6506221568;
            BloodhoundVMG_spc[1].length = 524288;
            BloodhoundVMG_spc[1].seeklength = 128;

            BloodhoundVMG_ao[0].name = "ao";
            BloodhoundVMG_ao[0].seek = 6506745856;
            BloodhoundVMG_ao[0].length = 131072;
            BloodhoundVMG_ao[0].seeklength = 128;

            BloodhoundVMG_ao[1].name = "ao";
            BloodhoundVMG_ao[1].seek = 6506876928;
            BloodhoundVMG_ao[1].length = 524288;
            BloodhoundVMG_ao[1].seeklength = 128;

            BloodhoundVMG_cav[0].name = "cav";
            BloodhoundVMG_cav[0].seek = 6507401216;
            BloodhoundVMG_cav[0].length = 131072;
            BloodhoundVMG_cav[0].seeklength = 128;

            BloodhoundVMG_cav[1].name = "cav";
            BloodhoundVMG_cav[1].seek = 6507532288;
            BloodhoundVMG_cav[1].length = 524288;
            BloodhoundVMG_cav[1].seeklength = 128;
        }
    }
}
