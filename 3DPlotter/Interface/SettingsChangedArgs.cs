using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPlotter.Interface
{
    public class SettingsChangedArgs : EventArgs
    {
        public int MouseSensitivity { get; set; }
        public int FOV { get; set; }
        public bool ReverseH { get; set; }
        public bool ReverseV { get; set; }
    }
}
