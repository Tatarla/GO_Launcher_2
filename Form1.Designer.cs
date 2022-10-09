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
            this.serverStatusPanel = new System.Windows.Forms.Panel();
            this.serverStatusText = new System.Windows.Forms.Label();
            this.serverStatusIcon = new FontAwesome.Sharp.IconPictureBox();
            this.mainProgressLabel = new System.Windows.Forms.Label();
            this.nicknameBox = new MetroFramework.Controls.MetroTextBox();
            this.mainProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.addLinksPanel = new System.Windows.Forms.Panel();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.onlineCounterIcon = new FontAwesome.Sharp.IconPictureBox();
            this.onlineCounter = new System.Windows.Forms.Label();
            this.discordButton = new FontAwesome.Sharp.IconButton();
            this.addFilesButton = new FontAwesome.Sharp.IconButton();
            this.websiteLink = new FontAwesome.Sharp.IconButton();
            this.mainToolBox = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsBanner = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.serverStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).BeginInit();
            this.mainToolBox.SuspendLayout();
            this.newsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // serverStatusPanel
            // 
            this.serverStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusPanel.Controls.Add(this.serverStatusText);
            this.serverStatusPanel.Controls.Add(this.serverStatusIcon);
            this.serverStatusPanel.Location = new System.Drawing.Point(632, 73);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(102, 10);
            this.serverStatusPanel.TabIndex = 9;
            this.serverStatusPanel.Visible = false;
            // 
            // serverStatusText
            // 
            this.serverStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverStatusText.Font = new System.Drawing.Font("Red October", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverStatusText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serverStatusText.Location = new System.Drawing.Point(0, 0);
            this.serverStatusText.Name = "serverStatusText";
            this.serverStatusText.Size = new System.Drawing.Size(102, 10);
            this.serverStatusText.TabIndex = 1;
            this.serverStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverStatusIcon
            // 
            this.serverStatusIcon.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusIcon.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.serverStatusIcon.IconColor = System.Drawing.Color.White;
            this.serverStatusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serverStatusIcon.IconSize = 35;
            this.serverStatusIcon.Location = new System.Drawing.Point(3, 0);
            this.serverStatusIcon.Name = "serverStatusIcon";
            this.serverStatusIcon.Size = new System.Drawing.Size(35, 35);
            this.serverStatusIcon.TabIndex = 10;
            this.serverStatusIcon.TabStop = false;
            // 
            // mainProgressLabel
            // 
            this.mainProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainProgressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainProgressLabel.Font = new System.Drawing.Font("Red October", 8.25F);
            this.mainProgressLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainProgressLabel.Location = new System.Drawing.Point(12, 376);
            this.mainProgressLabel.Name = "mainProgressLabel";
            this.mainProgressLabel.Size = new System.Drawing.Size(449, 30);
            this.mainProgressLabel.TabIndex = 10;
            // 
            // nicknameBox
            // 
            this.nicknameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            // 
            // 
            // 
            this.nicknameBox.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameBox.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nicknameBox.CustomButton.Image = null;
            this.nicknameBox.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.nicknameBox.CustomButton.Name = "";
            this.nicknameBox.CustomButton.Size = new System.Drawing.Size(17, 20);
            this.nicknameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nicknameBox.CustomButton.TabIndex = 1;
            this.nicknameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nicknameBox.CustomButton.UseSelectable = true;
            this.nicknameBox.CustomButton.Visible = false;
            this.nicknameBox.DisplayIcon = true;
            this.nicknameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nicknameBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.nicknameBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nicknameBox.Lines = new string[0];
            this.nicknameBox.Location = new System.Drawing.Point(559, 9);
            this.nicknameBox.MaxLength = 24;
            this.nicknameBox.Name = "nicknameBox";
            this.nicknameBox.PasswordChar = '\0';
            this.nicknameBox.PromptText = "Nickname";
            this.nicknameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nicknameBox.SelectedText = "";
            this.nicknameBox.SelectionLength = 0;
            this.nicknameBox.SelectionStart = 0;
            this.nicknameBox.ShortcutsEnabled = true;
            this.nicknameBox.Size = new System.Drawing.Size(108, 25);
            this.nicknameBox.TabIndex = 11;
            this.nicknameBox.UseCustomBackColor = true;
            this.nicknameBox.UseCustomForeColor = true;
            this.nicknameBox.UseSelectable = true;
            this.nicknameBox.WaterMark = "Nickname";
            this.nicknameBox.WaterMarkColor = System.Drawing.Color.WhiteSmoke;
            this.nicknameBox.WaterMarkFont = new System.Drawing.Font("Red October", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nicknameBox.TextChanged += new System.EventHandler(this.nicknameBox_TextChanged);
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainProgressBar.Depth = 0;
            this.mainProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.mainProgressBar.Location = new System.Drawing.Point(12, 401);
            this.mainProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(722, 5);
            this.mainProgressBar.TabIndex = 13;
            this.mainProgressBar.Value = 50;
            // 
            // addLinksPanel
            // 
            this.addLinksPanel.BackColor = System.Drawing.Color.Transparent;
            this.addLinksPanel.Location = new System.Drawing.Point(745, 29);
            this.addLinksPanel.Name = "addLinksPanel";
            this.addLinksPanel.Size = new System.Drawing.Size(49, 127);
            this.addLinksPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 24;
            this.closeButton.Location = new System.Drawing.Point(709, 6);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 26;
            this.minimizeButton.Location = new System.Drawing.Point(673, 6);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.settingsButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 25;
            this.settingsButton.Location = new System.Drawing.Point(487, 6);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 30);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // onlineCounterIcon
            // 
            this.onlineCounterIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.onlineCounterIcon.ForeColor = System.Drawing.SystemColors.Window;
            this.onlineCounterIcon.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.onlineCounterIcon.IconColor = System.Drawing.SystemColors.Window;
            this.onlineCounterIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.onlineCounterIcon.IconSize = 30;
            this.onlineCounterIcon.Location = new System.Drawing.Point(12, 9);
            this.onlineCounterIcon.Name = "onlineCounterIcon";
            this.onlineCounterIcon.Size = new System.Drawing.Size(30, 30);
            this.onlineCounterIcon.TabIndex = 10;
            this.onlineCounterIcon.TabStop = false;
            // 
            // onlineCounter
            // 
            this.onlineCounter.AutoSize = true;
            this.onlineCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.onlineCounter.Font = new System.Drawing.Font("Red October", 8.25F);
            this.onlineCounter.ForeColor = System.Drawing.Color.Transparent;
            this.onlineCounter.Location = new System.Drawing.Point(48, 9);
            this.onlineCounter.Name = "onlineCounter";
            this.onlineCounter.Size = new System.Drawing.Size(0, 15);
            this.onlineCounter.TabIndex = 8;
            // 
            // discordButton
            // 
            this.discordButton.BackColor = System.Drawing.Color.Transparent;
            this.discordButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.discordButton.FlatAppearance.BorderSize = 0;
            this.discordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.discordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(217)))));
            this.discordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discordButton.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.discordButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.discordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.discordButton.IconSize = 30;
            this.discordButton.Location = new System.Drawing.Point(84, 412);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(30, 30);
            this.discordButton.TabIndex = 3;
            this.discordButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.discordButton.UseVisualStyleBackColor = false;
            this.discordButton.Click += new System.EventHandler(this.discordButton_Click);
            // 
            // addFilesButton
            // 
            this.addFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.addFilesButton.FlatAppearance.BorderSize = 0;
            this.addFilesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addFilesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFilesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addFilesButton.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.addFilesButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.addFilesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addFilesButton.IconSize = 25;
            this.addFilesButton.Location = new System.Drawing.Point(523, 6);
            this.addFilesButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(30, 30);
            this.addFilesButton.TabIndex = 11;
            this.addFilesButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.addFilesButton.UseVisualStyleBackColor = false;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // websiteLink
            // 
            this.websiteLink.BackColor = System.Drawing.Color.Transparent;
            this.websiteLink.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.websiteLink.FlatAppearance.BorderSize = 0;
            this.websiteLink.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.websiteLink.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.websiteLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteLink.IconChar = FontAwesome.Sharp.IconChar.ShareNodes;
            this.websiteLink.IconColor = System.Drawing.Color.WhiteSmoke;
            this.websiteLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.websiteLink.IconSize = 30;
            this.websiteLink.Location = new System.Drawing.Point(12, 412);
            this.websiteLink.Name = "websiteLink";
            this.websiteLink.Size = new System.Drawing.Size(30, 30);
            this.websiteLink.TabIndex = 4;
            this.websiteLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.websiteLink.UseVisualStyleBackColor = false;
            this.websiteLink.Click += new System.EventHandler(this.websiteLink_Click);
            // 
            // mainToolBox
            // 
            this.mainToolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.mainToolBox.Controls.Add(this.settingsButton);
            this.mainToolBox.Controls.Add(this.closeButton);
            this.mainToolBox.Controls.Add(this.addFilesButton);
            this.mainToolBox.Controls.Add(this.minimizeButton);
            this.mainToolBox.Controls.Add(this.nicknameBox);
            this.mainToolBox.Location = new System.Drawing.Point(-5, 0);
            this.mainToolBox.Name = "mainToolBox";
            this.mainToolBox.Size = new System.Drawing.Size(760, 43);
            this.mainToolBox.TabIndex = 1;
            this.mainToolBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainToolBox_Paint);
            this.mainToolBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseDown);
            this.mainToolBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseMove);
            this.mainToolBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainToolBox_MouseUp);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Vk;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(48, 412);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // newsPanel
            // 
            this.newsPanel.Controls.Add(this.newsBanner);
            this.newsPanel.Location = new System.Drawing.Point(12, 37);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(300, 232);
            this.newsPanel.TabIndex = 3;
            this.newsPanel.Visible = false;
            // 
            // newsBanner
            // 
            this.newsBanner.Location = new System.Drawing.Point(0, 0);
            this.newsBanner.Name = "newsBanner";
            this.newsBanner.Size = new System.Drawing.Size(300, 231);
            this.newsBanner.TabIndex = 10;
            this.newsBanner.TabStop = false;
            this.newsBanner.Visible = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(99)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Red October", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.playButton.Location = new System.Drawing.Point(632, 412);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(102, 30);
            this.playButton.TabIndex = 18;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.ControlBox = false;
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.onlineCounterIcon);
            this.Controls.Add(this.serverStatusPanel);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.onlineCounter);
            this.Controls.Add(this.websiteLink);
            this.Controls.Add(this.discordButton);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.mainProgressLabel);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.addLinksPanel);
            this.Controls.Add(this.mainToolBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.serverStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).EndInit();
            this.mainToolBox.ResumeLayout(false);
            this.newsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label serverStatusText;
        private FontAwesome.Sharp.IconPictureBox serverStatusIcon;
        private System.Windows.Forms.Label mainProgressLabel;
        private MetroFramework.Controls.MetroTextBox nicknameBox;
        private MaterialSkin.Controls.MaterialProgressBar mainProgressBar;
        private System.Windows.Forms.Panel addLinksPanel;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.Label onlineCounter;
        private FontAwesome.Sharp.IconButton discordButton;
        private FontAwesome.Sharp.IconButton addFilesButton;
        private FontAwesome.Sharp.IconButton websiteLink;
        private System.Windows.Forms.Panel mainToolBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.PictureBox newsBanner;
        private FontAwesome.Sharp.IconPictureBox onlineCounterIcon;
        private System.Windows.Forms.Button playButton;
    }
}

