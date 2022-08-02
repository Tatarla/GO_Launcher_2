using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace GOR_Launcher
{
    public partial class MainForm : Form
    {
        MaterialSkinManager themeManager = MaterialSkinManager.Instance;

        public MainForm()
        {
            InitializeComponent();
            themeManager.ColorScheme = Constants.MATERIAL_DEFAULT_COLOR;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initializing default language
            CLocalization.Initialize();
            var _ = CFileValidation.Initialize(this);

            // Initializing panel colors with alpha channel
            addLinksPanel.BackColor          = Constants.LINKS_PANEL_COLOR;
            newsPanel.BackColor              = Constants.NEWS_PANEL_COLOR;
            serverStatusPanel.BackColor      = Constants.SERVER_STATUS_OK_COLOR;
            playButton.BackColor             = Constants.PLAY_BUTTON_COLOR;
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
            playButton.Enabled = value;
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
            newForm.StartPosition   = FormStartPosition.CenterParent;
            newForm.ShowDialog(this);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog(this);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
