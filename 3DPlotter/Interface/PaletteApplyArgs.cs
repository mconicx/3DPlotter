using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPlotter.Interface
{
    public class PaletteApplyArgs : EventArgs
    {
        public Color MinColor { get; set; }
        public Color MaxColor { get; set; }
    }
}
