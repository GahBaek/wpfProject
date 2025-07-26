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
        public void AddSpotToFacility(FacilityModel facility, double x, double y)
        {
            if (facility == null) return;

            var newSpot = new HotspotModel { X = x, Y = y };
            facility.Hotspots1.Add(newSpot);
        }


        // spot 삭제 메소드
        public void DeleteSpotFromFacility(FacilityModel facility, HotspotModel hotspot)
        {
            facility?.Hotspots1.Remove(hotspot);
        }

        // spot 색, 크기, 수정 메소드
        public void UpdateSpotAt(int index, HotspotModel updated)
        {
            if (index >= 0 && index < hotspotModels.Count)
            {
                hotspotModels[index] = updated;
            }
        }

        // 설비에 해당하는 모든 spot get
        public void getSpots(FacilityModel facility)
        {
            facility.Hotspots1.GetEnumerator().MoveNext();
        }

       // ---- 추가 사항 ----
        // index 번호를 통해 spot 객체 얻기 (?)
        public HotspotModel? GetSpotByIndex(int index)
        {
            if (index >= 0 && index < hotspotModels.Count)
                return hotspotModels[index];

            return null;
        }
    }
}
