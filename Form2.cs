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
    public partial class AddFilesForm : MaterialForm
    {
        private bool initialized = false;
        public AddFilesForm()
        {
            InitializeComponent();
            Translate();

            addDx11Switch.Checked       = Convert.ToBoolean(CSettings.Get("add_DX11"));
            addFontsSwitch.Checked      = Convert.ToBoolean(CSettings.Get("add_customFonts"));
            addNoGrassSwitch.Checked    = Convert.ToBoolean(CSettings.Get("add_noGrass"));
            initialized                 = true;
        }

        public void Translate()
        {
            this.Text = CLocalization.Get("additionalfiles_header");
        }

        private void addDx11Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialized) return;
            if (!CFileValidation.IsReady())
            {
                addDx11Switch.Checked = Convert.ToBoolean(CSettings.Get("add_DX11"));
                return;
            }

            if (addDx11Switch.Checked)
                CFileValidation.LoadAdditionalFile("add_DX11");
            else
                CFileValidation.DeleteAdditinalFile("add_DX11");
        }

        private void addFontsSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialized) return;
            if (!CFileValidation.IsReady())
            {
                addFontsSwitch.Checked = Convert.ToBoolean(CSettings.Get("add_customFonts"));
                return;
            }

            if (addFontsSwitch.Checked)
                CFileValidation.LoadAdditionalFile("add_customFonts");
            else
                CFileValidation.DeleteAdditinalFile("add_customFonts");
        }

        private void noGrassSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialized) return;
            if (!CFileValidation.IsReady())
            {
                addNoGrassSwitch.Checked = Convert.ToBoolean(CSettings.Get("add_noGrass"));
                return;
            }

            if (addNoGrassSwitch.Checked)
                CFileValidation.LoadAdditionalFile("add_noGrass");
            else
                CFileValidation.DeleteAdditinalFile("add_noGrass");
        }
    }
}
