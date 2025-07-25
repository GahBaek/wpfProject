using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Models
{
    public class HotspotModel
    {
        public int Index { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; } = 50;
        public double Height { get; set; } = 50;
        public string Color { get; set; } = "#FF0000";
        public string VideoPath { get; set; } = string.Empty;
    }
}
