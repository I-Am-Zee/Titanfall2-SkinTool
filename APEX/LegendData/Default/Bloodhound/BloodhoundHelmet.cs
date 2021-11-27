using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundHelmet
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundHelmet_col;
        public ReallyData[] BloodhoundHelmet_nml;
        public ReallyData[] BloodhoundHelmet_gls;
        public ReallyData[] BloodhoundHelmet_spc;
        public ReallyData[] BloodhoundHelmet_ao;
        public ReallyData[] BloodhoundHelmet_cav;

        public BloodhoundHelmet()
        {
            //int i = 1;

            BloodhoundHelmet_col = new ReallyData[3];
            BloodhoundHelmet_nml = new ReallyData[3];
            BloodhoundHelmet_gls = new ReallyData[3];
            BloodhoundHelmet_spc = new ReallyData[3];
            BloodhoundHelmet_ao = new ReallyData[3];
            BloodhoundHelmet_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //TODO LATER FUK

            BloodhoundHelmet_col[1].name = "col";
            BloodhoundHelmet_col[1].seek = 3630239744;
            BloodhoundHelmet_col[1].length = 262144;
            BloodhoundHelmet_col[1].seeklength = 128;

            BloodhoundHelmet_col[2].name = "col";
            BloodhoundHelmet_col[2].seek = 3630501888;
            BloodhoundHelmet_col[2].length = 1048576;
            BloodhoundHelmet_col[2].seeklength = 128;

            BloodhoundHelmet_nml[1].name = "nml";
            BloodhoundHelmet_nml[1].seek = 3631550464;
            BloodhoundHelmet_nml[1].length = 524288;
            BloodhoundHelmet_nml[1].seeklength = 128;

            BloodhoundHelmet_nml[2].name = "nml";
            BloodhoundHelmet_nml[2].seek = 3632074752;
            BloodhoundHelmet_nml[2].length = 2097152;
            BloodhoundHelmet_nml[2].seeklength = 128;

            BloodhoundHelmet_gls[1].name = "gls";
            BloodhoundHelmet_gls[1].seek = 3634171904;
            BloodhoundHelmet_gls[1].length = 262144;
            BloodhoundHelmet_gls[1].seeklength = 128;

            BloodhoundHelmet_gls[2].name = "gls";
            BloodhoundHelmet_gls[2].seek = 3634434048;
            BloodhoundHelmet_gls[2].length = 1048576; 
            BloodhoundHelmet_gls[2].seeklength = 128;

            BloodhoundHelmet_spc[1].name = "spc";
            BloodhoundHelmet_spc[1].seek = 3635482624;
            BloodhoundHelmet_spc[1].length = 262144;
            BloodhoundHelmet_spc[1].seeklength = 128;

            BloodhoundHelmet_spc[2].name = "spc";
            BloodhoundHelmet_spc[2].seek = 3635744768;
            BloodhoundHelmet_spc[2].length = 1048576;
            BloodhoundHelmet_spc[2].seeklength = 128;

            BloodhoundHelmet_ao[1].name = "ao";
            BloodhoundHelmet_ao[1].seek = 3636793344;
            BloodhoundHelmet_ao[1].length = 262144;
            BloodhoundHelmet_ao[1].seeklength = 128;

            BloodhoundHelmet_ao[2].name = "ao";
            BloodhoundHelmet_ao[2].seek = 3637055488;
            BloodhoundHelmet_ao[2].length = 1048576;
            BloodhoundHelmet_ao[2].seeklength = 128;

            BloodhoundHelmet_cav[1].name = "cav";
            BloodhoundHelmet_cav[1].seek = 3638104064;
            BloodhoundHelmet_cav[1].length = 262144;
            BloodhoundHelmet_cav[1].seeklength = 128;

            BloodhoundHelmet_cav[2].name = "cav";
            BloodhoundHelmet_cav[2].seek = 3638366208;
            BloodhoundHelmet_cav[2].length = 1048576;
            BloodhoundHelmet_cav[2].seeklength = 128;
        }
    }
}
