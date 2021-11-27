using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundBody
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundBody_col;
        public ReallyData[] BloodhoundBody_nml;
        public ReallyData[] BloodhoundBody_gls;
        public ReallyData[] BloodhoundBody_spc;
        public ReallyData[] BloodhoundBody_ao;
        public ReallyData[] BloodhoundBody_cav;

        public BloodhoundBody()
        {
            //int i = 1;

            BloodhoundBody_col = new ReallyData[3];
            BloodhoundBody_nml = new ReallyData[3];
            BloodhoundBody_gls = new ReallyData[3];
            BloodhoundBody_spc = new ReallyData[3];
            BloodhoundBody_ao = new ReallyData[3];
            BloodhoundBody_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundBody_col[1].name = "col";
            BloodhoundBody_col[1].seek = 3458863104;
            BloodhoundBody_col[1].length = 524288;
            BloodhoundBody_col[1].seeklength = 128;

            BloodhoundBody_col[2].name = "col";
            BloodhoundBody_col[2].seek = 3459387392;
            BloodhoundBody_col[2].length = 2097152;
            BloodhoundBody_col[2].seeklength = 128;

            BloodhoundBody_nml[1].name = "nml";
            BloodhoundBody_nml[1].seek = 3461484544;
            BloodhoundBody_nml[1].length = 1048576;
            BloodhoundBody_nml[1].seeklength = 128;

            BloodhoundBody_nml[2].name = "nml";
            BloodhoundBody_nml[2].seek = 3462533120;
            BloodhoundBody_nml[2].length = 4194304;
            BloodhoundBody_nml[2].seeklength = 128;

            BloodhoundBody_gls[1].name = "gls";
            BloodhoundBody_gls[1].seek = 3469348864;
            BloodhoundBody_gls[1].length = 524288;
            BloodhoundBody_gls[1].seeklength = 128;

            BloodhoundBody_gls[2].name = "gls";
            BloodhoundBody_gls[2].seek = 3469873152;
            BloodhoundBody_gls[2].length = 2097152; 
            BloodhoundBody_gls[2].seeklength = 128;

            BloodhoundBody_spc[1].name = "spc";
            BloodhoundBody_spc[1].seek = 3466727424;
            BloodhoundBody_spc[1].length = 524288;
            BloodhoundBody_spc[1].seeklength = 128;

            BloodhoundBody_spc[2].name = "spc";
            BloodhoundBody_spc[2].seek = 3467251712;
            BloodhoundBody_spc[2].length = 2097152;
            BloodhoundBody_spc[2].seeklength = 128;

            BloodhoundBody_ao[1].name = "ao";
            BloodhoundBody_ao[1].seek = 3474591744;
            BloodhoundBody_ao[1].length = 524288;
            BloodhoundBody_ao[1].seeklength = 128;

            BloodhoundBody_ao[2].name = "ao";
            BloodhoundBody_ao[2].seek = 3475116032;
            BloodhoundBody_ao[2].length = 2097152;
            BloodhoundBody_ao[2].seeklength = 128;

            BloodhoundBody_cav[1].name = "cav";
            BloodhoundBody_cav[1].seek = 3471970304;
            BloodhoundBody_cav[1].length = 524288;
            BloodhoundBody_cav[1].seeklength = 128;

            BloodhoundBody_cav[2].name = "cav";
            BloodhoundBody_cav[2].seek = 3472494592;
            BloodhoundBody_cav[2].length = 2097152;
            BloodhoundBody_cav[2].seeklength = 128;
        }
    }
}
