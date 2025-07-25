using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Models
{
    public class ConfigModel
    {
        public string CurrentMode { get; set; } = "User";
        public string SelectedFacilityName { get; set; }
        public int VideoMonitorIndex { get; set; } = 3;

        public string FacilityJsonPath { get; set; } = "./Data/facilities.json";
    }

}
