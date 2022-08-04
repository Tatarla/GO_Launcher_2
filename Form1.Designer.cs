namespace GOR_Launcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addLinksPanel = new System.Windows.Forms.Panel();
            this.websiteLink = new FontAwesome.Sharp.IconButton();
            this.discordButton = new FontAwesome.Sharp.IconButton();
            this.mainToolBox = new System.Windows.Forms.Panel();
            this.addFilesButton = new FontAwesome.Sharp.IconButton();
            this.onlineCounter = new System.Windows.Forms.Label();
            this.onlineCounterIcon = new FontAwesome.Sharp.IconPictureBox();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsBanner = new System.Windows.Forms.PictureBox();
            this.serverStatusPanel = new System.Windows.Forms.Panel();
            this.serverStatusIcon = new FontAwesome.Sharp.IconPictureBox();
            this.serverStatusText = new System.Windows.Forms.Label();
            this.mainProgressLabel = new System.Windows.Forms.Label();
            this.nicknameBox = new MetroFramework.Controls.MetroTextBox();
            this.mainProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.playButton = new MetroFramework.Controls.MetroButton();
            this.addLinksPanel.SuspendLayout();
            this.mainToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).BeginInit();
            this.newsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsBanner)).BeginInit();
            this.serverStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // addLinksPanel
            // 
            this.addLinksPanel.BackColor = System.Drawing.Color.Black;
            this.addLinksPanel.Controls.Add(this.websiteLink);
            this.addLinksPanel.Controls.Add(this.discordButton);
            this.addLinksPanel.Location = new System.Drawing.Point(750, 25);
            this.addLinksPanel.Name = "addLinksPanel";
            this.addLinksPanel.Size = new System.Drawing.Size(50, 425);
            this.addLinksPanel.TabIndex = 0;
            // 
            // websiteLink
            // 
            this.websiteLink.BackColor = System.Drawing.Color.Transparent;
            this.websiteLink.FlatAppearance.BorderSize = 0;
            this.websiteLink.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.websiteLink.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.websiteLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteLink.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.websiteLink.IconColor = System.Drawing.Color.White;
            this.websiteLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.websiteLink.IconSize = 50;
            this.websiteLink.Location = new System.Drawing.Point(0, 62);
            this.websiteLink.Name = "websiteLink";
            this.websiteLink.Size = new System.Drawing.Size(50, 50);
            this.websiteLink.TabIndex = 4;
            this.websiteLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.websiteLink.UseVisualStyleBackColor = false;
            this.websiteLink.Click += new System.EventHandler(this.websiteLink_Click);
            // 
            // discordButton
            // 
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.FlatAppearance.BorderSize = 0;
            this.discordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.discordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordButton.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.discordButton.IconColor = System.Drawing.Color.White;
            this.discordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.discordButton.IconSize = 50;
            this.discordButton.Location = new System.Drawing.Point(0, 6);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(50, 50);
            this.discordButton.TabIndex = 3;
            this.discordButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.discordButton.UseVisualStyleBackColor = false;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // mainToolBox
            // 
            this.mainToolBox.BackColor = System.Drawing.Color.Black;
            this.mainToolBox.Controls.Add(this.addFilesButton);
            this.mainToolBox.Controls.Add(this.onlineCounter);
            this.mainToolBox.Controls.Add(this.onlineCounterIcon);
            this.mainToolBox.Controls.Add(this.settingsButton);
            this.mainToolBox.Controls.Add(this.minimizeButton);
            this.mainToolBox.Controls.Add(this.closeButton);
            this.mainToolBox.Location = new System.Drawing.Point(0, 0);
            this.mainToolBox.Name = "mainToolBox";
            this.mainToolBox.Size = new System.Drawing.Size(800, 25);
            this.mainToolBox.TabIndex = 1;
            this.mainToolBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseDown);
            this.mainToolBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseMove);
            this.mainToolBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseUp);
            // 
            // addFilesButton
            // 
            this.addFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.addFilesButton.FlatAppearance.BorderSize = 0;
            this.addFilesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addFilesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFilesButton.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.addFilesButton.IconColor = System.Drawing.Color.White;
            this.addFilesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addFilesButton.IconSize = 25;
            this.addFilesButton.Location = new System.Drawing.Point(706, 0);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(25, 25);
            this.addFilesButton.TabIndex = 11;
            this.addFilesButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addFilesButton.UseVisualStyleBackColor = false;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // onlineCounter
            // 
            this.onlineCounter.AutoSize = true;
            this.onlineCounter.ForeColor = System.Drawing.Color.White;
            this.onlineCounter.Location = new System.Drawing.Point(26, 5);
            this.onlineCounter.Name = "onlineCounter";
            this.onlineCounter.Size = new System.Drawing.Size(0, 13);
            this.onlineCounter.TabIndex = 8;
            // 
            // onlineCounterIcon
            // 
            this.onlineCounterIcon.BackColor = System.Drawing.Color.Transparent;
            this.onlineCounterIcon.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.onlineCounterIcon.IconColor = System.Drawing.Color.White;
            this.onlineCounterIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.onlineCounterIcon.IconSize = 25;
            this.onlineCounterIcon.Location = new System.Drawing.Point(0, 0);
            this.onlineCounterIcon.Name = "onlineCounterIcon";
            this.onlineCounterIcon.Size = new System.Drawing.Size(25, 25);
            this.onlineCounterIcon.TabIndex = 10;
            this.onlineCounterIcon.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 25;
            this.settingsButton.Location = new System.Drawing.Point(729, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(25, 25);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 30;
            this.minimizeButton.Location = new System.Drawing.Point(750, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 25;
            this.closeButton.Location = new System.Drawing.Point(775, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newsPanel
            // 
            this.newsPanel.Controls.Add(this.newsBanner);
            this.newsPanel.Location = new System.Drawing.Point(12, 37);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(300, 360);
            this.newsPanel.TabIndex = 3;
            this.newsPanel.Visible = false;
            // 
            // newsBanner
            // 
            this.newsBanner.Location = new System.Drawing.Point(0, 0);
            this.newsBanner.Name = "newsBanner";
            this.newsBanner.Size = new System.Drawing.Size(300, 360);
            this.newsBanner.TabIndex = 10;
            this.newsBanner.TabStop = false;
            this.newsBanner.Visible = false;
            // 
            // serverStatusPanel
            // 
            this.serverStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusPanel.Controls.Add(this.serverStatusIcon);
            this.serverStatusPanel.Controls.Add(this.serverStatusText);
            this.serverStatusPanel.Location = new System.Drawing.Point(349, 37);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(395, 35);
            this.serverStatusPanel.TabIndex = 9;
            // 
            // serverStatusIcon
            // 
            this.serverStatusIcon.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusIcon.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.serverStatusIcon.IconColor = System.Drawing.Color.White;
            this.serverStatusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serverStatusIcon.IconSize = 35;
            this.serverStatusIcon.Location = new System.Drawing.Point(19, 2);
            this.serverStatusIcon.Name = "serverStatusIcon";
            this.serverStatusIcon.Size = new System.Drawing.Size(35, 35);
            this.serverStatusIcon.TabIndex = 10;
            this.serverStatusIcon.TabStop = false;
            // 
            // serverStatusText
            // 
            this.serverStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverStatusText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serverStatusText.Location = new System.Drawing.Point(0, 0);
            this.serverStatusText.Name = "serverStatusText";
            this.serverStatusText.Size = new System.Drawing.Size(395, 35);
            this.serverStatusText.TabIndex = 1;
            this.serverStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainProgressLabel
            // 
            this.mainProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainProgressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProgressLabel.ForeColor = System.Drawing.Color.White;
            this.mainProgressLabel.Location = new System.Drawing.Point(12, 413);
            this.mainProgressLabel.Name = "mainProgressLabel";
            this.mainProgressLabel.Size = new System.Drawing.Size(510, 20);
            this.mainProgressLabel.TabIndex = 10;
            // 
            // nicknameBox
            // 
            // 
            // 
            // 
            this.nicknameBox.CustomButton.Image = null;
            this.nicknameBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.nicknameBox.CustomButton.Name = "";
            this.nicknameBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nicknameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nicknameBox.CustomButton.TabIndex = 1;
            this.nicknameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nicknameBox.CustomButton.UseSelectable = true;
            this.nicknameBox.CustomButton.Visible = false;
            this.nicknameBox.DisplayIcon = true;
            this.nicknameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nicknameBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.nicknameBox.Lines = new string[0];
            this.nicknameBox.Location = new System.Drawing.Point(537, 338);
            this.nicknameBox.MaxLength = 24;
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.PasswordChar = '\0';
            this.nicknameBox.PromptText = "Nickname";
            this.nicknameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nicknameBox.SelectedText = "";
            this.nicknameBox.SelectionLength = 0;
            this.nicknameBox.SelectionStart = 0;
            this.nicknameBox.ShortcutsEnabled = true;
            this.nicknameBox.Size = new System.Drawing.Size(200, 25);
            this.nicknameBox.TabIndex = 11;
            this.nicknameBox.UseSelectable = true;
            this.nicknameBox.WaterMark = "Nickname";
            this.nicknameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nicknameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nicknameBox.TextChanged += new System.EventHandler(this.nicknameBox_TextChanged);
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Depth = 0;
            this.mainProgressBar.Location = new System.Drawing.Point(12, 433);
            this.mainProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(725, 5);
            this.mainProgressBar.TabIndex = 13;
            this.mainProgressBar.Value = 50;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Coral;
            this.playButton.DisplayFocus = true;
            this.playButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.playButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.playButton.Highlight = true;
            this.playButton.Location = new System.Drawing.Point(537, 369);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 48);
            this.playButton.Style = MetroFramework.MetroColorStyle.White;
            this.playButton.TabIndex = 14;
            this.playButton.Text = "Play";
            this.playButton.UseCustomBackColor = true;
            this.playButton.UseSelectable = true;
            this.playButton.UseStyleColors = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.nicknameBox);
            this.Controls.Add(this.mainProgressLabel);
            this.Controls.Add(this.serverStatusPanel);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.mainToolBox);
            this.Controls.Add(this.addLinksPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gothic Online: ARPG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addLinksPanel.ResumeLayout(false);
            this.mainToolBox.ResumeLayout(false);
            this.mainToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).EndInit();
            this.newsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsBanner)).EndInit();
            this.serverStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addLinksPanel;
        private System.Windows.Forms.Panel mainToolBox;
        private FontAwesome.Sharp.IconButton discordButton;
        private FontAwesome.Sharp.IconButton websiteLink;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Label onlineCounter;
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label serverStatusText;
        private FontAwesome.Sharp.IconPictureBox serverStatusIcon;
        private FontAwesome.Sharp.IconPictureBox onlineCounterIcon;
        private System.Windows.Forms.PictureBox newsBanner;
        private System.Windows.Forms.Label mainProgressLabel;
        private FontAwesome.Sharp.IconButton addFilesButton;
        private MetroFramework.Controls.MetroTextBox nicknameBox;
        private MaterialSkin.Controls.MaterialProgressBar mainProgressBar;
        private MetroFramework.Controls.MetroButton playButton;
    }
}

