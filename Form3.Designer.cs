namespace GOR_Launcher
{
    partial class SettingsForm
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
            this.languageSelectBox = new MaterialSkin.Controls.MaterialComboBox();
            this.languageSelectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resolutionBoxX = new MaterialSkin.Controls.MaterialTextBox2();
            this.resolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resolutionBoxY = new MaterialSkin.Controls.MaterialTextBox2();
            this.windowedModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.windowedModeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.musicVolumeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialSlider2 = new MaterialSkin.Controls.MaterialSlider();
            this.soundVolumeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialSlider3 = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.validateFilesButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // languageSelectBox
            // 
            this.languageSelectBox.AutoResize = false;
            this.languageSelectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.languageSelectBox.Depth = 0;
            this.languageSelectBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.languageSelectBox.DropDownHeight = 118;
            this.languageSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSelectBox.DropDownWidth = 121;
            this.languageSelectBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.languageSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.languageSelectBox.IntegralHeight = false;
            this.languageSelectBox.ItemHeight = 29;
            this.languageSelectBox.Location = new System.Drawing.Point(169, 89);
            this.languageSelectBox.MaxDropDownItems = 4;
            this.languageSelectBox.MouseState = MaterialSkin.MouseState.OUT;
            this.languageSelectBox.Name = "languageSelectBox";
            this.languageSelectBox.Size = new System.Drawing.Size(190, 35);
            this.languageSelectBox.StartIndex = 0;
            this.languageSelectBox.TabIndex = 0;
            this.languageSelectBox.UseAccent = false;
            this.languageSelectBox.UseTallSize = false;
            this.languageSelectBox.SelectedIndexChanged += new System.EventHandler(this.languageSelectBox_SelectedIndexChanged);
            // 
            // languageSelectLabel
            // 
            this.languageSelectLabel.AutoSize = true;
            this.languageSelectLabel.Depth = 0;
            this.languageSelectLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.languageSelectLabel.Location = new System.Drawing.Point(16, 100);
            this.languageSelectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.languageSelectLabel.Name = "languageSelectLabel";
            this.languageSelectLabel.Size = new System.Drawing.Size(76, 19);
            this.languageSelectLabel.TabIndex = 1;
            this.languageSelectLabel.Text = "Language:";
            // 
            // resolutionBoxX
            // 
            this.resolutionBoxX.AnimateReadOnly = false;
            this.resolutionBoxX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resolutionBoxX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resolutionBoxX.Depth = 0;
            this.resolutionBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resolutionBoxX.HideSelection = true;
            this.resolutionBoxX.LeadingIcon = null;
            this.resolutionBoxX.Location = new System.Drawing.Point(169, 171);
            this.resolutionBoxX.MaxLength = 32767;
            this.resolutionBoxX.MouseState = MaterialSkin.MouseState.OUT;
            this.resolutionBoxX.Name = "resolutionBoxX";
            this.resolutionBoxX.PasswordChar = '\0';
            this.resolutionBoxX.PrefixSuffixText = null;
            this.resolutionBoxX.ReadOnly = false;
            this.resolutionBoxX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolutionBoxX.SelectedText = "";
            this.resolutionBoxX.SelectionLength = 0;
            this.resolutionBoxX.SelectionStart = 0;
            this.resolutionBoxX.ShortcutsEnabled = true;
            this.resolutionBoxX.Size = new System.Drawing.Size(90, 36);
            this.resolutionBoxX.TabIndex = 2;
            this.resolutionBoxX.TabStop = false;
            this.resolutionBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resolutionBoxX.TrailingIcon = null;
            this.resolutionBoxX.UseAccent = false;
            this.resolutionBoxX.UseSystemPasswordChar = false;
            this.resolutionBoxX.UseTallSize = false;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Depth = 0;
            this.resolutionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resolutionLabel.Location = new System.Drawing.Point(16, 182);
            this.resolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(80, 19);
            this.resolutionLabel.TabIndex = 3;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // resolutionBoxY
            // 
            this.resolutionBoxY.AnimateReadOnly = false;
            this.resolutionBoxY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resolutionBoxY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resolutionBoxY.Depth = 0;
            this.resolutionBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resolutionBoxY.HideSelection = true;
            this.resolutionBoxY.LeadingIcon = null;
            this.resolutionBoxY.Location = new System.Drawing.Point(269, 171);
            this.resolutionBoxY.MaxLength = 32767;
            this.resolutionBoxY.MouseState = MaterialSkin.MouseState.OUT;
            this.resolutionBoxY.Name = "resolutionBoxY";
            this.resolutionBoxY.PasswordChar = '\0';
            this.resolutionBoxY.PrefixSuffixText = null;
            this.resolutionBoxY.ReadOnly = false;
            this.resolutionBoxY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolutionBoxY.SelectedText = "";
            this.resolutionBoxY.SelectionLength = 0;
            this.resolutionBoxY.SelectionStart = 0;
            this.resolutionBoxY.ShortcutsEnabled = true;
            this.resolutionBoxY.Size = new System.Drawing.Size(90, 36);
            this.resolutionBoxY.TabIndex = 4;
            this.resolutionBoxY.TabStop = false;
            this.resolutionBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resolutionBoxY.TrailingIcon = null;
            this.resolutionBoxY.UseAccent = false;
            this.resolutionBoxY.UseSystemPasswordChar = false;
            this.resolutionBoxY.UseTallSize = false;
            // 
            // windowedModeSwitch
            // 
            this.windowedModeSwitch.AutoSize = true;
            this.windowedModeSwitch.Depth = 0;
            this.windowedModeSwitch.Location = new System.Drawing.Point(301, 233);
            this.windowedModeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.windowedModeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.windowedModeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowedModeSwitch.Name = "windowedModeSwitch";
            this.windowedModeSwitch.Ripple = true;
            this.windowedModeSwitch.Size = new System.Drawing.Size(58, 37);
            this.windowedModeSwitch.TabIndex = 5;
            this.windowedModeSwitch.UseVisualStyleBackColor = true;
            // 
            // windowedModeLabel
            // 
            this.windowedModeLabel.AutoSize = true;
            this.windowedModeLabel.Depth = 0;
            this.windowedModeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.windowedModeLabel.Location = new System.Drawing.Point(16, 242);
            this.windowedModeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowedModeLabel.Name = "windowedModeLabel";
            this.windowedModeLabel.Size = new System.Drawing.Size(79, 19);
            this.windowedModeLabel.TabIndex = 6;
            this.windowedModeLabel.Text = "Windowed:";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(234, 286);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.ShowText = false;
            this.materialSlider1.ShowValue = false;
            this.materialSlider1.Size = new System.Drawing.Size(125, 40);
            this.materialSlider1.TabIndex = 7;
            this.materialSlider1.Text = "materialSlider1";
            this.materialSlider1.Value = 100;
            // 
            // musicVolumeLabel
            // 
            this.musicVolumeLabel.AutoSize = true;
            this.musicVolumeLabel.Depth = 0;
            this.musicVolumeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.musicVolumeLabel.Location = new System.Drawing.Point(16, 295);
            this.musicVolumeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.musicVolumeLabel.Name = "musicVolumeLabel";
            this.musicVolumeLabel.Size = new System.Drawing.Size(104, 19);
            this.musicVolumeLabel.TabIndex = 8;
            this.musicVolumeLabel.Text = "Music volume:";
            // 
            // materialSlider2
            // 
            this.materialSlider2.Depth = 0;
            this.materialSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider2.Location = new System.Drawing.Point(234, 332);
            this.materialSlider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider2.Name = "materialSlider2";
            this.materialSlider2.ShowText = false;
            this.materialSlider2.ShowValue = false;
            this.materialSlider2.Size = new System.Drawing.Size(125, 40);
            this.materialSlider2.TabIndex = 9;
            this.materialSlider2.Text = "materialSlider2";
            this.materialSlider2.Value = 100;
            // 
            // soundVolumeLabel
            // 
            this.soundVolumeLabel.AutoSize = true;
            this.soundVolumeLabel.Depth = 0;
            this.soundVolumeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.soundVolumeLabel.Location = new System.Drawing.Point(16, 341);
            this.soundVolumeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.soundVolumeLabel.Name = "soundVolumeLabel";
            this.soundVolumeLabel.Size = new System.Drawing.Size(107, 19);
            this.soundVolumeLabel.TabIndex = 10;
            this.soundVolumeLabel.Text = "Sound volume:";
            // 
            // materialSlider3
            // 
            this.materialSlider3.Depth = 0;
            this.materialSlider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider3.Location = new System.Drawing.Point(234, 378);
            this.materialSlider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider3.Name = "materialSlider3";
            this.materialSlider3.ShowText = false;
            this.materialSlider3.ShowValue = false;
            this.materialSlider3.Size = new System.Drawing.Size(125, 40);
            this.materialSlider3.TabIndex = 11;
            this.materialSlider3.Text = "materialSlider3";
            this.materialSlider3.Value = 100;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 387);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Mouse sensitivity:";
            // 
            // validateFilesButton
            // 
            this.validateFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.validateFilesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.validateFilesButton.Depth = 0;
            this.validateFilesButton.HighEmphasis = true;
            this.validateFilesButton.Icon = null;
            this.validateFilesButton.Location = new System.Drawing.Point(106, 427);
            this.validateFilesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.validateFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.validateFilesButton.Name = "validateFilesButton";
            this.validateFilesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.validateFilesButton.Size = new System.Drawing.Size(171, 36);
            this.validateFilesButton.TabIndex = 13;
            this.validateFilesButton.Text = "Run file validation";
            this.validateFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.validateFilesButton.UseAccentColor = false;
            this.validateFilesButton.UseVisualStyleBackColor = true;
            this.validateFilesButton.Click += new System.EventHandler(this.validateFilesButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(370, 480);
            this.Controls.Add(this.validateFilesButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSlider3);
            this.Controls.Add(this.soundVolumeLabel);
            this.Controls.Add(this.materialSlider2);
            this.Controls.Add(this.musicVolumeLabel);
            this.Controls.Add(this.materialSlider1);
            this.Controls.Add(this.windowedModeLabel);
            this.Controls.Add(this.windowedModeSwitch);
            this.Controls.Add(this.resolutionBoxY);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.resolutionBoxX);
            this.Controls.Add(this.languageSelectLabel);
            this.Controls.Add(this.languageSelectBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox languageSelectBox;
        private MaterialSkin.Controls.MaterialLabel languageSelectLabel;
        private MaterialSkin.Controls.MaterialTextBox2 resolutionBoxX;
        private MaterialSkin.Controls.MaterialLabel resolutionLabel;
        private MaterialSkin.Controls.MaterialTextBox2 resolutionBoxY;
        private MaterialSkin.Controls.MaterialSwitch windowedModeSwitch;
        private MaterialSkin.Controls.MaterialLabel windowedModeLabel;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialLabel musicVolumeLabel;
        private MaterialSkin.Controls.MaterialSlider materialSlider2;
        private MaterialSkin.Controls.MaterialLabel soundVolumeLabel;
        private MaterialSkin.Controls.MaterialSlider materialSlider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton validateFilesButton;
    }
}