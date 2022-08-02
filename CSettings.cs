using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOR_Launcher
{
    public static class CSettings
    {
        public static void Set(string name, object value)
        {
            Properties.Settings.Default[name] = value;
            Properties.Settings.Default.Save();
        }

        public static object Get(string name)
        {
            return Properties.Settings.Default[name];
        }
    }
}
