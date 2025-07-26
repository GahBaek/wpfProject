using ShowRoomDisplay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Services
{
    /*
     * spot 과 Video linking
     */
    public class HotspotVideoLinkService
    {
        // spot 과 해당하는 video 연결하는 메소드
        public void LinkVideo(HotspotModel hotspot, string videoPath)
        {
            if (hotspot == null || string.IsNullOrWhiteSpace(videoPath)) return;
            hotspot.VideoPath = videoPath;
        }
    }
}
