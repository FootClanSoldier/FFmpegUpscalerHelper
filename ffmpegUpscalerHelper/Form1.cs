using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFUpscalerHelper
{
    public partial class Form1 : Form
    {
        static Dictionary<string, string> dicPresets;
        bool isInPresetRenameMode = false;
        bool isInCreateNewPresetMode = false;
        public Form1()
        {
            InitializeComponent();
            // Properties.Settings.Default.Reset();
            InitPresets();
            InitSettings();
        }

        private void InitSettings()
        {
            tbPngDimension.Text = Properties.Settings.Default.dimension_png;
            lbPresets.SelectedIndex = Properties.Settings.Default.selectedPreset;
            //todo lbDefaultPresetSetting.SelectedIndex = Properties.Settings.Default.selectedPreset;
            tbSettingsDimensionsPng.Text = tbPngDimension.Text;
            tbSettingsExeLocation.Text = Properties.Settings.Default.ffmpeg_location;
            btnSettingsSave.Enabled = false;
            btnSavePreset.Enabled = false;
            cbOpenOutputFolder.Checked = Properties.Settings.Default.open_folder;
            if (tbSettingsExeLocation.Text == "NotSet")
                tbSettingsExeLocation.Text = "";
        }

        private void InitPresets()
        {
            dicPresets = new Dictionary<string, string>();
            var EncodingPresets = Properties.Settings.Default.presets;

            string item1 = "";
            string item2;
            using (StringReader reader = new StringReader(EncodingPresets))
            {
                string line;
                int rowNr = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (rowNr % 2 == 0)
                    {
                        item1 = line;
                        lbPresets.Items.Add(line);
                        //todo lbDefaultPresetSetting.Items.Add(line);
                    }
                    else
                    {
                        item2 = line;
                        dicPresets.Add(item1, item2);
                    }

                    rowNr += 1;
                }
            }
        }

        private void btnVideoToPngVideoLocation_Click(object sender, EventArgs e)
        {
            string VideoFormat = "Video files |*.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                                " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm; *.dat; ";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                //openFileDialog.InitialDirectory = "c:\\";

                openFileDialog.Filter = VideoFormat;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbVideoToPngVideoInput.Text = openFileDialog.FileName;
                }
            }



        }

        private void btnVideoToPngOutputLocation_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbVideoToPngVideoOutput.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

        private void btnVideoToPngStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbVideoToPngVideoInput.Text != "" && tbVideoToPngVideoOutput.Text != "" && tbPngDimension.Text != "")
                {
                    string cmdParams = "-i \"" + tbVideoToPngVideoInput.Text + "\" -s " + tbPngDimension.Text + " \"" + tbVideoToPngVideoOutput.Text + "\\%06d.png\"";

                    var ffmpegLocation = Properties.Settings.Default.ffmpeg_location;

                    if (ffmpegLocation == "NotSet")
                    {
                        ErrorMsg("You need to select the location of your ffmpeg.exe file under Settings.");
                    }
                    else if (ffmpegLocation != "")
                    {
                        Process process = Process.Start("cmd.exe", $@"/k {ffmpegLocation} {cmdParams}");

                        if (Properties.Settings.Default.open_folder)
                        {
                            Process.Start(tbVideoToPngVideoOutput.Text);
                        }
                        tbVideoToPngVideoInput.Text = "";
                        tbVideoToPngVideoOutput.Text = "";

                    }
                    else
                    {
                        ErrorMsg("You need to select the location of your ffmpeg.exe file under Settings.");
                    }

                }
                else
                {
                    ErrorMsg("You need to select video location, output location and png dimension.");
                }
            }
            catch
            {
                ErrorMsg("Something went wrong.Make sure all folders exist and that the video dimension is in the correct format");
            }

        }


        private void lbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbPreset.Text = dicPresets[lbPresets.SelectedItem.ToString()];
            }
            catch (Exception)
            {

            }
            btnSavePreset.Enabled = false;
        }

        private void lbDefaultPresetSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSettingsSave.Enabled = true;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            lblPresetName.Visible = true;
            tbPresetName.Visible = true;
            btnRename.Enabled = false;
            tbPresetName.Enabled = true;

            tbPresetName.Text = lbPresets.SelectedItem.ToString();
            btnSavePreset.Enabled = true;
            tbPresetName.Focus();
            tbPresetName.SelectionStart = tbPresetName.Text.Length;
            tbPresetName.SelectionLength = 0;
            lbPresets.Enabled = false;
            isInPresetRenameMode = true;
            lbPresets.Height = 140;
            btnCreateNewPreset.Enabled = false;
            btnDeletePreset.Enabled = false;

        }

        private void SetSavePresetCtrl()
        {
            lbPresets.Enabled = true;
            btnSavePreset.Enabled = false;
            tbPresetName.Enabled = false;

            btnRename.Enabled = true;
            btnCreateNewPreset.Enabled = true;
            tbPresetName.Text = "";
            lbPresets.Height = 174;
            lblPresetName.Visible = false;
            tbPresetName.Visible = false;
            btnDeletePreset.Enabled = true;
        }
        private void btnSavePreset_Click(object sender, EventArgs e)
        {


            if (isInCreateNewPresetMode)
            {
                if (tbPresetName.Text != "")
                {
                    if (IsPresetNameAlreadyTaken(tbPresetName.Text))
                    {
                        ErrorMsg("Name for preset is already taken.");
                        tbPresetName.Focus();
                    }
                    else
                    {
                        dicPresets.Add(tbPresetName.Text, Properties.Settings.Default.DefaultFfmpegPreset);
                        var nrPresets = lbPresets.Items.Count;
                        lbPresets.Items.Add(tbPresetName.Text);
                        //todo lbDefaultPresetSetting.Items.Add(tbPresetName.Text);
                        lbPresets.SelectedIndex = nrPresets;



                        tbPresetName.Text = "";
                        Properties.Settings.Default.presets = GetDictionaryToString(dicPresets);
                        Properties.Settings.Default.Save();
                        isInCreateNewPresetMode = false;

                        SetSavePresetCtrl();
                    }

                }
                else
                {
                    ErrorMsg("You need to type in a name for the preset.");
                }
            }
            else if (isInPresetRenameMode && tbPresetName.Text != "")
            {
                if (IsPresetNameAlreadyTaken(tbPresetName.Text, lbPresets.SelectedIndex))
                {
                    ErrorMsg("Preset name is already taken.");
                    return;
                }
                isInPresetRenameMode = false;
                dicPresets = new Dictionary<string, string>();
                var EncodingPresets = Properties.Settings.Default.presets;

                string item1 = "";
                string item2;
                int selectedIndex = lbPresets.SelectedIndex;
                lbPresets.Items.Clear();
                //todo lbDefaultPresetSetting.Items.Clear();
                int i = 0;
                using (StringReader reader = new StringReader(EncodingPresets))
                {
                    string line;
                    int rowNr = 0;


                    while ((line = reader.ReadLine()) != null)
                    {


                        if (rowNr % 2 == 0)
                        {
                            if (i == selectedIndex)
                            {
                                item1 = tbPresetName.Text;
                                line = tbPresetName.Text;
                            }
                            else
                            {
                                item1 = line;
                            }
                            i++;

                            lbPresets.Items.Add(line);
                            //todo lbDefaultPresetSetting.Items.Add(line);


                        }
                        else
                        {
                            item2 = line;
                            dicPresets.Add(item1, item2);
                        }

                        rowNr += 1;
                    }
                    Properties.Settings.Default.presets = GetDictionaryToString(dicPresets);
                    Properties.Settings.Default.Save();

                }
                lbPresets.SelectedIndex = selectedIndex;
                //todo lbDefaultPresetSetting.SelectedIndex = Properties.Settings.Default.selectedPreset;

                SetSavePresetCtrl();
            }
            else if (tbPresetName.Text == "" && isInPresetRenameMode)
            {
                ErrorMsg("You need to type in a name for the preset.");
            }
            else if (!isInPresetRenameMode && !isInPresetRenameMode)
            {

                //tbPreset.Text
                dicPresets[lbPresets.SelectedItem.ToString()] = tbPreset.Text;
                Properties.Settings.Default.presets = GetDictionaryToString(dicPresets);
                Properties.Settings.Default.Save();
                SetSavePresetCtrl();
            }

        }

        private bool IsPresetNameAlreadyTaken(string value)
        {
            foreach (var item in lbPresets.Items)
            {
                if (item.ToString() == value)
                    return true;
            }
            return false;
        }
        private bool IsPresetNameAlreadyTaken(string value, int i)
        {
            int l = 0;
            foreach (var item in lbPresets.Items)
            {
                if (item.ToString() == value && i != l)
                    return true;
                l++;
            }
            return false;
        }

        private string GetDictionaryToString(Dictionary<string, string> dic)
        {
            string dicString = "";

            foreach (var line in dic)
            {
                dicString += line.Key + Environment.NewLine + line.Value + Environment.NewLine;
            }

            dicString = dicString.TrimEnd('\r', '\n');
            return dicString;
        }

        private void ErrorMsg(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSettingsExeLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                string ffmpegFormat = "FFmpeg.exe |*.exe";
                openFileDialog.Filter = ffmpegFormat;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    if (!openFileDialog.FileName.Contains("ffmpeg.exe"))
                    {
                        ErrorMsg("You need to select the correct location to ffmpeg.exe");
                        btnSettingsSave.Enabled = false;
                    }
                    else
                    {
                        tbSettingsExeLocation.Text = openFileDialog.FileName;
                        btnSettingsSave.Enabled = true;
                    }

                }
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {

            if (tbSettingsExeLocation.Text == "NotSet")
            {
                Properties.Settings.Default.ffmpeg_location = tbSettingsExeLocation.Text;

            }
            else if (tbSettingsExeLocation.Text.EndsWith("ffmpeg.exe"))
            {
                Properties.Settings.Default.ffmpeg_location = tbSettingsExeLocation.Text;

            }
            else
            {
                ErrorMsg("Missing path to ffmpeg.exe");
            }
            Properties.Settings.Default.dimension_png = tbSettingsDimensionsPng.Text;
            btnSettingsSave.Enabled = false;

            if (tbSettingsDimensionsPng.Text.ToLower().Contains("x"))
            {
                tbPngDimension.Text = tbSettingsDimensionsPng.Text;
            }
            else
            {
                ErrorMsg("Incorrect format for png dimension.");
                btnSettingsSave.Enabled = true;
            }
            Properties.Settings.Default.open_folder = cbOpenOutputFolder.Checked;
            Properties.Settings.Default.Save();


            if (!tbSettingsExeLocation.Text.EndsWith("ffmpeg.exe"))
            {
                btnSettingsSave.Enabled = true;
            }
        }

        private void tbSettingsDimensionsPng_TextChanged(object sender, EventArgs e)
        {

            btnSettingsSave.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSettingsSave.Enabled = true;
        }

        private void tbSettingsExeLocation_TextChanged(object sender, EventArgs e)
        {
            btnSettingsSave.Enabled = true;
        }

        private void tbSettingsDefaultVideoFilename_TextChanged(object sender, EventArgs e)
        {
            btnSettingsSave.Enabled = true;
        }


        private void btnEncodeVideoStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEncodeVideoOutputLocation.Text != "" && tbEncodeVideoPngFramesLocation.Text != "" && tbEncodeVideoFilename.Text != "")
                {
                    //[InputImgLocation] and [OutputLocation]
                    string cmdParams = tbPreset.Text.Replace("[InputImgLocation]", "\"" + tbEncodeVideoPngFramesLocation.Text + "\"").Replace("[OutputLocation]", "\"" + tbEncodeVideoOutputLocation.Text + "\\" + tbEncodeVideoFilename.Text + "\"");

                    var ffmpegLocation = Properties.Settings.Default.ffmpeg_location;

                    if (ffmpegLocation == "NotSet")
                    {
                        ErrorMsg("You need to select the location of your ffmpeg.exe file under Settings.");
                    }
                    else if (ffmpegLocation != "")
                    {
                        Process process = Process.Start("cmd.exe", $@"/k {ffmpegLocation} {cmdParams}");

                        if (Properties.Settings.Default.open_folder)
                        {
                            Process.Start(tbEncodeVideoOutputLocation.Text);
                        }
                        tbEncodeVideoOutputLocation.Text = "";
                        tbEncodeVideoPngFramesLocation.Text = "";

                    }
                    else
                    {
                        ErrorMsg("You need to select the location of your ffmpeg.exe file under Settings.");
                    }

                }
                else
                {
                    ErrorMsg("You need to select the png frames location, output location and filename.");
                }
            }
            catch
            {
                ErrorMsg("Something went wrong. Make sure all locations exist");
            }

        }

        private void btnEncodeVideoOutputLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {

                    tbEncodeVideoOutputLocation.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

        private void btnEncodeVideoPngFramesLocation_Click_1(object sender, EventArgs e)
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbEncodeVideoPngFramesLocation.Text = folderBrowserDialog.SelectedPath;
                }
            }

        }

        private void tbPreset_TextChanged(object sender, EventArgs e)
        {
            btnSavePreset.Enabled = true;
            if (isInPresetRenameMode || isInCreateNewPresetMode)
            {
                SetSavePresetCtrl();
                isInCreateNewPresetMode = false;
                isInPresetRenameMode = false;
            }
            btnSavePreset.Enabled = true;
        }

        private void tbPreset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                SetSavePresetCtrl();
            }

        }

        private void btnCreateNewPreset_Click(object sender, EventArgs e)
        {
            btnCreateNewPreset.Enabled = false;
            tbPresetName.Visible = true;
            lblPresetName.Visible = true;
            tbPresetName.Enabled = true;
            lbPresets.Height = 140;
            tbPresetName.Focus();
            btnRename.Enabled = false;
            isInCreateNewPresetMode = true;
            isInPresetRenameMode = false;
            btnSavePreset.Enabled = true;
            btnDeletePreset.Enabled = false;
            lbPresets.Enabled = false;
        }

        private void tbPresetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SetSavePresetCtrl();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnSavePreset.PerformClick();
            }
        }
        private void btnDeletePreset_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Are you sure you would like to delete the selected preset?", "Delete Selected Preset?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.Yes)
            {
                var i = lbPresets.SelectedIndex;
                if (lbPresets.Items.Count > 1)
                {
                    dicPresets.Remove(lbPresets.SelectedItem.ToString());
                    Properties.Settings.Default.presets = GetDictionaryToString(dicPresets);
                    Properties.Settings.Default.Save();
                    lbPresets.Items.RemoveAt(i);
                    //todo lbDefaultPresetSetting.Items.RemoveAt(i);


                    if (i > 0)
                    {
                        lbPresets.SelectedIndex = i - 1;
                    }
                    else
                    {
                        lbPresets.SelectedIndex = 0;
                    }
                }
                else
                {
                    ErrorMsg("Can't delete selected preset. You need atleast one preset.");
                }
            }


        }

        private void lbPresets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDeletePreset.PerformClick();
            }
        }
    }
}

