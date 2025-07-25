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
     * 설비 추가, 삭제, 저장 비즈니스 로직: FacilityService
     */
    public class FacilityService : ObservableObject
    {
        // Facility 리스트
        public ObservableCollection<FacilityModel> _FacilityModels { get; } = new ObservableCollection<FacilityModel>();

        // 설비 추가 메소드
        public void AddFacility(string name)
        {
            // 설비 추가 시 이름만을 입력받아 추가할 수 있다.
            var newFacility = new FacilityModel
            {
                Name = name,
                ImagePath = string.Empty,
                Hotspots1 = new ObservableCollection<HotspotModel>()
            };

            _FacilityModels.Add(newFacility);
        }

        // 설비 삭제 메소드
        public void DeleteFacility(FacilityModel facilityModel) {
            if (_FacilityModels.Contains(facilityModel))
                _FacilityModels.Remove(facilityModel);
        }

        // 설비 이름 수정 메소드
        public void RenameFacility(FacilityModel facilityModel, string newName)
        {
            facilityModel.Name = newName;
        }

        // 이미지 경로 설정
        public void SetImage(FacilityModel facilityModel, string imagePath)
        {
            facilityModel.ImagePath = imagePath;
        }

        // 설비 이름을 통해 설비 객체 얻기
        public FacilityModel? GetFacilityByName(string name)
        {
            return _FacilityModels.FirstOrDefault(f => f.Name == name);
        }
    }
}
