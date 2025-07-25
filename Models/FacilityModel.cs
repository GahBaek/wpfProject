using ConvMVVM2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvMVVM2;
using CommunityToolkit.Mvvm.ComponentModel;
using ConvMVVM2.Core.Attributes;

namespace ShowRoomDisplay.Models
{
    /*
     * 설비 Model
     */
    public partial class FacilityModel : ObservableObject
    {
        // 설비명
        [ObservableProperty]
        private string _Name;
        // 설비 사진 ( 3개의 모니터에 띄워지는 )
        [ObservableProperty]
        private string _ImagePath;
        // 설비 이미지에 포함될 핫스팟 리스트
        [ObservableProperty]
        private ObservableCollection<HotspotModel> _Hotspots1 = new();
        // 모드에 따라 달라진다.
        [ObservableProperty]
        private string _VideoPath;
    }
}
