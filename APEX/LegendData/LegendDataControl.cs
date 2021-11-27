using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.LegendData
{
    class LegendDataControl
    {
        public string[,] FilePath = new string[1, 4];
        //col，nml，gls，spc，ilm，ao，cav
        //2为2048x2048,1为1024x1024,0为512x512

        private void ConvertData(string name, long seek, int length, int seeklength)
        {
            int i = 0;
            FilePath[0, i] = name;
            i++;
            FilePath[0, i] = Convert.ToString(seek);
            i++;
            FilePath[0, i] = Convert.ToString(length);
            i++;
            FilePath[0, i] = Convert.ToString(seeklength);
        }
        public LegendDataControl(string LegendName, int imagecheck)
        {
            string s = LegendName;
            int toname = s.LastIndexOf("\\") + 1;
            string str = s.Substring(toname, s.Length - toname);
            toname = str.IndexOf("_");
            string temp = str.Substring(toname, str.Length - toname);
            s = str.Replace(temp, "");
            if (str.Contains("Default"))
            {
                switch (s)
                {
                    //.##......##....###....########.########..######...#######..##....##
                    //.##..##..##...##.##......##.......##....##....##.##.....##.###...##
                    //.##..##..##..##...##.....##.......##....##.......##.....##.####..##
                    //.##..##..##.##.....##....##.......##.....######..##.....##.##.##.##
                    //.##..##..##.#########....##.......##..........##.##.....##.##..####
                    //.##..##..##.##.....##....##.......##....##....##.##.....##.##...###
                    //..###..###..##.....##....##.......##.....######...#######..##....##
                    case "WattsonGear":
                        Default.Wattson.WattsonGear wattgear = new Default.Wattson.WattsonGear();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            ConvertData(wattgear.WattsonGear_col[imagecheck].name, wattgear.WattsonGear_col[imagecheck].seek, wattgear.WattsonGear_col[imagecheck].length, wattgear.WattsonGear_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            ConvertData(wattgear.WattsonGear_nml[imagecheck].name, wattgear.WattsonGear_nml[imagecheck].seek, wattgear.WattsonGear_nml[imagecheck].length, wattgear.WattsonGear_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            ConvertData(wattgear.WattsonGear_gls[imagecheck].name, wattgear.WattsonGear_gls[imagecheck].seek, wattgear.WattsonGear_gls[imagecheck].length, wattgear.WattsonGear_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            ConvertData(wattgear.WattsonGear_spc[imagecheck].name, wattgear.WattsonGear_spc[imagecheck].seek, wattgear.WattsonGear_spc[imagecheck].length, wattgear.WattsonGear_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            ConvertData(wattgear.WattsonGear_ao[imagecheck].name, wattgear.WattsonGear_ao[imagecheck].seek, wattgear.WattsonGear_ao[imagecheck].length, wattgear.WattsonGear_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            ConvertData(wattgear.WattsonGear_cav[imagecheck].name, wattgear.WattsonGear_cav[imagecheck].seek, wattgear.WattsonGear_cav[imagecheck].length, wattgear.WattsonGear_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            ConvertData(wattgear.WattsonGear_ilm[imagecheck].name, wattgear.WattsonGear_ilm[imagecheck].seek, wattgear.WattsonGear_ilm[imagecheck].length, wattgear.WattsonGear_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonJacket":
                        Default.Wattson.WattsonJacket wattjacket = new Default.Wattson.WattsonJacket();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            ConvertData(wattjacket.WattsonJacket_col[imagecheck].name, wattjacket.WattsonJacket_col[imagecheck].seek, wattjacket.WattsonJacket_col[imagecheck].length, wattjacket.WattsonJacket_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            ConvertData(wattjacket.WattsonJacket_nml[imagecheck].name, wattjacket.WattsonJacket_nml[imagecheck].seek, wattjacket.WattsonJacket_nml[imagecheck].length, wattjacket.WattsonJacket_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            ConvertData(wattjacket.WattsonJacket_gls[imagecheck].name, wattjacket.WattsonJacket_gls[imagecheck].seek, wattjacket.WattsonJacket_gls[imagecheck].length, wattjacket.WattsonJacket_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            ConvertData(wattjacket.WattsonJacket_spc[imagecheck].name, wattjacket.WattsonJacket_spc[imagecheck].seek, wattjacket.WattsonJacket_spc[imagecheck].length, wattjacket.WattsonJacket_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            ConvertData(wattjacket.WattsonJacket_ao[imagecheck].name, wattjacket.WattsonJacket_ao[imagecheck].seek, wattjacket.WattsonJacket_ao[imagecheck].length, wattjacket.WattsonJacket_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            ConvertData(wattjacket.WattsonJacket_cav[imagecheck].name, wattjacket.WattsonJacket_cav[imagecheck].seek, wattjacket.WattsonJacket_cav[imagecheck].length, wattjacket.WattsonJacket_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonJumpkit":
                        Default.Wattson.WattsonJumpKit wattjumpkit = new Default.Wattson.WattsonJumpKit();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_col[imagecheck].name, wattjumpkit.WattsonJumpKit_col[imagecheck].seek, wattjumpkit.WattsonJumpKit_col[imagecheck].length, wattjumpkit.WattsonJumpKit_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_nml[imagecheck].name, wattjumpkit.WattsonJumpKit_nml[imagecheck].seek, wattjumpkit.WattsonJumpKit_nml[imagecheck].length, wattjumpkit.WattsonJumpKit_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_gls[imagecheck].name, wattjumpkit.WattsonJumpKit_gls[imagecheck].seek, wattjumpkit.WattsonJumpKit_gls[imagecheck].length, wattjumpkit.WattsonJumpKit_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_spc[imagecheck].name, wattjumpkit.WattsonJumpKit_spc[imagecheck].seek, wattjumpkit.WattsonJumpKit_spc[imagecheck].length, wattjumpkit.WattsonJumpKit_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_ao[imagecheck].name, wattjumpkit.WattsonJumpKit_ao[imagecheck].seek, wattjumpkit.WattsonJumpKit_ao[imagecheck].length, wattjumpkit.WattsonJumpKit_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            ConvertData(wattjumpkit.WattsonJumpKit_cav[imagecheck].name, wattjumpkit.WattsonJumpKit_cav[imagecheck].seek, wattjumpkit.WattsonJumpKit_cav[imagecheck].length, wattjumpkit.WattsonJumpKit_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonSuit":
                        Default.Wattson.WattsonSuit wattsuit = new Default.Wattson.WattsonSuit();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            ConvertData(wattsuit.WattsonSuit_col[imagecheck].name, wattsuit.WattsonSuit_col[imagecheck].seek, wattsuit.WattsonSuit_col[imagecheck].length, wattsuit.WattsonSuit_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            ConvertData(wattsuit.WattsonSuit_nml[imagecheck].name, wattsuit.WattsonSuit_nml[imagecheck].seek, wattsuit.WattsonSuit_nml[imagecheck].length, wattsuit.WattsonSuit_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            ConvertData(wattsuit.WattsonSuit_gls[imagecheck].name, wattsuit.WattsonSuit_gls[imagecheck].seek, wattsuit.WattsonSuit_gls[imagecheck].length, wattsuit.WattsonSuit_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            ConvertData(wattsuit.WattsonSuit_spc[imagecheck].name, wattsuit.WattsonSuit_spc[imagecheck].seek, wattsuit.WattsonSuit_spc[imagecheck].length, wattsuit.WattsonSuit_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            ConvertData(wattsuit.WattsonSuit_ao[imagecheck].name, wattsuit.WattsonSuit_ao[imagecheck].seek, wattsuit.WattsonSuit_ao[imagecheck].length, wattsuit.WattsonSuit_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            ConvertData(wattsuit.WattsonSuit_cav[imagecheck].name, wattsuit.WattsonSuit_cav[imagecheck].seek, wattsuit.WattsonSuit_cav[imagecheck].length, wattsuit.WattsonSuit_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonVM":
                        Default.Wattson.WattsonViewModel wattvm = new Default.Wattson.WattsonViewModel();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            ConvertData(wattvm.WattsonViewModel_col[imagecheck].name, wattvm.WattsonViewModel_col[imagecheck].seek, wattvm.WattsonViewModel_col[imagecheck].length, wattvm.WattsonViewModel_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            ConvertData(wattvm.WattsonViewModel_nml[imagecheck].name, wattvm.WattsonViewModel_nml[imagecheck].seek, wattvm.WattsonViewModel_nml[imagecheck].length, wattvm.WattsonViewModel_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            ConvertData(wattvm.WattsonViewModel_gls[imagecheck].name, wattvm.WattsonViewModel_gls[imagecheck].seek, wattvm.WattsonViewModel_gls[imagecheck].length, wattvm.WattsonViewModel_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            ConvertData(wattvm.WattsonViewModel_spc[imagecheck].name, wattvm.WattsonViewModel_spc[imagecheck].seek, wattvm.WattsonViewModel_spc[imagecheck].length, wattvm.WattsonViewModel_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            ConvertData(wattvm.WattsonViewModel_ao[imagecheck].name, wattvm.WattsonViewModel_ao[imagecheck].seek, wattvm.WattsonViewModel_ao[imagecheck].length, wattvm.WattsonViewModel_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            ConvertData(wattvm.WattsonViewModel_cav[imagecheck].name, wattvm.WattsonViewModel_cav[imagecheck].seek, wattvm.WattsonViewModel_cav[imagecheck].length, wattvm.WattsonViewModel_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            ConvertData(wattvm.WattsonViewModel_ilm[imagecheck].name, wattvm.WattsonViewModel_ilm[imagecheck].seek, wattvm.WattsonViewModel_ilm[imagecheck].length, wattvm.WattsonViewModel_ilm[imagecheck].seeklength);
                        }
                        break;
                    //.########..##........#######...#######..########..##.....##..#######..##.....##.##....##.########.
                    //.##.....##.##.......##.....##.##.....##.##.....##.##.....##.##.....##.##.....##.###...##.##.....##
                    //.##.....##.##.......##.....##.##.....##.##.....##.##.....##.##.....##.##.....##.####..##.##.....##
                    //.########..##.......##.....##.##.....##.##.....##.#########.##.....##.##.....##.##.##.##.##.....##
                    //.##.....##.##.......##.....##.##.....##.##.....##.##.....##.##.....##.##.....##.##..####.##.....##
                    //.##.....##.##.......##.....##.##.....##.##.....##.##.....##.##.....##.##.....##.##...###.##.....##
                    //.########..########..#######...#######..########..##.....##..#######...#######..##....##.########.
                    case "BloodhoundBody":
                        Default.Bloodhound.BloodhoundBody bloodbody = new Default.Bloodhound.BloodhoundBody();
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodbody.BloodhoundBody_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodbody.BloodhoundBody_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundFur":
                        Default.Bloodhound.BloodhoundFur bloodfur = new Default.Bloodhound.BloodhoundFur();
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodfur.BloodhoundFur_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodfur.BloodhoundFur_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodfur.BloodhoundFur_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodfur.BloodhoundFur_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodfur.BloodhoundFur_spc[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundGauntlet":
                        Default.Bloodhound.BloodhoundGauntlet bloodgauntlet = new Default.Bloodhound.BloodhoundGauntlet();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundGear":
                        Default.Bloodhound.BloodhoundGear bloodgear = new Default.Bloodhound.BloodhoundGear();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodgear.BloodhoundGear_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodgear.BloodhoundGear_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundHelmet":
                        Default.Bloodhound.BloodhoundHelmet bloodhelmet = new Default.Bloodhound.BloodhoundHelmet();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodhelmet.BloodhoundHelmet_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodhelmet.BloodhoundHelmet_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundVMA":
                        Default.Bloodhound.BloodhoundVMA bloodvma = new Default.Bloodhound.BloodhoundVMA();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvma.BloodhoundVMA_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvma.BloodhoundVMA_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundVMG":
                        Default.Bloodhound.BloodhoundVMG bloodvmg = new Default.Bloodhound.BloodhoundVMG();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = bloodvmg.BloodhoundVMG_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(bloodvmg.BloodhoundVMG_cav[imagecheck].seeklength);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
