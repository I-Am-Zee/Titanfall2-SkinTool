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

        private void SetFilePath(string name, long seek, int length, int seeklength)
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
                            SetFilePath(wattgear.WattsonGear_col[imagecheck].name, wattgear.WattsonGear_col[imagecheck].seek, wattgear.WattsonGear_col[imagecheck].length, wattgear.WattsonGear_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(wattgear.WattsonGear_nml[imagecheck].name, wattgear.WattsonGear_nml[imagecheck].seek, wattgear.WattsonGear_nml[imagecheck].length, wattgear.WattsonGear_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(wattgear.WattsonGear_gls[imagecheck].name, wattgear.WattsonGear_gls[imagecheck].seek, wattgear.WattsonGear_gls[imagecheck].length, wattgear.WattsonGear_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(wattgear.WattsonGear_spc[imagecheck].name, wattgear.WattsonGear_spc[imagecheck].seek, wattgear.WattsonGear_spc[imagecheck].length, wattgear.WattsonGear_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(wattgear.WattsonGear_ao[imagecheck].name, wattgear.WattsonGear_ao[imagecheck].seek, wattgear.WattsonGear_ao[imagecheck].length, wattgear.WattsonGear_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(wattgear.WattsonGear_cav[imagecheck].name, wattgear.WattsonGear_cav[imagecheck].seek, wattgear.WattsonGear_cav[imagecheck].length, wattgear.WattsonGear_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            SetFilePath(wattgear.WattsonGear_ilm[imagecheck].name, wattgear.WattsonGear_ilm[imagecheck].seek, wattgear.WattsonGear_ilm[imagecheck].length, wattgear.WattsonGear_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonJacket":
                        Default.Wattson.WattsonJacket wattjacket = new Default.Wattson.WattsonJacket();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_col[imagecheck].name, wattjacket.WattsonJacket_col[imagecheck].seek, wattjacket.WattsonJacket_col[imagecheck].length, wattjacket.WattsonJacket_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_nml[imagecheck].name, wattjacket.WattsonJacket_nml[imagecheck].seek, wattjacket.WattsonJacket_nml[imagecheck].length, wattjacket.WattsonJacket_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_gls[imagecheck].name, wattjacket.WattsonJacket_gls[imagecheck].seek, wattjacket.WattsonJacket_gls[imagecheck].length, wattjacket.WattsonJacket_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_spc[imagecheck].name, wattjacket.WattsonJacket_spc[imagecheck].seek, wattjacket.WattsonJacket_spc[imagecheck].length, wattjacket.WattsonJacket_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_ao[imagecheck].name, wattjacket.WattsonJacket_ao[imagecheck].seek, wattjacket.WattsonJacket_ao[imagecheck].length, wattjacket.WattsonJacket_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(wattjacket.WattsonJacket_cav[imagecheck].name, wattjacket.WattsonJacket_cav[imagecheck].seek, wattjacket.WattsonJacket_cav[imagecheck].length, wattjacket.WattsonJacket_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonJumpkit":
                        Default.Wattson.WattsonJumpKit wattjumpkit = new Default.Wattson.WattsonJumpKit();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_col[imagecheck].name, wattjumpkit.WattsonJumpKit_col[imagecheck].seek, wattjumpkit.WattsonJumpKit_col[imagecheck].length, wattjumpkit.WattsonJumpKit_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_nml[imagecheck].name, wattjumpkit.WattsonJumpKit_nml[imagecheck].seek, wattjumpkit.WattsonJumpKit_nml[imagecheck].length, wattjumpkit.WattsonJumpKit_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_gls[imagecheck].name, wattjumpkit.WattsonJumpKit_gls[imagecheck].seek, wattjumpkit.WattsonJumpKit_gls[imagecheck].length, wattjumpkit.WattsonJumpKit_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_spc[imagecheck].name, wattjumpkit.WattsonJumpKit_spc[imagecheck].seek, wattjumpkit.WattsonJumpKit_spc[imagecheck].length, wattjumpkit.WattsonJumpKit_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_ao[imagecheck].name, wattjumpkit.WattsonJumpKit_ao[imagecheck].seek, wattjumpkit.WattsonJumpKit_ao[imagecheck].length, wattjumpkit.WattsonJumpKit_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(wattjumpkit.WattsonJumpKit_cav[imagecheck].name, wattjumpkit.WattsonJumpKit_cav[imagecheck].seek, wattjumpkit.WattsonJumpKit_cav[imagecheck].length, wattjumpkit.WattsonJumpKit_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonSuit":
                        Default.Wattson.WattsonSuit wattsuit = new Default.Wattson.WattsonSuit();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_col[imagecheck].name, wattsuit.WattsonSuit_col[imagecheck].seek, wattsuit.WattsonSuit_col[imagecheck].length, wattsuit.WattsonSuit_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_nml[imagecheck].name, wattsuit.WattsonSuit_nml[imagecheck].seek, wattsuit.WattsonSuit_nml[imagecheck].length, wattsuit.WattsonSuit_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_gls[imagecheck].name, wattsuit.WattsonSuit_gls[imagecheck].seek, wattsuit.WattsonSuit_gls[imagecheck].length, wattsuit.WattsonSuit_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_spc[imagecheck].name, wattsuit.WattsonSuit_spc[imagecheck].seek, wattsuit.WattsonSuit_spc[imagecheck].length, wattsuit.WattsonSuit_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_ao[imagecheck].name, wattsuit.WattsonSuit_ao[imagecheck].seek, wattsuit.WattsonSuit_ao[imagecheck].length, wattsuit.WattsonSuit_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(wattsuit.WattsonSuit_cav[imagecheck].name, wattsuit.WattsonSuit_cav[imagecheck].seek, wattsuit.WattsonSuit_cav[imagecheck].length, wattsuit.WattsonSuit_cav[imagecheck].seeklength);
                        }
                        break;
                    case "WattsonVM":
                        Default.Wattson.WattsonViewModel wattvm = new Default.Wattson.WattsonViewModel();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_col[imagecheck].name, wattvm.WattsonViewModel_col[imagecheck].seek, wattvm.WattsonViewModel_col[imagecheck].length, wattvm.WattsonViewModel_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_nml[imagecheck].name, wattvm.WattsonViewModel_nml[imagecheck].seek, wattvm.WattsonViewModel_nml[imagecheck].length, wattvm.WattsonViewModel_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_gls[imagecheck].name, wattvm.WattsonViewModel_gls[imagecheck].seek, wattvm.WattsonViewModel_gls[imagecheck].length, wattvm.WattsonViewModel_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_spc[imagecheck].name, wattvm.WattsonViewModel_spc[imagecheck].seek, wattvm.WattsonViewModel_spc[imagecheck].length, wattvm.WattsonViewModel_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_ao[imagecheck].name, wattvm.WattsonViewModel_ao[imagecheck].seek, wattvm.WattsonViewModel_ao[imagecheck].length, wattvm.WattsonViewModel_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_cav[imagecheck].name, wattvm.WattsonViewModel_cav[imagecheck].seek, wattvm.WattsonViewModel_cav[imagecheck].length, wattvm.WattsonViewModel_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            SetFilePath(wattvm.WattsonViewModel_ilm[imagecheck].name, wattvm.WattsonViewModel_ilm[imagecheck].seek, wattvm.WattsonViewModel_ilm[imagecheck].length, wattvm.WattsonViewModel_ilm[imagecheck].seeklength);
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
                            SetFilePath(bloodbody.BloodhoundBody_col[imagecheck].name, bloodbody.BloodhoundBody_col[imagecheck].seek, bloodbody.BloodhoundBody_col[imagecheck].length, bloodbody.BloodhoundBody_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodbody.BloodhoundBody_nml[imagecheck].name, bloodbody.BloodhoundBody_nml[imagecheck].seek, bloodbody.BloodhoundBody_nml[imagecheck].length, bloodbody.BloodhoundBody_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodbody.BloodhoundBody_gls[imagecheck].name, bloodbody.BloodhoundBody_gls[imagecheck].seek, bloodbody.BloodhoundBody_gls[imagecheck].length, bloodbody.BloodhoundBody_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodbody.BloodhoundBody_spc[imagecheck].name, bloodbody.BloodhoundBody_spc[imagecheck].seek, bloodbody.BloodhoundBody_spc[imagecheck].length, bloodbody.BloodhoundBody_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodbody.BloodhoundBody_ao[imagecheck].name, bloodbody.BloodhoundBody_ao[imagecheck].seek, bloodbody.BloodhoundBody_ao[imagecheck].length, bloodbody.BloodhoundBody_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bloodbody.BloodhoundBody_cav[imagecheck].name, bloodbody.BloodhoundBody_cav[imagecheck].seek, bloodbody.BloodhoundBody_cav[imagecheck].length, bloodbody.BloodhoundBody_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundFur":
                        Default.Bloodhound.BloodhoundFur bloodfur = new Default.Bloodhound.BloodhoundFur();
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodfur.BloodhoundFur_col[imagecheck].name, bloodfur.BloodhoundFur_col[imagecheck].seek, bloodfur.BloodhoundFur_col[imagecheck].length, bloodfur.BloodhoundFur_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodfur.BloodhoundFur_nml[imagecheck].name, bloodfur.BloodhoundFur_nml[imagecheck].seek, bloodfur.BloodhoundFur_nml[imagecheck].length, bloodfur.BloodhoundFur_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodfur.BloodhoundFur_gls[imagecheck].name, bloodfur.BloodhoundFur_gls[imagecheck].seek, bloodfur.BloodhoundFur_gls[imagecheck].length, bloodfur.BloodhoundFur_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodfur.BloodhoundFur_spc[imagecheck].name, bloodfur.BloodhoundFur_spc[imagecheck].seek, bloodfur.BloodhoundFur_spc[imagecheck].length, bloodfur.BloodhoundFur_spc[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundGauntlet":
                        Default.Bloodhound.BloodhoundGauntlet bloodgauntlet = new Default.Bloodhound.BloodhoundGauntlet();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_col[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_col[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_col[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            SetFilePath(bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].name, bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].seek, bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].length, bloodgauntlet.BloodhoundGauntlet_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundGear":
                        Default.Bloodhound.BloodhoundGear bloodgear = new Default.Bloodhound.BloodhoundGear();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_col[imagecheck].name, bloodgear.BloodhoundGear_col[imagecheck].seek, bloodgear.BloodhoundGear_col[imagecheck].length, bloodgear.BloodhoundGear_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_nml[imagecheck].name, bloodgear.BloodhoundGear_nml[imagecheck].seek, bloodgear.BloodhoundGear_nml[imagecheck].length, bloodgear.BloodhoundGear_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_gls[imagecheck].name, bloodgear.BloodhoundGear_gls[imagecheck].seek, bloodgear.BloodhoundGear_gls[imagecheck].length, bloodgear.BloodhoundGear_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_spc[imagecheck].name, bloodgear.BloodhoundGear_spc[imagecheck].seek, bloodgear.BloodhoundGear_spc[imagecheck].length, bloodgear.BloodhoundGear_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_ao[imagecheck].name, bloodgear.BloodhoundGear_ao[imagecheck].seek, bloodgear.BloodhoundGear_ao[imagecheck].length, bloodgear.BloodhoundGear_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_cav[imagecheck].name, bloodgear.BloodhoundGear_cav[imagecheck].seek, bloodgear.BloodhoundGear_cav[imagecheck].length, bloodgear.BloodhoundGear_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            SetFilePath(bloodgear.BloodhoundGear_ilm[imagecheck].name, bloodgear.BloodhoundGear_ilm[imagecheck].seek, bloodgear.BloodhoundGear_ilm[imagecheck].length, bloodgear.BloodhoundGear_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundHelmet":
                        Default.Bloodhound.BloodhoundHelmet bloodhelmet = new Default.Bloodhound.BloodhoundHelmet();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_col[imagecheck].name, bloodhelmet.BloodhoundHelmet_col[imagecheck].seek, bloodhelmet.BloodhoundHelmet_col[imagecheck].length, bloodhelmet.BloodhoundHelmet_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_nml[imagecheck].name, bloodhelmet.BloodhoundHelmet_nml[imagecheck].seek, bloodhelmet.BloodhoundHelmet_nml[imagecheck].length, bloodhelmet.BloodhoundHelmet_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_gls[imagecheck].name, bloodhelmet.BloodhoundHelmet_gls[imagecheck].seek, bloodhelmet.BloodhoundHelmet_gls[imagecheck].length, bloodhelmet.BloodhoundHelmet_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_spc[imagecheck].name, bloodhelmet.BloodhoundHelmet_spc[imagecheck].seek, bloodhelmet.BloodhoundHelmet_spc[imagecheck].length, bloodhelmet.BloodhoundHelmet_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_ao[imagecheck].name, bloodhelmet.BloodhoundHelmet_ao[imagecheck].seek, bloodhelmet.BloodhoundHelmet_ao[imagecheck].length, bloodhelmet.BloodhoundHelmet_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bloodhelmet.BloodhoundHelmet_cav[imagecheck].name, bloodhelmet.BloodhoundHelmet_cav[imagecheck].seek, bloodhelmet.BloodhoundHelmet_cav[imagecheck].length, bloodhelmet.BloodhoundHelmet_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundVMA":
                        Default.Bloodhound.BloodhoundVMA bloodvma = new Default.Bloodhound.BloodhoundVMA();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_col[imagecheck].name, bloodvma.BloodhoundVMA_col[imagecheck].seek, bloodvma.BloodhoundVMA_col[imagecheck].length, bloodvma.BloodhoundVMA_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_nml[imagecheck].name, bloodvma.BloodhoundVMA_nml[imagecheck].seek, bloodvma.BloodhoundVMA_nml[imagecheck].length, bloodvma.BloodhoundVMA_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_gls[imagecheck].name, bloodvma.BloodhoundVMA_gls[imagecheck].seek, bloodvma.BloodhoundVMA_gls[imagecheck].length, bloodvma.BloodhoundVMA_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_spc[imagecheck].name, bloodvma.BloodhoundVMA_spc[imagecheck].seek, bloodvma.BloodhoundVMA_spc[imagecheck].length, bloodvma.BloodhoundVMA_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_ao[imagecheck].name, bloodvma.BloodhoundVMA_ao[imagecheck].seek, bloodvma.BloodhoundVMA_ao[imagecheck].length, bloodvma.BloodhoundVMA_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bloodvma.BloodhoundVMA_cav[imagecheck].name, bloodvma.BloodhoundVMA_cav[imagecheck].seek, bloodvma.BloodhoundVMA_cav[imagecheck].length, bloodvma.BloodhoundVMA_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BloodhoundVMG":
                        Default.Bloodhound.BloodhoundVMG bloodvmg = new Default.Bloodhound.BloodhoundVMG();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (str.Contains("col"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_col[imagecheck].name, bloodvmg.BloodhoundVMG_col[imagecheck].seek, bloodvmg.BloodhoundVMG_col[imagecheck].length, bloodvmg.BloodhoundVMG_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_nml[imagecheck].name, bloodvmg.BloodhoundVMG_nml[imagecheck].seek, bloodvmg.BloodhoundVMG_nml[imagecheck].length, bloodvmg.BloodhoundVMG_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_gls[imagecheck].name, bloodvmg.BloodhoundVMG_gls[imagecheck].seek, bloodvmg.BloodhoundVMG_gls[imagecheck].length, bloodvmg.BloodhoundVMG_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_spc[imagecheck].name, bloodvmg.BloodhoundVMG_spc[imagecheck].seek, bloodvmg.BloodhoundVMG_spc[imagecheck].length, bloodvmg.BloodhoundVMG_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_ao[imagecheck].name, bloodvmg.BloodhoundVMG_ao[imagecheck].seek, bloodvmg.BloodhoundVMG_ao[imagecheck].length, bloodvmg.BloodhoundVMG_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bloodvmg.BloodhoundVMG_cav[imagecheck].name, bloodvmg.BloodhoundVMG_cav[imagecheck].seek, bloodvmg.BloodhoundVMG_cav[imagecheck].length, bloodvmg.BloodhoundVMG_cav[imagecheck].seeklength);
                        }
                        break;
                    //.########.....###....##....##..######......###....##........#######..########..########
                    //.##.....##...##.##...###...##.##....##....##.##...##.......##.....##.##.....##.##......
                    //.##.....##..##...##..####..##.##.........##...##..##.......##.....##.##.....##.##......
                    //.########..##.....##.##.##.##.##...####.##.....##.##.......##.....##.########..######..
                    //.##.....##.#########.##..####.##....##..#########.##.......##.....##.##...##...##......
                    //.##.....##.##.....##.##...###.##....##..##.....##.##.......##.....##.##....##..##......
                    //.########..##.....##.##....##..######...##.....##.########..#######..##.....##.########
                    case "BangaloreBody":
                        Default.Bangalore.BangaloreBody bangbody = new Default.Bangalore.BangaloreBody();
                        if (str.Contains("col"))
                        {
                            SetFilePath(bangbody.BangaloreBody_col[imagecheck].name, bangbody.BangaloreBody_col[imagecheck].seek, bangbody.BangaloreBody_col[imagecheck].length, bangbody.BangaloreBody_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bangbody.BangaloreBody_nml[imagecheck].name, bangbody.BangaloreBody_nml[imagecheck].seek, bangbody.BangaloreBody_nml[imagecheck].length, bangbody.BangaloreBody_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bangbody.BangaloreBody_gls[imagecheck].name, bangbody.BangaloreBody_gls[imagecheck].seek, bangbody.BangaloreBody_gls[imagecheck].length, bangbody.BangaloreBody_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bangbody.BangaloreBody_spc[imagecheck].name, bangbody.BangaloreBody_spc[imagecheck].seek, bangbody.BangaloreBody_spc[imagecheck].length, bangbody.BangaloreBody_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bangbody.BangaloreBody_ao[imagecheck].name, bangbody.BangaloreBody_ao[imagecheck].seek, bangbody.BangaloreBody_ao[imagecheck].length, bangbody.BangaloreBody_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bangbody.BangaloreBody_cav[imagecheck].name, bangbody.BangaloreBody_cav[imagecheck].seek, bangbody.BangaloreBody_cav[imagecheck].length, bangbody.BangaloreBody_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BangaloreRocket":
                        Default.Bangalore.BangaloreRockets bangrocket = new Default.Bangalore.BangaloreRockets();
                        if (str.Contains("col"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_col[imagecheck].name, bangrocket.BangaloreRockets_col[imagecheck].seek, bangrocket.BangaloreRockets_col[imagecheck].length, bangrocket.BangaloreRockets_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_nml[imagecheck].name, bangrocket.BangaloreRockets_nml[imagecheck].seek, bangrocket.BangaloreRockets_nml[imagecheck].length, bangrocket.BangaloreRockets_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_gls[imagecheck].name, bangrocket.BangaloreRockets_gls[imagecheck].seek, bangrocket.BangaloreRockets_gls[imagecheck].length, bangrocket.BangaloreRockets_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_spc[imagecheck].name, bangrocket.BangaloreRockets_spc[imagecheck].seek, bangrocket.BangaloreRockets_spc[imagecheck].length, bangrocket.BangaloreRockets_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_ao[imagecheck].name, bangrocket.BangaloreRockets_ao[imagecheck].seek, bangrocket.BangaloreRockets_ao[imagecheck].length, bangrocket.BangaloreRockets_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_cav[imagecheck].name, bangrocket.BangaloreRockets_cav[imagecheck].seek, bangrocket.BangaloreRockets_cav[imagecheck].length, bangrocket.BangaloreRockets_cav[imagecheck].seeklength);
                        }
                        if (str.Contains("ilm"))
                        {
                            SetFilePath(bangrocket.BangaloreRockets_ilm[imagecheck].name, bangrocket.BangaloreRockets_ilm[imagecheck].seek, bangrocket.BangaloreRockets_ilm[imagecheck].length, bangrocket.BangaloreRockets_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "BangaloreGauntlet":
                        Default.Bangalore.BangaloreGauntlet banggauntlet = new Default.Bangalore.BangaloreGauntlet();
                        if (str.Contains("col"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_col[imagecheck].name, banggauntlet.BangaloreGauntlet_col[imagecheck].seek, banggauntlet.BangaloreGauntlet_col[imagecheck].length, banggauntlet.BangaloreGauntlet_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_nml[imagecheck].name, banggauntlet.BangaloreGauntlet_nml[imagecheck].seek, banggauntlet.BangaloreGauntlet_nml[imagecheck].length, banggauntlet.BangaloreGauntlet_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_gls[imagecheck].name, banggauntlet.BangaloreGauntlet_gls[imagecheck].seek, banggauntlet.BangaloreGauntlet_gls[imagecheck].length, banggauntlet.BangaloreGauntlet_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_spc[imagecheck].name, banggauntlet.BangaloreGauntlet_spc[imagecheck].seek, banggauntlet.BangaloreGauntlet_spc[imagecheck].length, banggauntlet.BangaloreGauntlet_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_ao[imagecheck].name, banggauntlet.BangaloreGauntlet_ao[imagecheck].seek, banggauntlet.BangaloreGauntlet_ao[imagecheck].length, banggauntlet.BangaloreGauntlet_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(banggauntlet.BangaloreGauntlet_cav[imagecheck].name, banggauntlet.BangaloreGauntlet_cav[imagecheck].seek, banggauntlet.BangaloreGauntlet_cav[imagecheck].length, banggauntlet.BangaloreGauntlet_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BangaloreJetpack":
                        Default.Bangalore.BangaloreJetpack bangjetpack = new Default.Bangalore.BangaloreJetpack();
                        if (str.Contains("col"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_col[imagecheck].name, bangjetpack.BangaloreJetpack_col[imagecheck].seek, bangjetpack.BangaloreJetpack_col[imagecheck].length, bangjetpack.BangaloreJetpack_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_nml[imagecheck].name, bangjetpack.BangaloreJetpack_nml[imagecheck].seek, bangjetpack.BangaloreJetpack_nml[imagecheck].length, bangjetpack.BangaloreJetpack_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_gls[imagecheck].name, bangjetpack.BangaloreJetpack_gls[imagecheck].seek, bangjetpack.BangaloreJetpack_gls[imagecheck].length, bangjetpack.BangaloreJetpack_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_spc[imagecheck].name, bangjetpack.BangaloreJetpack_spc[imagecheck].seek, bangjetpack.BangaloreJetpack_spc[imagecheck].length, bangjetpack.BangaloreJetpack_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_ao[imagecheck].name, bangjetpack.BangaloreJetpack_ao[imagecheck].seek, bangjetpack.BangaloreJetpack_ao[imagecheck].length, bangjetpack.BangaloreJetpack_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bangjetpack.BangaloreJetpack_cav[imagecheck].name, bangjetpack.BangaloreJetpack_cav[imagecheck].seek, bangjetpack.BangaloreJetpack_cav[imagecheck].length, bangjetpack.BangaloreJetpack_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BangaloreLauncher":
                        Default.Bangalore.BangaloreLauncher banglauncher = new Default.Bangalore.BangaloreLauncher();
                        if (str.Contains("col"))
                        {
                            SetFilePath(banglauncher.BangaloreLauncher_col[imagecheck].name, banglauncher.BangaloreLauncher_col[imagecheck].seek, banglauncher.BangaloreLauncher_col[imagecheck].length, banglauncher.BangaloreLauncher_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(banglauncher.BangaloreLauncher_nml[imagecheck].name, banglauncher.BangaloreLauncher_nml[imagecheck].seek, banglauncher.BangaloreLauncher_nml[imagecheck].length, banglauncher.BangaloreLauncher_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(banglauncher.BangaloreLauncher_spc[imagecheck].name, banglauncher.BangaloreLauncher_spc[imagecheck].seek, banglauncher.BangaloreLauncher_spc[imagecheck].length, banglauncher.BangaloreLauncher_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(banglauncher.BangaloreLauncher_ao[imagecheck].name, banglauncher.BangaloreLauncher_ao[imagecheck].seek, banglauncher.BangaloreLauncher_ao[imagecheck].length, banglauncher.BangaloreLauncher_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(banglauncher.BangaloreLauncher_cav[imagecheck].name, banglauncher.BangaloreLauncher_cav[imagecheck].seek, banglauncher.BangaloreLauncher_cav[imagecheck].length, banglauncher.BangaloreLauncher_cav[imagecheck].seeklength);
                        }
                        break;
                    case "BangaloreVM":
                        Default.Bangalore.BangaloreVM bangvm = new Default.Bangalore.BangaloreVM();
                        if (str.Contains("col"))
                        {
                            SetFilePath(bangvm.BangaloreVM_col[imagecheck].name, bangvm.BangaloreVM_col[imagecheck].seek, bangvm.BangaloreVM_col[imagecheck].length, bangvm.BangaloreVM_col[imagecheck].seeklength);
                        }
                        if (str.Contains("nml"))
                        {
                            SetFilePath(bangvm.BangaloreVM_nml[imagecheck].name, bangvm.BangaloreVM_nml[imagecheck].seek, bangvm.BangaloreVM_nml[imagecheck].length, bangvm.BangaloreVM_nml[imagecheck].seeklength);
                        }
                        if (str.Contains("gls"))
                        {
                            SetFilePath(bangvm.BangaloreVM_gls[imagecheck].name, bangvm.BangaloreVM_gls[imagecheck].seek, bangvm.BangaloreVM_gls[imagecheck].length, bangvm.BangaloreVM_gls[imagecheck].seeklength);
                        }
                        if (str.Contains("spc"))
                        {
                            SetFilePath(bangvm.BangaloreVM_spc[imagecheck].name, bangvm.BangaloreVM_spc[imagecheck].seek, bangvm.BangaloreVM_spc[imagecheck].length, bangvm.BangaloreVM_spc[imagecheck].seeklength);
                        }
                        if (str.Contains("ao"))
                        {
                            SetFilePath(bangvm.BangaloreVM_ao[imagecheck].name, bangvm.BangaloreVM_ao[imagecheck].seek, bangvm.BangaloreVM_ao[imagecheck].length, bangvm.BangaloreVM_ao[imagecheck].seeklength);
                        }
                        if (str.Contains("cav"))
                        {
                            SetFilePath(bangvm.BangaloreVM_cav[imagecheck].name, bangvm.BangaloreVM_cav[imagecheck].seek, bangvm.BangaloreVM_cav[imagecheck].length, bangvm.BangaloreVM_cav[imagecheck].seeklength);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
