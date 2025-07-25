using ConvMVVM2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvMVVM2;

namespace ShowRoomDisplay.Models
{
    /*
     * 설비 Model
     */
    public class FacilityModel
    {
        // 설비명
        public string Name { get; set; }
        // 설비 사진 ( 3개의 모니터에 띄워지는 )
        public string ImagePath { get; set; }
        // 설비 이미지에 포함될 핫스팟 리스트
        public ObservableCollection<HotspotModel> Hotspots1 { get; set; } = new();
    }
}
