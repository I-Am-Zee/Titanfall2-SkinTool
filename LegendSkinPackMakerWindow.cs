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

        private void LegendTexturePrep(string prefix, PictureBox col, PictureBox spc, PictureBox gls, PictureBox nml, PictureBox ao, PictureBox cav, ZipArchive zipArchive, ProgressForm progressForm)
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
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("_Body", bloodBodycol, bloodBodyspec, bloodBodygloss, bloodBodynorm, bloodBodyao, bloodBodycav, zipArchive, progressForm);

                    //Fur
                    LegendTexturePrep("_Fur", bloodFurcol, bloodFurspec, bloodFurgloss, bloodFurnorm, bloodFurao, bloodFurcav, zipArchive, progressForm);

                    //Gauntlet
                    LegendTexturePrep("_Gauntlet", bloodGauntletcol, bloodGauntletspec, bloodGauntletgloss, bloodGauntletnorm, bloodGauntletao, bloodGauntletcav, zipArchive, progressForm);

                    //Gear
                    LegendTexturePrep("_Gear", bloodGearcol, bloodGearspec, bloodGeargloss, bloodGearnorm, bloodGearnorm, bloodGearcav, zipArchive, progressForm);

                    //Helmet
                    LegendTexturePrep("_Helmet", bloodHelmetcol, bloodHelmetspec, bloodHelmetgloss, bloodHelmetnorm, bloodHelmetao, bloodHelmetcav, zipArchive, progressForm);

                    //ViewModel Arms
                    LegendTexturePrep("_VMA", bloodVMAcol, bloodVMAspec, bloodVMAgloss, bloodVMAnorm, bloodVMAao, bloodVMAcav, zipArchive, progressForm);

                    //ViewModel Gear
                    LegendTexturePrep("_VMG", bloodVMGcol, bloodVMGspec, bloodVMGgloss, bloodVMGnorm, bloodVMGao, bloodVMGcav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", gibyBodycol, gibyBodyspec, gibyBodygloss, gibyBodynorm, gibyBodyao, gibyBodycav, zipArchive, progressForm);

                    //Extra
                    LegendTexturePrep("_Extra", gibyExtracol, gibyExtraspec, gibyExtragloss, gibyExtranorm, gibyExtraao, gibyExtracav, zipArchive, progressForm);

                    //Gear
                    LegendTexturePrep("_Gear", gibyGearcol, gibyGearspec, gibyGeargloss, gibyGearnorm, gibyGearao, gibyGearcav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", gibyHaircol, gibyHairspec, gibyHairgloss, gibyHairnorm, gibyHairao, gibyHaircav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", gibyHeadcol, gibyHeadspec, gibyHeadgloss, gibyHeadnorm, gibyHeadao, gibyHeadcav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", gibyJumpKitcol, gibyJumpKitspec, gibyJumpKitgloss, gibyJumpKitnorm, gibyJumpKitao, gibyJumpKitcav, zipArchive, progressForm);

                    //Sheild
                    LegendTexturePrep("_Sheild", gibySheildcol, gibySheildspec, gibySheildgloss, gibySheildnorm, gibySheildao, gibySheildcav, zipArchive, progressForm);

                    //Proxy
                    LegendTexturePrep("_Proxy", gibyProxycol, gibyProxyspec, gibyProxygloss, gibyProxynorm, gibyProxyao, gibyProxycav, zipArchive, progressForm);

                    //Sheild Clamp
                    LegendTexturePrep("_SheildClamp", gibySheildClampcol, gibySheildClampspec, gibySheildClampgloss, gibySheildClampnorm, gibySheildClampao, gibySheildClampcav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VM", gibyVMcol, gibyVMspec, gibyVMgloss, gibyVMnorm, gibyVMao, gibyVMcav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Drone
                    LegendTexturePrep("_Drone", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Face
                    LegendTexturePrep("_Face", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hand
                    LegendTexturePrep("_Hand", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VM", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Attachment
                    LegendTexturePrep("_Attachment", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //GrappleHook
                    LegendTexturePrep("_GrappleHook", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hands
                    LegendTexturePrep("_Hands", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Zipline
                    LegendTexturePrep("_Zipline", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VMA", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viemodel Zipline
                    LegendTexturePrep("_VMZ", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gauntlet
                    LegendTexturePrep("_Gauntlet", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hair02
                    LegendTexturePrep("_Hair02", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Jetpack
                    LegendTexturePrep("_Jetpack", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Scarf
                    LegendTexturePrep("_Scarf", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VMA", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Device
                    LegendTexturePrep("_VMD", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    }); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Body
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gauntlet
                    LegendTexturePrep("_Gauntlet", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Jetpack
                    LegendTexturePrep("_Jetpack", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Launcher
                    LegendTexturePrep("_Launcher", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gas Cannister
                    LegendTexturePrep("_GasCannister", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VM", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gauntlet
                    LegendTexturePrep("_Gauntlet", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);
                    
                    //Gear
                    LegendTexturePrep("_Gear", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Lense
                    LegendTexturePrep("_Lense", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gas Grenade
                    LegendTexturePrep("_GasGrenade", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VMA", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Hair", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //HeadStuff
                    LegendTexturePrep("_HeadStuff", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Lower
                    LegendTexturePrep("_Lower", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Upper
                    LegendTexturePrep("_Upper", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VM", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                    LegendTexturePrep("_Body", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Camera
                    LegendTexturePrep("_Camera", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gauntlet
                    LegendTexturePrep("_Gauntlet", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Gear
                    LegendTexturePrep("_Gear", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_JumpKit", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //Viewmodel Arms
                    LegendTexturePrep("_VM", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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
                        progressForm = new ProgressForm(42); // 24 texture slots 
                        progressForm.ShowDialog();
                    } ); // 24 texture slots

                    progressThread.Start();

                    ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

                    //Gear
                    LegendTexturePrep("_Gear", wattGearcol, wattGearspec, wattGeargloss, wattGearnorm, wattGearao, wattGearcav, zipArchive, progressForm);

                    //Hair
                    LegendTexturePrep("_Hair", wattHaircol, wattHairspec, wattHairgloss, wattHairnorm, wattHairao, wattHaircav, zipArchive, progressForm);

                    //Head
                    LegendTexturePrep("_Head", wattHeadcol, wattHeadspec, wattHeadgloss, wattHeadnorm, wattHeadao, wattHeadcav, zipArchive, progressForm);

                    //Jacket
                    LegendTexturePrep("_Jacket", wattJacketcol, wattJacketspec, wattJacketgloss, wattJacketnorm, wattJacketao, wattJacketcav, zipArchive, progressForm);

                    //JumpKit
                    LegendTexturePrep("_Jumpkit", wattJumpKitcol, wattJumpKitspec, wattJumpKitgloss, wattJumpKitnorm, wattJumpKitao, wattJumpKitcav, zipArchive, progressForm);

                    //Suit
                    LegendTexturePrep("_Suit", wattSuitcol, wattSuitspec, wattSuitgloss, wattSuitnorm, wattSuitao, wattSuitcav, zipArchive, progressForm);

                    //ViewModel
                    LegendTexturePrep("_VM", wattVMcol, wattVMspec, wattVMgloss, wattVMnorm, wattVMao, wattVMcav, zipArchive, progressForm);

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
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

                    //
                    LegendTexturePrep("_", col, spec, gloss, norm, ao, cav, zipArchive, progressForm);

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

