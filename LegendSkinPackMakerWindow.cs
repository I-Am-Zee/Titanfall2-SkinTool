using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using BCnEncoder.Encoder;
using ImageMagick;
using ImageMagick.Formats;

namespace Titanfall2_SkinTool
{
    public partial class LegendSkinPackMakerWindow : Form
    {
        string SelectedGame = null;
        string SelectedWeapon = null;
        ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public LegendSkinPackMakerWindow(String SelectedGame)
        {
            InitializeComponent();
            this.SelectedGame = SelectedGame;
            LanguageSet();
            LoadWeaponName();
            DisableAllTextures();

            tabControl1.TabPages.Remove(BloodhoundtabPage);
            tabControl1.TabPages.Remove(GibraltartabPage);
            tabControl1.TabPages.Remove(LifelinetabPage);
            tabControl1.TabPages.Remove(PathfindertabPage);
            tabControl1.TabPages.Remove(WraithtabPage);
            tabControl1.TabPages.Remove(BangaloretabPage);
            tabControl1.TabPages.Remove(CaustictabPage);
            tabControl1.TabPages.Remove(MiragetabPage);
            tabControl1.TabPages.Remove(OctanetabPage);
            tabControl1.TabPages.Remove(WattsontabPage);
            tabControl1.TabPages.Remove(CryptotabPage);
        }

        private void openSkinPackPathSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = skinPackPathDialogue.ShowDialog();
            skinPackPathTextBox.Text = skinPackPathDialogue.SelectedPath;
        }

