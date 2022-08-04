using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using System.IO;

namespace GOR_Launcher
{
    public partial class MainForm : Form
    {
        [DllImport("G2O_Proxy.dll")]
        public extern static int G2O_Run(int major, int minor, int build);

        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        public MainForm()
        {
            InitializeComponent();
            themeManager.ColorScheme = Constants.MATERIAL_DEFAULT_COLOR;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            playButton.Enabled = false;

            // Initializing default language
            CConfig.Initialize();

            if (!CGameConfig.Initialize()) Close();
            if (!File.Exists(Constants.GAME_EXEC) || !File.Exists(Constants.G2O_EXEC))
            {
                MessageBox.Show("Can't find game executable file!\nPlease, put this launcher in the root folder of your Gothic 2: Night of the Raven game.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            CLocalization.Initialize();
            CLocalization.UpdateMainForm(this);

            var _ = CFileValidation.Initialize(this);

            // Initializing panel colors with alpha channel
            addLinksPanel.BackColor          = Constants.LINKS_PANEL_COLOR;
            newsPanel.BackColor              = Constants.NEWS_PANEL_COLOR;
            playButton.BackColor             = Constants.PLAY_BUTTON_COLOR;

            nicknameBox.Text = CConfig.GetPlayerName();

            Translate();
        }

        public void Translate()
        {
            playButton.Text         = CLocalization.Get("playButton");

            //For some fckn reason WaterMark by itself doesn't show up hint, neither PromptText, but together they do :?
            nicknameBox.WaterMark   = CLocalization.Get("nicknameInput");
            nicknameBox.PromptText  = CLocalization.Get("nicknameInput");

            onlineCounter.Text = string.Format("{0} {1}", CLocalization.Get("onlinePlayers"), CConfig.GetOnlinePlayers());

            UpdateServerStatus();
        }

        public void SetProgressLabel(string text)
        {
            mainProgressLabel.Text = text;
        }

        public void SetProgressBar(int value)
        {
            value = value > 100 ? 100 : value;
            value = value < 0 ? 0 : value;
            mainProgressBar.Value = value;
        }

        public int GetProgressBar()
        {
            return mainProgressBar.Value;
        }

        public void SetPlayButton(bool value)
        {
            if (value == true)
            {
                if (CConfig.IsConnectionAvailable())
                {
                    playButton.Enabled = value;
                }
            }
            else
                playButton.Enabled = value;
        }

        public void UpdateServerStatus()
        {
            if (CConfig.IsConnectionAvailable())
            {
                serverStatusPanel.BackColor     = Constants.SERVER_STATUS_OK_COLOR;
                serverStatusText.Text           = CLocalization.Get("serverStatusReady");
                serverStatusIcon.IconChar       = FontAwesome.Sharp.IconChar.CheckSquare;
            }
            else
            {
                serverStatusPanel.BackColor     = Constants.SERVER_STATUS_OFF_COLOR;
                serverStatusText.Text           = CLocalization.Get("serverStatusOffline");
                serverStatusIcon.IconChar       = FontAwesome.Sharp.IconChar.Warning;
            }
        }


        // Window movement
        private Point offset;
        private bool b_MouseDown = false;
        private void mainToolBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (b_MouseDown)
            {
                Point curPos = PointToScreen(e.Location);
                this.Location = new Point(curPos.X - offset.X, curPos.Y - offset.Y);
            }
        }

        private void mainToolBox_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;

            b_MouseDown     = true;
        }

        private void mainToolBox_MouseUp(object sender, MouseEventArgs e)
        {
            b_MouseDown     = false;
        }

        // **** //

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            AddFilesForm newForm    = new AddFilesForm();
            newForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            CLocalization.UpdateAddFilesForm(newForm);
            newForm.StartPosition   = FormStartPosition.CenterParent;
            newForm.ShowDialog(this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm();
            newForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            CLocalization.UpdateSettingsForm(newForm);
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog(this);
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Constants.DISCORD_LINK);
        }

        private void websiteLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Constants.WEBSITE_LINK);
        }

        private void nicknameBox_TextChanged(object sender, EventArgs e)
        {
            CConfig.UpdateNickname(nicknameBox.Text);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            CConfig.UpdateRegistry();
            G2O_Run(CConfig.GetVersion().Major, CConfig.GetVersion().Minor, CConfig.GetVersion().Build);
        }
    }
}
