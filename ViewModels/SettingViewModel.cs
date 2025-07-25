using CommunityToolkit.Mvvm.ComponentModel;
using ConvMVVM2.Core.Attributes;
using ConvMVVM2.Core.MVVM;
using ShowRoomDisplay.Models;
using ShowRoomDisplay.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ShowRoomDisplay.ViewModels
{
    /*
     *  관리자가 설비 설정(이미지 설정, 설비 이름, 설비 기본 영상 설정) ViewModel
     */
    public partial class SettingViewModel : ViewModelBase
    {
        // Facility 리스트
        [Property]
        public ObservableCollection<FacilityModel> facilityModels;
        // Facility 로직 Service
        private readonly FacilityService _facilityService;
        // Image 설정 로직 Service
        private readonly SettingImageService _settingImageService;
        // UI 에서 선택한 Image
        [Property]
        private ImageSource? _SelectedImage;

        #region Constructor
        public SettingViewModel(FacilityService facilityService, SettingImageService settingImageService)
        {
            this._settingImageService = settingImageService;
            this._facilityService = facilityService;
            this.facilityModels = this._facilityService._FacilityModels;
        }
        #endregion


        // Command
        // 설비 생성
        public void AddFacility(string name)
        {
            try
            {
                this._facilityService.AddFacility(name);
            }
            catch (Exception ex) {
                Debug.WriteLine($"AddFacility Error: {ex.Message}");
            }
        }
        // 설비 삭제
        public void DeleteFacility(string name)
        {
            try
            {
                var facility = _facilityService.GetFacilityByName(name);
                if (facility != null)
                {
                    _facilityService.DeleteFacility(facility);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DeleteFacility Error: {ex.Message}");
            }
        }
        // 설비 이미지 설정 SetImage
        public void SetImage(string name, string imagePath)
        {
            try
            {
                var facility = _facilityService.GetFacilityByName(name);
                if (facility != null)
                {
                    _facilityService.SetImage(facility, imagePath);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SetImage Error: {ex.Message}");
            }
        }

        // 관리자가 파일에서 Image 선택
        public void SelectAndSetImage(string facilityName)
        {
            var path = _settingImageService.SelectImageFile();
            if (!string.IsNullOrEmpty(path))
            {
                SetImage(facilityName, path);
                this._SelectedImage = _settingImageService.LoadImageFromPath(path);
            }
        }
        // 설비 이름 수정 RenameFacility
        public void RenameFacility(string name, string newName)
        {
            try
            {
                var facility = _facilityService.GetFacilityByName(name);
                if (facility != null)
                {
                    _facilityService.RenameFacility(facility, newName);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RenameFacility Error: {ex.Message}");
            }
        }

    }
}
