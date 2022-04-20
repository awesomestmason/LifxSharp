using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifxSharp.Http.Helpers
{
    public class ColorBuilder
    {
        private ushort? Hue { get; set; }
        private float? Saturation { get; set; }
        private float? Brightness { get; set; }
        private int? Kelvin { get; set; }
    }

    public class LifxColor {


        /// <summary>
        /// Hue value from 0 to 360
        /// </summary>
        public ushort? Hue { get; set; }
        /// <summary>
        /// Saturation value from 0.0 to 1.0
        /// </summary>
        public double? Saturation { get; set; }
        /// <summary>
        /// Brightness value from 0.0 to 1.0
        /// </summary>
        public double? Brightness { get; set; }
        /// <summary>
        /// Kelvin value from 1500 to 9000
        /// </summary>
        public int? Kelvin { get; set; }





        public string AsLifxColorString()
        {
            List<string> args = new List<string>();
            if (Hue != null) args.Add($"hue:{Hue.Value}");
            if (Saturation != null) args.Add($"saturation:{Saturation.Value}");
            if (Brightness != null) args.Add($"brightness:{Brightness.Value}");
            if (Kelvin != null) args.Add($"kelvin:{Kelvin.Value}");
            return string.Join(' ', args);
        }

    }

}
