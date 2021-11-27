using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundFur
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundFur_col;
        public ReallyData[] BloodhoundFur_nml;
        public ReallyData[] BloodhoundFur_gls;
        public ReallyData[] BloodhoundFur_spc;

        public BloodhoundFur()
        {
            //int i = 1;

            BloodhoundFur_col = new ReallyData[3];
            BloodhoundFur_nml = new ReallyData[3];
            BloodhoundFur_gls = new ReallyData[3];
            BloodhoundFur_spc = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundFur_col[0].name = "col";
            BloodhoundFur_col[0].seek = 3711504384;
            BloodhoundFur_col[0].length = 131072;
            BloodhoundFur_col[0].seeklength = 128;

            BloodhoundFur_col[1].name = "col";
            BloodhoundFur_col[1].seek = 3711635456;
            BloodhoundFur_col[1].length = 524288;
            BloodhoundFur_col[1].seeklength = 128;

            BloodhoundFur_nml[0].name = "nml";
            BloodhoundFur_nml[0].seek = 3712159744;
            BloodhoundFur_nml[0].length = 262144;
            BloodhoundFur_nml[0].seeklength = 128;

            BloodhoundFur_nml[1].name = "nml";
            BloodhoundFur_nml[1].seek = 3712421888;
            BloodhoundFur_nml[1].length = 1048576;
            BloodhoundFur_nml[1].seeklength = 128;

            BloodhoundFur_gls[0].name = "gls";
            BloodhoundFur_gls[0].seek = 3714125824;
            BloodhoundFur_gls[0].length = 131072;
            BloodhoundFur_gls[0].seeklength = 128;

            BloodhoundFur_gls[1].name = "gls";
            BloodhoundFur_gls[1].seek = 3714256896;
            BloodhoundFur_gls[1].length = 524288; 
            BloodhoundFur_gls[1].seeklength = 128;

            BloodhoundFur_spc[0].name = "spc";
            BloodhoundFur_spc[0].seek = 3713470464;
            BloodhoundFur_spc[0].length = 131072;
            BloodhoundFur_spc[0].seeklength = 128;

            BloodhoundFur_spc[1].name = "spc";
            BloodhoundFur_spc[1].seek = 3713601536;
            BloodhoundFur_spc[1].length = 524288;
            BloodhoundFur_spc[1].seeklength = 128;
        }
    }
}
