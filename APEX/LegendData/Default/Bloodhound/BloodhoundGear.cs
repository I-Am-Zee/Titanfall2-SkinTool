using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundGear
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundGear_col;
        public ReallyData[] BloodhoundGear_nml;
        public ReallyData[] BloodhoundGear_gls;
        public ReallyData[] BloodhoundGear_spc;
        public ReallyData[] BloodhoundGear_ao;
        public ReallyData[] BloodhoundGear_cav;
        public ReallyData[] BloodhoundGear_ilm;

        public BloodhoundGear()
        {
            //int i = 1;

            BloodhoundGear_col = new ReallyData[3];
            BloodhoundGear_nml = new ReallyData[3];
            BloodhoundGear_gls = new ReallyData[3];
            BloodhoundGear_spc = new ReallyData[3];
            BloodhoundGear_ao = new ReallyData[3];
            BloodhoundGear_cav = new ReallyData[3];
            BloodhoundGear_ilm = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundGear_col[1].name = "col";
            BloodhoundGear_col[1].seek = 3718057984;
            BloodhoundGear_col[1].length = 524288;
            BloodhoundGear_col[1].seeklength = 128;

            BloodhoundGear_col[2].name = "col";
            BloodhoundGear_col[2].seek = 3718582272;
            BloodhoundGear_col[2].length = 2097152;
            BloodhoundGear_col[2].seeklength = 128;

            BloodhoundGear_nml[1].name = "nml";
            BloodhoundGear_nml[1].seek = 3720679424;
            BloodhoundGear_nml[1].length = 1048576;
            BloodhoundGear_nml[1].seeklength = 128;

            BloodhoundGear_nml[2].name = "nml";
            BloodhoundGear_nml[2].seek = 3721728000;
            BloodhoundGear_nml[2].length = 4194304;
            BloodhoundGear_nml[2].seeklength = 128;

            BloodhoundGear_gls[1].name = "gls";
            BloodhoundGear_gls[1].seek = 3725922304;
            BloodhoundGear_gls[1].length = 524288;
            BloodhoundGear_gls[1].seeklength = 128;

            BloodhoundGear_gls[2].name = "gls";
            BloodhoundGear_gls[2].seek = 3726446592;
            BloodhoundGear_gls[2].length = 2097152; 
            BloodhoundGear_gls[2].seeklength = 128;

            BloodhoundGear_spc[1].name = "spc";
            BloodhoundGear_spc[1].seek = 3728543744;
            BloodhoundGear_spc[1].length = 524288;
            BloodhoundGear_spc[1].seeklength = 128;

            BloodhoundGear_spc[2].name = "spc";
            BloodhoundGear_spc[2].seek = 3729068032;
            BloodhoundGear_spc[2].length = 2097152;
            BloodhoundGear_spc[2].seeklength = 128;

            BloodhoundGear_ao[1].name = "ao";
            BloodhoundGear_ao[1].seek = 3733786624;
            BloodhoundGear_ao[1].length = 524288;
            BloodhoundGear_ao[1].seeklength = 128;

            BloodhoundGear_ao[2].name = "ao";
            BloodhoundGear_ao[2].seek = 3734310912;
            BloodhoundGear_ao[2].length = 2097152;
            BloodhoundGear_ao[2].seeklength = 128;

            BloodhoundGear_cav[1].name = "cav";
            BloodhoundGear_cav[1].seek = 3736408064;
            BloodhoundGear_cav[1].length = 524288;
            BloodhoundGear_cav[1].seeklength = 128;

            BloodhoundGear_cav[2].name = "cav";
            BloodhoundGear_cav[2].seek = 3736932352;
            BloodhoundGear_cav[2].length = 2097152;
            BloodhoundGear_cav[2].seeklength = 128;

            BloodhoundGear_ilm[1].name = "ilm";
            BloodhoundGear_ilm[1].seek = 3731165184;
            BloodhoundGear_ilm[1].length = 524288;
            BloodhoundGear_ilm[1].seeklength = 128;

            BloodhoundGear_ilm[2].name = "ilm";
            BloodhoundGear_ilm[2].seek = 3731689472;
            BloodhoundGear_ilm[2].length = 2097152;
            BloodhoundGear_ilm[2].seeklength = 128;
        }
    }
}
