using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowRoomDisplay.Models;

namespace ShowRoomDisplay.Services
{
    /*
     * Hotspot 추가, 삭제, 수정 비즈니스 로직
     * : HotspotService
     */
    public class HotspotService : ObservableObject
    {
        // Hotspot 리스트
        public ObservableCollection<HotspotModel> hotspotModels { get; } = new ObservableCollection<HotspotModel>();
        
        // spot 추가 메소드
        public void AddSpot(double x, double y){

            var newSpot = new HotspotModel
            {
                X = x,
                Y = y,
            };

            this.hotspotModels.Add(newSpot);
        }


        // spot 삭제 메소드
        public void DeleteSpot(HotspotModel hotspotModel)
        {
            if (hotspotModels != null)
            {   
                hotspotModels.Remove(hotspotModel);
            }
        }

        // spot 색, 크기, 수정 메소드
        public void UpdateSpot(HotspotModel newHotspotModel)
        {
            if (newHotspotModel != null)
            {

            }

        }




        // ---- 추가 사항 ----
        // index 번호를 통해 spot 객체 얻기 (?)

    }
}
