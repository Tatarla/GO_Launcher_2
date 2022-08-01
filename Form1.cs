using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOR_Launcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initializing default language
            CLocalization.Initialize();
            CFileValidation.Initialize(mainProgressBar, mainProgressLabel);

            // Initializing panel colors with alpha channel
            addLinksPanel.BackColor          = Constants.LINKS_PANEL_COLOR;
            newsPanel.BackColor              = Constants.NEWS_PANEL_COLOR;
            serverStatusPanel.BackColor      = Constants.SERVER_STATUS_OK_COLOR;
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
    }
}
