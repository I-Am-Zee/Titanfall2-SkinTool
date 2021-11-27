using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData.Default.Bloodhound
{
    class BloodhoundGauntlet
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] BloodhoundGauntlet_col;
        public ReallyData[] BloodhoundGauntlet_nml;
        public ReallyData[] BloodhoundGauntlet_gls;
        public ReallyData[] BloodhoundGauntlet_spc;
        public ReallyData[] BloodhoundGauntlet_ao;
        public ReallyData[] BloodhoundGauntlet_ilm;

        public BloodhoundGauntlet()
        {
            //int i = 1;

            BloodhoundGauntlet_col = new ReallyData[3];
            BloodhoundGauntlet_nml = new ReallyData[3];
            BloodhoundGauntlet_gls = new ReallyData[3];
            BloodhoundGauntlet_spc = new ReallyData[3];
            BloodhoundGauntlet_ao = new ReallyData[3];
            BloodhoundGauntlet_ilm = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            BloodhoundGauntlet_col[0].name = "col";
            BloodhoundGauntlet_col[0].seek = 3880718336;
            BloodhoundGauntlet_col[0].length = 131072;
            BloodhoundGauntlet_col[0].seeklength = 128;

            BloodhoundGauntlet_col[1].name = "col";
            BloodhoundGauntlet_col[1].seek = 3880849408;
            BloodhoundGauntlet_col[1].length = 524288;
            BloodhoundGauntlet_col[1].seeklength = 128;

            BloodhoundGauntlet_nml[0].name = "nml";
            BloodhoundGauntlet_nml[0].seek = 3881373696;
            BloodhoundGauntlet_nml[0].length = 262144;
            BloodhoundGauntlet_nml[0].seeklength = 128;

            BloodhoundGauntlet_nml[1].name = "nml";
            BloodhoundGauntlet_nml[1].seek = 3881635840;
            BloodhoundGauntlet_nml[1].length = 1048576;
            BloodhoundGauntlet_nml[1].seeklength = 128;

            BloodhoundGauntlet_gls[0].name = "gls";
            BloodhoundGauntlet_gls[0].seek = 3883339776;
            BloodhoundGauntlet_gls[0].length = 131072;
            BloodhoundGauntlet_gls[0].seeklength = 128;

            BloodhoundGauntlet_gls[1].name = "gls";
            BloodhoundGauntlet_gls[1].seek = 3883470848;
            BloodhoundGauntlet_gls[1].length = 524288; 
            BloodhoundGauntlet_gls[1].seeklength = 128;

            BloodhoundGauntlet_spc[0].name = "spc";
            BloodhoundGauntlet_spc[0].seek = 3882684416;
            BloodhoundGauntlet_spc[0].length = 131072;
            BloodhoundGauntlet_spc[0].seeklength = 128;

            BloodhoundGauntlet_spc[1].name = "spc";
            BloodhoundGauntlet_spc[1].seek = 3882815488;
            BloodhoundGauntlet_spc[1].length = 524288;
            BloodhoundGauntlet_spc[1].seeklength = 128;

            BloodhoundGauntlet_ao[0].name = "ao";
            BloodhoundGauntlet_ao[0].seek = 3884650496;
            BloodhoundGauntlet_ao[0].length = 131072;
            BloodhoundGauntlet_ao[0].seeklength = 128;

            BloodhoundGauntlet_ao[1].name = "ao";
            BloodhoundGauntlet_ao[1].seek = 3884781568;
            BloodhoundGauntlet_ao[1].length = 524288;
            BloodhoundGauntlet_ao[1].seeklength = 128;

            BloodhoundGauntlet_ilm[0].name = "ilm";
            BloodhoundGauntlet_ilm[0].seek = 3883995136;
            BloodhoundGauntlet_ilm[0].length = 131072;
            BloodhoundGauntlet_ilm[0].seeklength = 128;

            BloodhoundGauntlet_ilm[1].name = "ilm";
            BloodhoundGauntlet_ilm[1].seek = 3884126208;
            BloodhoundGauntlet_ilm[1].length = 524288;
            BloodhoundGauntlet_ilm[1].seeklength = 128;
        }
    }
}
