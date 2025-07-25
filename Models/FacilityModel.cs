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
    public class FacilityModel
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public ObservableCollection<HotspotModel> Hotspots1 { get; set; } = new();
    }
}
