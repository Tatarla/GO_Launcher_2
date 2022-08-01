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
        MaterialSkinManager themeManager = MaterialSkinManager.Instance;
        public AddFilesForm()
        {
            InitializeComponent();
            themeManager.ColorScheme = Constants.MATERIAL_DEFAULT_COLOR;
        }
    }
}
