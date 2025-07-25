using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class HotspotModel : ObservableObject
    {
        [ObservableProperty]
        private int _Index;
        [ObservableProperty]
        private double _X;
        [ObservableProperty]
        private double _Y;

        // spot 사이즈 변경 가능 기능을 위한 넓이, 높이
        [ObservableProperty]
        private double _Width = 50;
        [ObservableProperty]
        private double _Height = 50;

        // 색상 변경 가능 기능을 위한 Color
        [ObservableProperty]
        private string _Color = "#FF0000";

        // 하나의 spot에 하나의 video가 연결된다.
        [ObservableProperty]
        private string _VideoPath = string.Empty;

        // Convertor
    }
}
