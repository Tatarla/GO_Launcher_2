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

            List<string> langList = CLocalization.GetLanguageList();
            foreach(string str in langList)
                languageSelectBox.Items.Add(str);

            languageSelectBox.SelectedIndex = languageSelectBox.FindString(CLocalization.GetLanguageByCode(CLocalization.GetLanguage()));
            Translate();
        }

        private async void validateFilesButton_Click(object sender, EventArgs e)
        {
            if (CFileValidation.IsReady())
                await CFileValidation.StartFileValidation();

            await Task.Delay(1);
        }

        private void languageSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string languageCode = CLocalization.GetLanguageByName((string)languageSelectBox.Text);
            if (languageCode != "none")
                CLocalization.Translate(languageCode);
        }

        public void Translate()
        {
            this.Text                   = CLocalization.Get("settings_header");
            languageSelectLabel.Text    = CLocalization.Get("settings_language");
            resolutionLabel.Text        = CLocalization.Get("settings_resolution");
            windowedModeLabel.Text      = CLocalization.Get("settings_windowed");
            musicVolumeLabel.Text       = CLocalization.Get("settings_musvolume");
            soundVolumeLabel.Text       = CLocalization.Get("settings_sndvolume");
            mouseSensitivityLabel.Text  = CLocalization.Get("settings_sensitivity");
            validateFilesButton.Text    = CLocalization.Get("settings_validation");
        }
    }
}
