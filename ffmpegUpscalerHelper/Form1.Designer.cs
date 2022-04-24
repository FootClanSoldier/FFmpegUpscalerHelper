
namespace FFUpscalerHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPresetName = new System.Windows.Forms.Label();
            this.tbPresetName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnCreateNewPreset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSavePreset = new System.Windows.Forms.Button();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPresets = new System.Windows.Forms.ListBox();
            this.tbPreset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVideoToPngStart = new System.Windows.Forms.Button();
            this.btnVideoToPngOutputLocation = new System.Windows.Forms.Button();
            this.tbVideoToPngVideoOutput = new System.Windows.Forms.TextBox();
            this.tbVideoToPngVideoInput = new System.Windows.Forms.TextBox();
            this.tbPngDimension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVideoToPngVideoLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEncodeVideoStart = new System.Windows.Forms.Button();
            this.btnEncodeVideoOutputLocation = new System.Windows.Forms.Button();
            this.tbEncodeVideoOutputLocation = new System.Windows.Forms.TextBox();
            this.tbEncodeVideoPngFramesLocation = new System.Windows.Forms.TextBox();
            this.tbEncodeVideoFilename = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEncodeVideoPngFramesLocation = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbOpenOutputFolder = new System.Windows.Forms.CheckBox();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.tbSettingsExeLocation = new System.Windows.Forms.TextBox();
            this.btnSettingsExeLocation = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSettingsDimensionsPng = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresetName
            // 
            this.lblPresetName.AutoSize = true;
            this.lblPresetName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresetName.Location = new System.Drawing.Point(478, 170);
            this.lblPresetName.Name = "lblPresetName";
            this.lblPresetName.Size = new System.Drawing.Size(100, 18);
            this.lblPresetName.TabIndex = 21;
            this.lblPresetName.Text = "Preset Name";
            this.lblPresetName.Visible = false;
            // 
            // tbPresetName
            // 
            this.tbPresetName.Enabled = false;
            this.tbPresetName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPresetName.Location = new System.Drawing.Point(481, 191);
            this.tbPresetName.Name = "tbPresetName";
            this.tbPresetName.Size = new System.Drawing.Size(159, 25);
            this.tbPresetName.TabIndex = 19;
            this.tbPresetName.Visible = false;
            this.tbPresetName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPresetName_KeyDown);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(481, 264);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 38);
            this.btnRename.TabIndex = 18;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCreateNewPreset
            // 
            this.btnCreateNewPreset.Location = new System.Drawing.Point(481, 220);
            this.btnCreateNewPreset.Name = "btnCreateNewPreset";
            this.btnCreateNewPreset.Size = new System.Drawing.Size(75, 38);
            this.btnCreateNewPreset.TabIndex = 17;
            this.btnCreateNewPreset.Text = "Create new";
            this.btnCreateNewPreset.UseVisualStyleBackColor = true;
            this.btnCreateNewPreset.Click += new System.EventHandler(this.btnCreateNewPreset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 36);
            this.label9.TabIndex = 16;
            this.label9.Text = "[InputImgLocation] and [OutputLocation]\r\nneeds to be in the command.";
            // 
            // btnSavePreset
            // 
            this.btnSavePreset.Enabled = false;
            this.btnSavePreset.Location = new System.Drawing.Point(562, 264);
            this.btnSavePreset.Name = "btnSavePreset";
            this.btnSavePreset.Size = new System.Drawing.Size(75, 38);
            this.btnSavePreset.TabIndex = 15;
            this.btnSavePreset.Text = "Save";
            this.btnSavePreset.UseVisualStyleBackColor = true;
            this.btnSavePreset.Click += new System.EventHandler(this.btnSavePreset_Click);
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.Location = new System.Drawing.Point(562, 220);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(75, 38);
            this.btnDeletePreset.TabIndex = 14;
            this.btnDeletePreset.Text = "Delete";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.btnDeletePreset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Presets";
            // 
            // lbPresets
            // 
            this.lbPresets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresets.FormattingEnabled = true;
            this.lbPresets.ItemHeight = 17;
            this.lbPresets.Location = new System.Drawing.Point(478, 25);
            this.lbPresets.Name = "lbPresets";
            this.lbPresets.ScrollAlwaysVisible = true;
            this.lbPresets.Size = new System.Drawing.Size(172, 174);
            this.lbPresets.TabIndex = 11;
            this.lbPresets.SelectedIndexChanged += new System.EventHandler(this.lbPresets_SelectedIndexChanged);
            this.lbPresets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPresets_KeyDown);
            // 
            // tbPreset
            // 
            this.tbPreset.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreset.Location = new System.Drawing.Point(15, 78);
            this.tbPreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPreset.Multiline = true;
            this.tbPreset.Name = "tbPreset";
            this.tbPreset.Size = new System.Drawing.Size(441, 234);
            this.tbPreset.TabIndex = 10;
            this.tbPreset.TextChanged += new System.EventHandler(this.tbPreset_TextChanged);
            this.tbPreset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPreset_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "FFmpeg Encoding Command";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.btnVideoToPngStart);
            this.tabPage1.Controls.Add(this.btnVideoToPngOutputLocation);
            this.tabPage1.Controls.Add(this.tbVideoToPngVideoOutput);
            this.tabPage1.Controls.Add(this.tbVideoToPngVideoInput);
            this.tabPage1.Controls.Add(this.tbPngDimension);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnVideoToPngVideoLocation);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(657, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video to png";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FFUpscalerHelper.Properties.Resources.fc;
            this.pictureBox2.Location = new System.Drawing.Point(468, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // btnVideoToPngStart
            // 
            this.btnVideoToPngStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoToPngStart.Location = new System.Drawing.Point(231, 241);
            this.btnVideoToPngStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVideoToPngStart.Name = "btnVideoToPngStart";
            this.btnVideoToPngStart.Size = new System.Drawing.Size(88, 34);
            this.btnVideoToPngStart.TabIndex = 17;
            this.btnVideoToPngStart.Text = "Start";
            this.btnVideoToPngStart.UseVisualStyleBackColor = true;
            this.btnVideoToPngStart.Click += new System.EventHandler(this.btnVideoToPngStart_Click);
            // 
            // btnVideoToPngOutputLocation
            // 
            this.btnVideoToPngOutputLocation.Location = new System.Drawing.Point(384, 124);
            this.btnVideoToPngOutputLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVideoToPngOutputLocation.Name = "btnVideoToPngOutputLocation";
            this.btnVideoToPngOutputLocation.Size = new System.Drawing.Size(26, 24);
            this.btnVideoToPngOutputLocation.TabIndex = 16;
            this.btnVideoToPngOutputLocation.Text = "...";
            this.btnVideoToPngOutputLocation.UseVisualStyleBackColor = true;
            this.btnVideoToPngOutputLocation.Click += new System.EventHandler(this.btnVideoToPngOutputLocation_Click);
            // 
            // tbVideoToPngVideoOutput
            // 
            this.tbVideoToPngVideoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideoToPngVideoOutput.Location = new System.Drawing.Point(170, 124);
            this.tbVideoToPngVideoOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVideoToPngVideoOutput.Name = "tbVideoToPngVideoOutput";
            this.tbVideoToPngVideoOutput.Size = new System.Drawing.Size(210, 24);
            this.tbVideoToPngVideoOutput.TabIndex = 15;
            // 
            // tbVideoToPngVideoInput
            // 
            this.tbVideoToPngVideoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVideoToPngVideoInput.Location = new System.Drawing.Point(170, 65);
            this.tbVideoToPngVideoInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVideoToPngVideoInput.Name = "tbVideoToPngVideoInput";
            this.tbVideoToPngVideoInput.Size = new System.Drawing.Size(210, 24);
            this.tbVideoToPngVideoInput.TabIndex = 10;
            // 
            // tbPngDimension
            // 
            this.tbPngDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPngDimension.Location = new System.Drawing.Point(170, 186);
            this.tbPngDimension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPngDimension.Name = "tbPngDimension";
            this.tbPngDimension.Size = new System.Drawing.Size(210, 24);
            this.tbPngDimension.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Output Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Png Dimension";
            // 
            // btnVideoToPngVideoLocation
            // 
            this.btnVideoToPngVideoLocation.Location = new System.Drawing.Point(384, 65);
            this.btnVideoToPngVideoLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVideoToPngVideoLocation.Name = "btnVideoToPngVideoLocation";
            this.btnVideoToPngVideoLocation.Size = new System.Drawing.Size(26, 24);
            this.btnVideoToPngVideoLocation.TabIndex = 12;
            this.btnVideoToPngVideoLocation.Text = "...";
            this.btnVideoToPngVideoLocation.UseVisualStyleBackColor = true;
            this.btnVideoToPngVideoLocation.Click += new System.EventHandler(this.btnVideoToPngVideoLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Video Location";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblPresetName);
            this.tabPage3.Controls.Add(this.tbPresetName);
            this.tabPage3.Controls.Add(this.btnRename);
            this.tabPage3.Controls.Add(this.btnCreateNewPreset);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnSavePreset);
            this.tabPage3.Controls.Add(this.btnDeletePreset);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lbPresets);
            this.tabPage3.Controls.Add(this.tbPreset);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(657, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Encoding Presets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnEncodeVideoStart);
            this.tabPage2.Controls.Add(this.btnEncodeVideoOutputLocation);
            this.tabPage2.Controls.Add(this.tbEncodeVideoOutputLocation);
            this.tabPage2.Controls.Add(this.tbEncodeVideoPngFramesLocation);
            this.tabPage2.Controls.Add(this.tbEncodeVideoFilename);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnEncodeVideoPngFramesLocation);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(657, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encode png frames to video";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FFUpscalerHelper.Properties.Resources.fc;
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnEncodeVideoStart
            // 
            this.btnEncodeVideoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncodeVideoStart.Location = new System.Drawing.Point(231, 241);
            this.btnEncodeVideoStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncodeVideoStart.Name = "btnEncodeVideoStart";
            this.btnEncodeVideoStart.Size = new System.Drawing.Size(88, 34);
            this.btnEncodeVideoStart.TabIndex = 34;
            this.btnEncodeVideoStart.Text = "Start";
            this.btnEncodeVideoStart.UseVisualStyleBackColor = true;
            this.btnEncodeVideoStart.Click += new System.EventHandler(this.btnEncodeVideoStart_Click);
            // 
            // btnEncodeVideoOutputLocation
            // 
            this.btnEncodeVideoOutputLocation.Location = new System.Drawing.Point(384, 124);
            this.btnEncodeVideoOutputLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncodeVideoOutputLocation.Name = "btnEncodeVideoOutputLocation";
            this.btnEncodeVideoOutputLocation.Size = new System.Drawing.Size(26, 24);
            this.btnEncodeVideoOutputLocation.TabIndex = 33;
            this.btnEncodeVideoOutputLocation.Text = "...";
            this.btnEncodeVideoOutputLocation.UseVisualStyleBackColor = true;
            this.btnEncodeVideoOutputLocation.Click += new System.EventHandler(this.btnEncodeVideoOutputLocation_Click);
            // 
            // tbEncodeVideoOutputLocation
            // 
            this.tbEncodeVideoOutputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEncodeVideoOutputLocation.Location = new System.Drawing.Point(170, 124);
            this.tbEncodeVideoOutputLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEncodeVideoOutputLocation.Name = "tbEncodeVideoOutputLocation";
            this.tbEncodeVideoOutputLocation.Size = new System.Drawing.Size(210, 24);
            this.tbEncodeVideoOutputLocation.TabIndex = 32;
            // 
            // tbEncodeVideoPngFramesLocation
            // 
            this.tbEncodeVideoPngFramesLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEncodeVideoPngFramesLocation.Location = new System.Drawing.Point(170, 65);
            this.tbEncodeVideoPngFramesLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEncodeVideoPngFramesLocation.Name = "tbEncodeVideoPngFramesLocation";
            this.tbEncodeVideoPngFramesLocation.Size = new System.Drawing.Size(210, 24);
            this.tbEncodeVideoPngFramesLocation.TabIndex = 27;
            // 
            // tbEncodeVideoFilename
            // 
            this.tbEncodeVideoFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEncodeVideoFilename.Location = new System.Drawing.Point(170, 186);
            this.tbEncodeVideoFilename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEncodeVideoFilename.Name = "tbEncodeVideoFilename";
            this.tbEncodeVideoFilename.Size = new System.Drawing.Size(210, 24);
            this.tbEncodeVideoFilename.TabIndex = 26;
            this.tbEncodeVideoFilename.Text = "OutputVideo.mkv";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(166, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Output Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(166, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Filename";
            // 
            // btnEncodeVideoPngFramesLocation
            // 
            this.btnEncodeVideoPngFramesLocation.Location = new System.Drawing.Point(384, 65);
            this.btnEncodeVideoPngFramesLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncodeVideoPngFramesLocation.Name = "btnEncodeVideoPngFramesLocation";
            this.btnEncodeVideoPngFramesLocation.Size = new System.Drawing.Size(26, 24);
            this.btnEncodeVideoPngFramesLocation.TabIndex = 29;
            this.btnEncodeVideoPngFramesLocation.Text = "...";
            this.btnEncodeVideoPngFramesLocation.UseVisualStyleBackColor = true;
            this.btnEncodeVideoPngFramesLocation.Click += new System.EventHandler(this.btnEncodeVideoPngFramesLocation_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(166, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Png Frames Location";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Controls.Add(this.tabPage3);
            this.tabCtrl.Controls.Add(this.tabPage4);
            this.tabCtrl.Location = new System.Drawing.Point(6, 2);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(665, 346);
            this.tabCtrl.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox3);
            this.tabPage4.Controls.Add(this.cbOpenOutputFolder);
            this.tabPage4.Controls.Add(this.btnSettingsSave);
            this.tabPage4.Controls.Add(this.tbSettingsExeLocation);
            this.tabPage4.Controls.Add(this.btnSettingsExeLocation);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.tbSettingsDimensionsPng);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(657, 320);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FFUpscalerHelper.Properties.Resources.fc;
            this.pictureBox3.Location = new System.Drawing.Point(468, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // cbOpenOutputFolder
            // 
            this.cbOpenOutputFolder.AutoSize = true;
            this.cbOpenOutputFolder.Checked = true;
            this.cbOpenOutputFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpenOutputFolder.Location = new System.Drawing.Point(170, 164);
            this.cbOpenOutputFolder.Name = "cbOpenOutputFolder";
            this.cbOpenOutputFolder.Size = new System.Drawing.Size(272, 24);
            this.cbOpenOutputFolder.TabIndex = 52;
            this.cbOpenOutputFolder.Text = "Open output folder after command";
            this.cbOpenOutputFolder.UseVisualStyleBackColor = true;
            this.cbOpenOutputFolder.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Enabled = false;
            this.btnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsSave.Location = new System.Drawing.Point(218, 210);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(120, 41);
            this.btnSettingsSave.TabIndex = 49;
            this.btnSettingsSave.Text = "Save settings";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // tbSettingsExeLocation
            // 
            this.tbSettingsExeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsExeLocation.Location = new System.Drawing.Point(170, 65);
            this.tbSettingsExeLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSettingsExeLocation.Name = "tbSettingsExeLocation";
            this.tbSettingsExeLocation.Size = new System.Drawing.Size(210, 24);
            this.tbSettingsExeLocation.TabIndex = 43;
            this.tbSettingsExeLocation.TextChanged += new System.EventHandler(this.tbSettingsExeLocation_TextChanged);
            // 
            // btnSettingsExeLocation
            // 
            this.btnSettingsExeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSettingsExeLocation.Location = new System.Drawing.Point(384, 65);
            this.btnSettingsExeLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettingsExeLocation.Name = "btnSettingsExeLocation";
            this.btnSettingsExeLocation.Size = new System.Drawing.Size(26, 24);
            this.btnSettingsExeLocation.TabIndex = 45;
            this.btnSettingsExeLocation.Text = "...";
            this.btnSettingsExeLocation.UseVisualStyleBackColor = true;
            this.btnSettingsExeLocation.Click += new System.EventHandler(this.btnSettingsExeLocation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "ffmpeg.exe Location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(166, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Default Png Dimension";
            // 
            // tbSettingsDimensionsPng
            // 
            this.tbSettingsDimensionsPng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSettingsDimensionsPng.Location = new System.Drawing.Point(170, 124);
            this.tbSettingsDimensionsPng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSettingsDimensionsPng.Name = "tbSettingsDimensionsPng";
            this.tbSettingsDimensionsPng.Size = new System.Drawing.Size(210, 24);
            this.tbSettingsDimensionsPng.TabIndex = 26;
            this.tbSettingsDimensionsPng.TextChanged += new System.EventHandler(this.tbSettingsDimensionsPng_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 343);
            this.Controls.Add(this.tabCtrl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(690, 382);
            this.MinimumSize = new System.Drawing.Size(690, 382);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpeg Upscaling Helper [v2.00] [FC]";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPresetName;
        private System.Windows.Forms.TextBox tbPresetName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnCreateNewPreset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSavePreset;
        private System.Windows.Forms.Button btnDeletePreset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbPresets;
        private System.Windows.Forms.TextBox tbPreset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnVideoToPngStart;
        private System.Windows.Forms.Button btnVideoToPngOutputLocation;
        private System.Windows.Forms.TextBox tbVideoToPngVideoOutput;
        private System.Windows.Forms.TextBox tbVideoToPngVideoInput;
        private System.Windows.Forms.TextBox tbPngDimension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVideoToPngVideoLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEncodeVideoStart;
        private System.Windows.Forms.Button btnEncodeVideoOutputLocation;
        private System.Windows.Forms.TextBox tbEncodeVideoOutputLocation;
        private System.Windows.Forms.TextBox tbEncodeVideoPngFramesLocation;
        private System.Windows.Forms.TextBox tbEncodeVideoFilename;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEncodeVideoPngFramesLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbOpenOutputFolder;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.TextBox tbSettingsExeLocation;
        private System.Windows.Forms.Button btnSettingsExeLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSettingsDimensionsPng;
    }
}

