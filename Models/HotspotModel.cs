using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Models
{
    /*
     * 사진 위에 표시될 spot Model
     */
    public class HotspotModel
    {
        public int Index { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        // spot 사이즈 변경 가능 기능을 위한 넓이, 높이
        public double Width { get; set; } = 50;
        public double Height { get; set; } = 50;
        // 색상 변경 가능 기능을 위한 Color
        public string Color { get; set; } = "#FF0000";
        // 하나의 spot에 하나의 video가 연결된다.
        public string VideoPath { get; set; } = string.Empty;
    }
}
