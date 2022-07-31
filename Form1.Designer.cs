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
            this.onlineCounter = new System.Windows.Forms.Label();
            this.onlineCounterIcon = new FontAwesome.Sharp.IconPictureBox();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.mainProgressBar = new XanderUI.XUIFlatProgressBar();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.playButton = new XanderUI.XUIButton();
            this.nicknameInput = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.serverStatusPanel = new System.Windows.Forms.Panel();
            this.serrverStatusIcon = new FontAwesome.Sharp.IconPictureBox();
            this.serverStatusText = new System.Windows.Forms.Label();
            this.addLinksPanel.SuspendLayout();
            this.mainToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).BeginInit();
            this.serverStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serrverStatusIcon)).BeginInit();
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
            this.websiteLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.websiteLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.websiteLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.websiteLink.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.websiteLink.IconColor = System.Drawing.Color.White;
            this.websiteLink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.websiteLink.IconSize = 50;
            this.websiteLink.Location = new System.Drawing.Point(0, 62);
            this.websiteLink.Name = "websiteLink";
            this.websiteLink.Size = new System.Drawing.Size(50, 50);
            this.websiteLink.TabIndex = 4;
            this.websiteLink.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.websiteLink.UseVisualStyleBackColor = false;
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
            // 
            // mainToolBox
            // 
            this.mainToolBox.BackColor = System.Drawing.Color.Black;
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
            // onlineCounter
            // 
            this.onlineCounter.AutoSize = true;
            this.onlineCounter.Location = new System.Drawing.Point(26, 5);
            this.onlineCounter.Name = "onlineCounter";
            this.onlineCounter.Size = new System.Drawing.Size(107, 13);
            this.onlineCounter.TabIndex = 8;
            this.onlineCounter.Text = "Игроков онлайн: 56";
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
            // mainProgressBar
            // 
            this.mainProgressBar.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.mainProgressBar.BorderColor = System.Drawing.Color.Black;
            this.mainProgressBar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.mainProgressBar.InocmpletedColor = System.Drawing.Color.White;
            this.mainProgressBar.Location = new System.Drawing.Point(12, 433);
            this.mainProgressBar.MaxValue = 100;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.ShowBorder = true;
            this.mainProgressBar.Size = new System.Drawing.Size(725, 5);
            this.mainProgressBar.TabIndex = 2;
            this.mainProgressBar.Text = "xuiFlatProgressBar1";
            this.mainProgressBar.Value = 50;
            // 
            // newsPanel
            // 
            this.newsPanel.Location = new System.Drawing.Point(12, 37);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(317, 380);
            this.newsPanel.TabIndex = 3;
            // 
            // playButton
            // 
            this.playButton.BackgroundColor = System.Drawing.Color.White;
            this.playButton.ButtonImage = null;
            this.playButton.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.playButton.ButtonText = "Играть";
            this.playButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.playButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.playButton.CornerRadius = 5;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.playButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.playButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.playButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.playButton.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.playButton.Location = new System.Drawing.Point(537, 367);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(200, 50);
            this.playButton.TabIndex = 4;
            this.playButton.TextColor = System.Drawing.Color.Black;
            this.playButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // nicknameInput
            // 
            this.nicknameInput.Location = new System.Drawing.Point(596, 341);
            this.nicknameInput.Name = "nicknameInput";
            this.nicknameInput.Size = new System.Drawing.Size(141, 20);
            this.nicknameInput.TabIndex = 6;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Location = new System.Drawing.Point(534, 344);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(56, 13);
            this.nicknameLabel.TabIndex = 7;
            this.nicknameLabel.Text = "Никнейм:";
            // 
            // serverStatusPanel
            // 
            this.serverStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusPanel.Controls.Add(this.serrverStatusIcon);
            this.serverStatusPanel.Controls.Add(this.serverStatusText);
            this.serverStatusPanel.Location = new System.Drawing.Point(349, 37);
            this.serverStatusPanel.Name = "serverStatusPanel";
            this.serverStatusPanel.Size = new System.Drawing.Size(395, 35);
            this.serverStatusPanel.TabIndex = 9;
            // 
            // serrverStatusIcon
            // 
            this.serrverStatusIcon.BackColor = System.Drawing.Color.Transparent;
            this.serrverStatusIcon.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.serrverStatusIcon.IconColor = System.Drawing.Color.White;
            this.serrverStatusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serrverStatusIcon.IconSize = 35;
            this.serrverStatusIcon.Location = new System.Drawing.Point(19, 2);
            this.serrverStatusIcon.Name = "serrverStatusIcon";
            this.serrverStatusIcon.Size = new System.Drawing.Size(35, 35);
            this.serrverStatusIcon.TabIndex = 10;
            this.serrverStatusIcon.TabStop = false;
            // 
            // serverStatusText
            // 
            this.serverStatusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverStatusText.Location = new System.Drawing.Point(0, 0);
            this.serverStatusText.Name = "serverStatusText";
            this.serverStatusText.Size = new System.Drawing.Size(395, 35);
            this.serverStatusText.TabIndex = 1;
            this.serverStatusText.Text = "Сервер активен и доступен для подключения";
            this.serverStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.serverStatusPanel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nicknameInput);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.mainToolBox);
            this.Controls.Add(this.addLinksPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gothic Online: ARPG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.addLinksPanel.ResumeLayout(false);
            this.mainToolBox.ResumeLayout(false);
            this.mainToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlineCounterIcon)).EndInit();
            this.serverStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serrverStatusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel addLinksPanel;
        private System.Windows.Forms.Panel mainToolBox;
        private XanderUI.XUIFlatProgressBar mainProgressBar;
        private FontAwesome.Sharp.IconButton discordButton;
        private FontAwesome.Sharp.IconButton websiteLink;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Label onlineCounter;
        private XanderUI.XUIButton playButton;
        private System.Windows.Forms.TextBox nicknameInput;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Panel serverStatusPanel;
        private System.Windows.Forms.Label serverStatusText;
        private FontAwesome.Sharp.IconPictureBox serrverStatusIcon;
        private FontAwesome.Sharp.IconPictureBox onlineCounterIcon;
    }
}