        private void texturePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void texturePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            PictureBoxDragEvent(box, e);
        }

        private void PictureBoxDragEvent(PictureBox box, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) Console.WriteLine(file);

            string filepath = files[0];
            LoadImageIntoPictureBox(box, filepath);
        }

        private void LoadImageIntoPictureBox(PictureBox box, string filepath)
        {
            if (filepath.Length > 0)
            {
                try
                {
                    box.Image = Image.FromFile(filepath);
                }
                catch (OutOfMemoryException ex)
                {

                    MessageBox.Show(rm.GetString("ImageReadOutOfMem") + "\r\r" + ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LegendTexturePrep(string prefix, PictureBox col, PictureBox spc, PictureBox gls, PictureBox nml, PictureBox ao, PictureBox cav, ZipArchive zipArchive, ProgressForm progressForm, bool big)
        {
            if (col.Enabled && col.Image != null)
            {
                MagickImage colorImage = new MagickImage(ImageToByteArray(col.Image));
                colorImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(SelectedWeapon + prefix + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Rgba);
            }

            progressForm?.AdvanceEntry();

            if (spc.Enabled && spc.Image != null)
            {
                MagickImage specularImage = new MagickImage(ImageToByteArray(spc.Image));
                specularImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(SelectedWeapon + prefix + "_Default_spc.dds", specularImage, zipArchive);
            }

            progressForm?.AdvanceEntry();

            if (gls.Enabled && gls.Image != null)
            {
                MagickImage glossinessImage = new MagickImage(ImageToByteArray(gls.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry();

            if (nml.Enabled && nml.Image != null)
            {
                MagickImage normalImage = new MagickImage(ImageToByteArray(nml.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
            }

            progressForm?.AdvanceEntry();

            if (ao.Enabled && ao.Image != null)
            {
                MagickImage aoImage = new MagickImage(ImageToByteArray(ao.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry();

            if (cav.Enabled && cav.Image != null)
            {
                MagickImage cavImage = new MagickImage(ImageToByteArray(cav.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_cav.dds", cavImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry(); 
        }

        private void LegendTexturePrepILM(string prefix, PictureBox col, PictureBox spc, PictureBox gls, PictureBox nml, PictureBox ao, PictureBox cav, PictureBox ilm, ZipArchive zipArchive, ProgressForm progressForm, bool big)
        {
            if (col.Enabled && col.Image != null)
            {
                MagickImage colorImage = new MagickImage(ImageToByteArray(col.Image));
                colorImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(SelectedWeapon + prefix + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Rgba);
            }

            progressForm?.AdvanceEntry();

            if (spc.Enabled && spc.Image != null)
            {
                MagickImage specularImage = new MagickImage(ImageToByteArray(spc.Image));
                specularImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(SelectedWeapon + prefix + "_Default_spc.dds", specularImage, zipArchive);
            }

            progressForm?.AdvanceEntry();

            if (gls.Enabled && gls.Image != null)
            {
                MagickImage glossinessImage = new MagickImage(ImageToByteArray(gls.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry();

            if (nml.Enabled && nml.Image != null)
            {
                MagickImage normalImage = new MagickImage(ImageToByteArray(nml.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
            }

            progressForm?.AdvanceEntry();

            if (ao.Enabled && ao.Image != null)
            {
                MagickImage aoImage = new MagickImage(ImageToByteArray(ao.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry();

            if (cav.Enabled && cav.Image != null)
            {
                MagickImage cavImage = new MagickImage(ImageToByteArray(cav.Image));
                SaveTexture(SelectedWeapon + prefix + "_Default_cav.dds", cavImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            progressForm?.AdvanceEntry();

            if (ilm.Enabled && ilm.Image != null)
            {
                MagickImage illuminationImage = new MagickImage(ImageToByteArray(ilm.Image));
                illuminationImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(SelectedWeapon + prefix + "_Default_ilm.dds", illuminationImage, zipArchive);
            }

            progressForm?.AdvanceEntry();
        }

        private void generateSkinPackButton_Click(object sender, EventArgs e)
        {
            ProgressForm progressForm = null;

            if (skinNameTextBox.Text == null)
            {
                MessageBox.Show(rm.GetString("SkinNameNotSet"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedWeapon == null || assetTypeComboBox.Text == null || assetTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show(rm.GetString("WeaponNotSet"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (skinPackPathDialogue.SelectedPath.Length == 0 && skinPackPathTextBox.Text == null)
            {
                MessageBox.Show(rm.GetString("SkinPackPathNotSelected"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(GetSkinPackRootPath()))
            {
                try
                {
                    File.Delete(GetSkinPackRootPath());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(rm.GetString("CannotDeleteArchive") + ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (SelectedWeapon == "Bloodhound")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(44); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("Body", bloodBodycol, bloodBodyspec, bloodBodygloss, bloodBodynorm, bloodBodyao, bloodBodycav, zipArchive, progressForm, false);

                    //Fur
                    LegendTexturePrep("Fur", bloodFurcol, bloodFurspec, bloodFurgloss, bloodFurnorm, bloodFurao, bloodFurcav, zipArchive, progressForm, false);

                    //Gauntlet
                    LegendTexturePrepILM("Gauntlet", bloodGauntletcol, bloodGauntletspec, bloodGauntletgloss, bloodGauntletnorm, bloodGauntletao, bloodGauntletcav, bloodGauntletilm, zipArchive, progressForm, false);

                    //Gear
                    LegendTexturePrepILM("Gear", bloodGearcol, bloodGearspec, bloodGeargloss, bloodGearnorm, bloodGearnorm, bloodGearcav, bloodGearilm, zipArchive, progressForm, false);

                    //Helmet
                    LegendTexturePrep("Helmet", bloodHelmetcol, bloodHelmetspec, bloodHelmetgloss, bloodHelmetnorm, bloodHelmetao, bloodHelmetcav, zipArchive, progressForm, false);

                    //ViewModel Arms
                    LegendTexturePrep("VMA", bloodVMAcol, bloodVMAspec, bloodVMAgloss, bloodVMAnorm, bloodVMAao, bloodVMAcav, zipArchive, progressForm, false);

                    //ViewModel Gear
                    LegendTexturePrep("VMG", bloodVMGcol, bloodVMGspec, bloodVMGgloss, bloodVMGnorm, bloodVMGao, bloodVMGcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Gibraltar")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("Body", gibyBodycol, gibyBodyspec, gibyBodygloss, gibyBodynorm, gibyBodyao, gibyBodycav, zipArchive, progressForm, false);

                    //Extra
                    LegendTexturePrep("Extra", gibyExtracol, gibyExtraspec, gibyExtragloss, gibyExtranorm, gibyExtraao, gibyExtracav, zipArchive, progressForm, false);

                    //Gear
                    LegendTexturePrep("Gear", gibyGearcol, gibyGearspec, gibyGeargloss, gibyGearnorm, gibyGearao, gibyGearcav, zipArchive, progressForm, false);

                    //JumpKit
                    LegendTexturePrep("JumpKit", gibyJumpKitcol, gibyJumpKitspec, gibyJumpKitgloss, gibyJumpKitnorm, gibyJumpKitao, gibyJumpKitcav, zipArchive, progressForm, false);

                    //Sheild
                    LegendTexturePrep("Sheild", gibyShieldcol, gibyShieldspec, gibyShieldgloss, gibyShieldnorm, gibyShieldao, gibyShieldcav, zipArchive, progressForm, false);

                    //Proxy
                    LegendTexturePrep("Proxy", gibyProxycol, gibyProxyspec, gibyProxygloss, gibyProxynorm, gibyProxyao, gibyProxycav, zipArchive, progressForm, false);

                    //Sheild Clamp
                    LegendTexturePrep("SheildClamp", gibySheildClampcol, gibySheildClampspec, gibySheildClampgloss, gibySheildClampnorm, gibySheildClampao, gibySheildClampcav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    LegendTexturePrep("VM", gibyVMcol, gibyVMspec, gibyVMgloss, gibyVMnorm, gibyVMao, gibyVMcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Lifeline")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("Body", lifelineBodycol, lifelineBodyspec, lifelineBodygloss, lifelineBodynorm, lifelineBodyao, lifelineBodycav, zipArchive, progressForm, false);

                    //Drone
                    LegendTexturePrep("Drone", lifelineDronecol, lifelineDronespec, lifelineDronegloss, lifelineDronenorm, lifelineDroneao, lifelineDronecav, zipArchive, progressForm, false);

                    //Hand
                    LegendTexturePrep("Hand", lifelineHandcol, lifelineHandspec, lifelineHandgloss, lifelineHandnorm, lifelineHandao, lifelineHandcav, zipArchive, progressForm, false);

                    //JumpKit
                    LegendTexturePrep("JumpKit", lifelineJumpKitcol, lifelineJumpKitspec, lifelineJumpKitgloss, lifelineJumpKitnorm, lifelineJumpKitao, lifelineJumpKitcav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    LegendTexturePrep("VM", lifelineVMcol, lifelineVMspec, lifelineVMgloss, lifelineVMnorm, lifelineVMao, lifelineVMcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Pathfinder")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    //LegendTexturePrep("_Body", pathfinderBodycol, pathfinderBodyspec, pathfinderBodygloss, pathfinderBodynorm, pathfinderBodyao, pathfinderBodycav, zipArchive, progressForm, false);

                    //Attachment
                    //LegendTexturePrep("_Attachment", pathfinderAttachmentcol, pathfinderAttachmentspec, pathfinderAttachmentgloss, pathfinderAttachmentnorm, pathfinderAttachmentao, pathfinderAttachmentcav, zipArchive, progressForm, false);

                    //GrappleHook
                    //LegendTexturePrep("_GrappleHook", pathfinderGrappleHookcol, pathfinderGrappleHookspec, pathfinderGrappleHookgloss, pathfinderGrappleHooknorm, pathfinderGrappleHookao, pathfinderGrappleHookcav, zipArchive, progressForm, false);

                    //Hands
                    //LegendTexturePrep("_Hands", pathfinderHandscol, pathfinderHandsspec, pathfinderHandsgloss, pathfinderHandsnorm, pathfinderHandsao, pathfinderHandscav, zipArchive, progressForm, false);

                    //Head
                    //LegendTexturePrep("_Head", pathfinderHeadcol, pathfinderHeadspec, pathfinderHeadgloss, pathfinderHeadnorm, pathfinderHeadao, pathfinderHeadcav, zipArchive, progressForm, false);

                    //JumpKit
                    //LegendTexturePrep("_JumpKit", pathfinderJumpKitcol, pathfinderJumpKitspec, pathfinderJumpKitgloss, pathfinderJumpKitnorm, pathfinderJumpKitao, pathfinderJumpKitcav, zipArchive, progressForm, false);

                    //Zipline
                    //LegendTexturePrep("_Zipline", pathfinderZiplinecol, pathfinderZiplinespec, pathfinderZiplinegloss, pathfinderZiplinenorm, pathfinderZiplineao, pathfinderZiplinecav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    //LegendTexturePrep("_VMA", pathfinderVMAcol, pathfinderVMAspec, pathfinderVMAgloss, pathfinderVMAnorm, pathfinderVMAao, pathfinderVMAcav, zipArchive, progressForm, false);

                    //Viemodel Zipline
                    //LegendTexturePrep("_VMZ", pathfinderVMZcol, pathfinderVMZspec, pathfinderVMZgloss, pathfinderVMZnorm, pathfinderVMZao, pathfinderVMZcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Wraith")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    //LegendTexturePrep("_Body", wraithBodycol, wraithBodyspec, wraithBodygloss, wraithBodynorm, wraithBodyao, wraithBodycav, zipArchive, progressForm, false);

                    //Gauntlet
                    //LegendTexturePrep("_Gauntlet", wraithGauntletcol, wraithGauntletspec, wraithGauntletgloss, wraithGauntletnorm, wraithGauntletao, wraithGauntletcav, zipArchive, progressForm, false);

                    //Hair
                    //LegendTexturePrep("_Hair", wraithHaircol, wraithHairspec, wraithHairgloss, wraithHairnorm, wraithHairao, wraithHaircav, zipArchive, progressForm, false);

                    //Hair02
                    //LegendTexturePrep("_Hair02", wraithHair02col, wraithHair02spec, wraithHair02gloss, wraithHair02norm, wraithHair02ao, wraithHair02cav, zipArchive, progressForm, false);

                    //Jetpack
                    //LegendTexturePrep("_Jetpack", wraithJetpackcol, wraithJetpackspec, wraithJetpackgloss, wraithJetpacknorm, wraithJetpackao, wraithJetpackcav, zipArchive, progressForm, false);

                    //Scarf
                    //LegendTexturePrep("_Scarf", wraithScarfcol, wraithScarfspec, wraithScarfgloss, wraithScarfnorm, wraithScarfao, wraithScarfcav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    //LegendTexturePrep("_VMA", wraithVMAcol, wraithVMAspec, wraithVMAgloss, wraithVMAnorm, wraithVMAao, wraithVMAcav, zipArchive, progressForm, false);

                    //Viewmodel Device
                    //LegendTexturePrep("_VMD", wraithVMDcol, wraithVMDspec, wraithVMDgloss, wraithVMDnorm, wraithVMDao, wraithVMDcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Bangalore")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(37); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("Body", bangaloreBodycol, bangaloreBodyspec, bangaloreBodygloss, bangaloreBodynorm, bangaloreBodyao, bangaloreBodycav, zipArchive, progressForm, false);

                    //Gauntlet
                    LegendTexturePrep("Gauntlet", bangaloreGauntletcol, bangaloreGauntletspec, bangaloreGauntletgloss, bangaloreGauntletnorm, bangaloreGauntletao, bangaloreGauntletcav, zipArchive, progressForm, false);

                    //Jetpack
                    LegendTexturePrep("Jetpack", bangaloreJetpackcol, bangaloreJetpackspec, bangaloreJetpackgloss, bangaloreJetpacknorm, bangaloreJetpackao, bangaloreJetpackcav, zipArchive, progressForm, false);

                    //Launcher
                    LegendTexturePrep("Launcher", bangaloreLaunchercol, bangaloreLauncherspec, bangaloreLaunchergloss, bangaloreLaunchernorm, bangaloreLauncherao, bangaloreLaunchercav, zipArchive, progressForm, false);

                    //Gas Cannister
                    LegendTexturePrepILM("Rocket", bangaloreGasCannistercol, bangaloreGasCannisterspec, bangaloreGasCannistergloss, bangaloreGasCannisternorm, bangaloreGasCannisterao, bangaloreGasCannistercav, bangaloreGasCannisterilm, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    LegendTexturePrep("VM", bangaloreVMcol, bangaloreVMspec, bangaloreVMgloss, bangaloreVMnorm, bangaloreVMao, bangaloreVMcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Caustic")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("_Body", causticBodycol, causticBodyspec, causticBodygloss, causticBodynorm, causticBodyao, causticBodycav, zipArchive, progressForm, false);

                    //Gauntlet
                    //LegendTexturePrep("_Gauntlet", causticGauntletcol, causticGauntletspec, causticGauntletgloss, causticGauntletnorm, causticGauntletao, causticGauntletcav, zipArchive, progressForm, false);
                    
                    //Gear
                    //LegendTexturePrep("_Gear", causticGearcol, causticGearspec, causticGeargloss, causticGearnorm, causticGearao, causticGearcav, zipArchive, progressForm, false);

                    //Hair
                    //LegendTexturePrep("_Hair", causticHaircol, causticHairspec, causticHairgloss, causticHairnorm, causticHairao, causticHaircav, zipArchive, progressForm, false);

                    //Head
                    //LegendTexturePrep("_Head", causticHeadcol, causticHeadspec, causticHeadgloss, causticHeadnorm, causticHeadao, causticHeadcav, zipArchive, progressForm, false);

                    //JumpKit
                    //LegendTexturePrep("_JumpKit", causticJumpKitcol, causticJumpKitspec, causticJumpKitgloss, causticJumpKitnorm, causticJumpKitao, causticJumpKitcav, zipArchive, progressForm, false);

                    //Lense
                    //LegendTexturePrep("_Lense", causticLensecol, causticLensespec, causticLensegloss, causticLensenorm, causticLenseao, causticLensecav, zipArchive, progressForm, false);

                    //Gas Grenade
                    //LegendTexturePrep("_GasGrenade", causticGasGrenadecol, causticGasGrenadespec, causticGasGrenadegloss, causticGasGrenadenorm, causticGasGrenadeao, causticGasGrenadecav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    //LegendTexturePrep("_VMA", causticVMAcol, causticVMAspec, causticVMAgloss, causticVMAnorm, causticVMAao, causticVMAcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Mirage")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Hair
                    //LegendTexturePrep("_Hair", mirageHaircol, mirageHairspec, mirageHairgloss, mirageHairnorm, mirageHairao, mirageHaircav, zipArchive, progressForm, false);

                    //Head
                    //LegendTexturePrep("_Head", mirageHeadcol, mirageHeadspec, mirageHeadgloss, mirageHeadnorm, mirageHeadao, mirageHeadcav, zipArchive, progressForm, false);

                    //HeadStuff
                    //LegendTexturePrep("_HeadStuff", mirageHeadStuffcol, mirageHeadStuffspec, mirageHeadStuffgloss, mirageHeadStuffnorm, mirageHeadStuffao, mirageHeadStuffcav, zipArchive, progressForm, false);

                    //JumpKit
                    //LegendTexturePrep("_JumpKit", mirageJumpKitcol, mirageJumpKitspec, mirageJumpKitgloss, mirageJumpKitnorm, mirageJumpKitao, mirageJumpKitcav, zipArchive, progressForm, false);

                    //Lower
                    //LegendTexturePrep("_Lower", mirageLowercol, mirageLowerspec, mirageLowergloss, mirageLowernorm, mirageLowerao, mirageLowercav, zipArchive, progressForm, false);

                    //Upper
                    //LegendTexturePrep("_Upper", mirageUppercol, mirageUpperspec, mirageUppergloss, mirageUppernorm, mirageUpperao, mirageUppercav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    //LegendTexturePrep("_VM", mirageVMcol, mirageVMspec, mirageVMgloss, mirageVMnorm, mirageVMao, mirageVMcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Octane")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    //LegendTexturePrep("_Body", octaneBodycol, octaneBodyspec, octaneBodygloss, octaneBodynorm, octaneBodyao, octaneBodycav, zipArchive, progressForm, false);

                    //Camera
                    //LegendTexturePrep("_Camera", octaneCameracol, octaneCameraspec, octaneCameragloss, octaneCameranorm, octaneCameraao, octaneCameracav, zipArchive, progressForm, false);

                    //Gauntlet
                    //LegendTexturePrep("_Gauntlet", octaneGauntletcol, octaneGauntletspec, octaneGauntletgloss, octaneGauntletnorm, octaneGauntletao, octaneGauntletcav, zipArchive, progressForm, false);

                    //Gear
                    //LegendTexturePrep("_Gear", octaneGearcol, octaneGearspec, octaneGeargloss, octaneGearnorm, octaneGearao, octaneGearcav, zipArchive, progressForm, false);

                    //Head
                    //LegendTexturePrep("_Head", octaneHeadcol, octaneHeadspec, octaneHeadgloss, octaneHeadnorm, octaneHeadao, octaneHeadcav, zipArchive, progressForm, false);

                    //JumpKit
                    //LegendTexturePrep("_JumpKit", octaneJumpKitcol, octaneJumpKitspec, octaneJumpKitgloss, octaneJumpKitnorm, octaneJumpKitao, octaneJumpKitcav, zipArchive, progressForm, false);

                    //Viewmodel Arms
                    //LegendTexturePrep("_VM", octaneVMcol, octaneVMspec, octaneVMgloss, octaneVMnorm, octaneVMao, octaneVMcav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Wattson")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(32); // 24 texture slots 
                        progressForm.ShowDialog();
                    } ); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Gear
                    LegendTexturePrepILM("Gear", wattGearcol, wattGearspec, wattGeargloss, wattGearnorm, wattGearao, wattGearcav, wattGearilm, zipArchive, progressForm, false);

                    //Jacket
                    LegendTexturePrep("Jacket", wattJacketcol, wattJacketspec, wattJacketgloss, wattJacketnorm, wattJacketao, wattJacketcav, zipArchive, progressForm, false);

                    //JumpKit
                    LegendTexturePrep("Jumpkit", wattJumpKitcol, wattJumpKitspec, wattJumpKitgloss, wattJumpKitnorm, wattJumpKitao, wattJumpKitcav, zipArchive, progressForm, false);

                    //Suit
                    LegendTexturePrep("Suit", wattSuitcol, wattSuitspec, wattSuitgloss, wattSuitnorm, wattSuitao, wattSuitcav, zipArchive, progressForm, false);

                    //ViewModel
                    LegendTexturePrepILM("VM", wattVMcol, wattVMspec, wattVMgloss, wattVMnorm, wattVMao, wattVMcav, wattVMilm, zipArchive, progressForm, true);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (SelectedWeapon == "Crypto")
            {
                try
                {
                    Thread progressThread = new Thread(() => {
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    //
                    //LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm, false);

                    progressForm?.ForceClose();

                    zipArchive.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string GetSkinPackRootPath()
        {
            return skinPackPathTextBox.Text + "\\" + SelectedWeapon + "_" + skinNameTextBox.Text + ".zip";
        }
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (var _memorystream = new MemoryStream())
            {
                image.Save(_memorystream, image.RawFormat);
                return _memorystream.ToArray();
            }
        }

        private void SaveTexture(string filename, MagickImage image, ZipArchive archive, BCnEncoder.Shared.CompressionFormat compression = BCnEncoder.Shared.CompressionFormat.Rgba)
        {
            int[] sizes = new int[] {
                2048,
                1024,
                512
            };

            foreach (int size in sizes)
            {
                ZipArchiveEntry entry = archive.CreateEntry("contents/" + size.ToString() + "/" + filename);
                using (Stream s = entry.Open())
                {
                    image.Scale(size, size);
                    if (compression != BCnEncoder.Shared.CompressionFormat.Rgba)
                    {
                        image.Format = MagickFormat.Png32;
                        image.SetCompression(CompressionMethod.NoCompression);
                        BcEncoder encoder = new BcEncoder();
                        encoder.OutputOptions.GenerateMipMaps = false;
                        encoder.OutputOptions.Format = compression;
                        encoder.OutputOptions.FileFormat = BCnEncoder.Shared.OutputFileFormat.Dds;
                        encoder.EncodeToStream(image.ToByteArray(MagickFormat.Rgba), size, size, BCnEncoder.Encoder.PixelFormat.Rgba32, s);
                    }
                    else
                    {
                        DdsWriteDefines ddsDefines = new DdsWriteDefines();
                        ddsDefines.Compression = DdsCompression.Dxt1;
                        ddsDefines.Mipmaps = 0;

                        image.Format = MagickFormat.Dds;
                        image.Settings.SetDefines(ddsDefines);

                        image.Write(s);
                    }

                    s.Flush();
                    s.Close();
                }
            }
        }

        private void texturePictureBox_NClick(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            PictureBox box = (PictureBox)sender;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add(rm.GetString("ContextChoose"), null, (object menuSender, EventArgs menuE) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Filter = "PNG (*.png) | *.png";

                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    LoadImageIntoPictureBox(box, dialog.FileName);
                }
            });
            menu.Items.Add(rm.GetString("ContextRemove"), null, (object menuSender, EventArgs menuE) =>
            {
                box.Image = null;
            });

            menu.Show(box, m.Location);
        }

        private void texturePictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (box.Enabled == false)
            {
            }
        }

        private void SelectedLegendChanged(TabPage a)
        {
            tabControl1.TabPages.Remove(BloodhoundtabPage);
            tabControl1.TabPages.Remove(GibraltartabPage);
            tabControl1.TabPages.Remove(LifelinetabPage);
            tabControl1.TabPages.Remove(PathfindertabPage);
            tabControl1.TabPages.Remove(WraithtabPage);
            tabControl1.TabPages.Remove(BangaloretabPage);
            tabControl1.TabPages.Remove(CaustictabPage);
            tabControl1.TabPages.Remove(MiragetabPage);
            tabControl1.TabPages.Remove(OctanetabPage);
            tabControl1.TabPages.Remove(WattsontabPage);
            tabControl1.TabPages.Remove(CryptotabPage);

            tabControl1.TabPages.Add(a);
        }

        private void assetTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedItemChanged();
            DisableAllTextures();
            if (SelectedGame == "APEX")
            {
                switch (SelectedWeapon)
                {
                    case "Bloodhound":
                        SelectedLegendChanged(BloodhoundtabPage);
                        break;
                    case "Gibraltar":
                        SelectedLegendChanged(GibraltartabPage);
                        break;
                    case "Lifeline":
                        SelectedLegendChanged(LifelinetabPage);
                        break;
                    case "Pathfinder":
                        SelectedLegendChanged(PathfindertabPage);
                        break;
                    case "Wraith":
                        SelectedLegendChanged(WraithtabPage);
                        break;
                    case "Bangalore":
                        SelectedLegendChanged(BangaloretabPage);
                        break;
                    case "Caustic":
                        SelectedLegendChanged(CaustictabPage);
                        break;
                    case "Mirage":
                        SelectedLegendChanged(MiragetabPage);
                        break;
                    case "Octane":
                        SelectedLegendChanged(OctanetabPage);
                        break;
                    case "Wattson":
                        SelectedLegendChanged(WattsontabPage);
                        break;
                    case "Crypto":
                        SelectedLegendChanged(CryptotabPage);
                        break;
                    default:
                        MessageBox.Show(rm.GetString("BUG"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            else if (SelectedGame == "Titanfall2")
            {
                //Nothing
            }
        }

        private void DisableAllTextures()
        {
            /*foreach (PictureBox box in new PictureBox[]
                {
                    colorPictureBox,
                    specularPictureBox,
                    glossinessPictureBox,
                    normalPictureBox,
                    aoPictureBox,
                    cavityPictureBox,
                    illuminationPictureBox
                })
            {
                DisableTexture(box);
            }*/
        }

        private void DisableTexture(PictureBox box)
        {
            box.Enabled = false;
            box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("texture_not_available");
        }

        private void EnableTexture(PictureBox box)
        {
            box.Enabled = true;
            box.Image = null;
        }

        private void LanguageSet()
        {
            // LOCALIZATION

            // General Info Group
            this.Text = rm.GetString("SkinPackMaker");
            generalInfoGroup.Text = rm.GetString("GeneralInfoGroup");
            skinNameLabel.Text = rm.GetString("SkinName");
            assetTypeLabel.Text = rm.GetString("AssetType");
            savePathLabel.Text = rm.GetString("SavePath");

            // Textures Set Group

            /*texturesSetGroup.Text = rm.GetString("TexturesSetGroup");
            colorLabel.Text = rm.GetString("Color");
            specularLabel.Text = rm.GetString("Specular");
            glossinessLabel.Text = rm.GetString("Glossinesss");
            normalLabel.Text = rm.GetString("Normal");
            aoLabel.Text = rm.GetString("AO");
            cavityLabel.Text = rm.GetString("Cavity");
            illuminationLabel.Text = rm.GetString("Illumination");*/

            // Generate Button
            generateSkinPackButton.Text = rm.GetString("Generate");

            // Default Path
            skinPackPathTextBox.Text = Environment.CurrentDirectory;
        }

        private void LoadWeaponName()
        {
            switch (SelectedGame)
            {
                case "APEX":
                    this.assetTypeComboBox.Items.AddRange(new object[] {
                        rm.GetString("Items100"),
                        rm.GetString("Items101"),
                        rm.GetString("Items102"),
                        rm.GetString("Items103"),
                        rm.GetString("Items104"),
                        rm.GetString("Items105"),
                        rm.GetString("Items106"),
                        rm.GetString("Items107"),
                        rm.GetString("Items108"),
                        rm.GetString("Items109"),
                        rm.GetString("Items110"),
                    });
                    break;
                case "Titanfall2":
                    break;
                default:
                    MessageBox.Show(rm.GetString("SetGamePath"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void SelectedItemChanged()
        {
            switch (assetTypeComboBox.Text)
            {
                //start APEX part
                case "Bloodhound":
                case "Bloodhound2":
                    SelectedWeapon = "Bloodhound";
                    break;
                case "Gibraltar":
                case "Gibraltar2":
                    SelectedWeapon = "Gibraltar";
                    break;
                case "Lifeline":
                case "Lifeline2":
                    SelectedWeapon = "Lifeline";
                    break;
                case "Pathfinder":
                case "Pathfinder2":
                    SelectedWeapon = "Pathfinder";
                    break;
                case "Wraith":
                case "Wraith2":
                    SelectedWeapon = "Wraith";
                    break;
                case "Bangalore":
                case "Bangalore2":
                    SelectedWeapon = "Bangalore";
                    break;
                case "Caustic":
                case "Caustic2":
                    SelectedWeapon = "Caustic";
                    break;
                case "Mirage":
                case "Mirage2":
                    SelectedWeapon = "Mirage";
                    break;
                case "Octane":
                case "Octane2":
                    SelectedWeapon = "Octane";
                    break;
                case "Wattson":
                case "Wattson2":
                    SelectedWeapon = "Wattson";
                    break;
                case "Crypto":
                case "Crypto2":
                    SelectedWeapon = "Crypto";
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

