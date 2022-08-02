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
using MaterialSkin.Controls;

namespace GOR_Launcher
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private async void validateFilesButton_Click(object sender, EventArgs e)
        {
            if (CFileValidation.IsReady())
                await CFileValidation.StartFileValidation();

            await Task.Delay(1);
        }
    }
}
