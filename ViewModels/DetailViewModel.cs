using ConvMVVM2.Core.Attributes;
using ConvMVVM2.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowRoomDisplay.Services;

namespace ShowRoomDisplay.ViewModels
{
    /*
     * 사용자가 spot을 선택한 후 해당 spot에 대응되는 영상이
     * 재생되는 ViewModel : DetailViewModel
     */
    public partial class DetailViewModel : ViewModelBase
    {
        // 비디오 재생과 관련된 Service: VideoPlayService
        private readonly VideoPlayService _videoPlayService;

        #region Constructor
        public DetailViewModel(VideoPlayService videoPlayService) {
            this._videoPlayService = videoPlayService;
        }
        #endregion

        #region Property
        [Property]
        private string _VideoPath = "";
        #endregion

        #region Command
        // 동영상 재생
        [RelayCommand]
        private void playVideo()
        {
            try
            {
                if (this.VideoPath != null)
                    this._videoPlayService.Play(this.VideoPath);
            }
            catch (Exception ex)
            {
                // 경고
            }
        }

        // 동영상 멈춤
        [RelayCommand]
        private void stopVideo()
        {
            try
            {
                this._videoPlayService.Stop();
            }
            catch (Exception ex)
            {
                // 경고
            }
        }
        #endregion

    }
}
