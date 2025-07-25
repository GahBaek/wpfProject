using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using LibVLCSharp.Shared;

namespace ShowRoomDisplay.Services
{
    /*
    * spot 클릭시 Video 실행 로직 처리 Service : VideoPlayService
    */
    public class VideoPlayService
    {
        // VLC 선언
        private LibVLC _libVLC;
        private LibVLCSharp.Shared.MediaPlayer _mediaPlayer;

        public VideoPlayService()
        { 
            // LibVLCSharp 필수 초기화
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
        }

        // 비디오 재생 메소드
        public void Play(string videoPath)
        {
            using var media = new Media(_libVLC, videoPath, FromType.FromPath);
            media.AddOption(":input-repeat=65535");
            _mediaPlayer.Play(media);
        }
        // 비디오 멈춤 메소드
        public void Stop()
        {
            _mediaPlayer.Stop();
        }
    }
}
