using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace ShowRoomDisplay.Services
{
    /*
    * 설비에 대응하는 Image 설정 Service : SettingImageService
    */
    public class SettingImageService
    {
        // Image Source 로 부터 사용자가 선택한 이미지 경로 반환 메서드
        public string? SelectImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png"
            };
            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : null;
        }

        // 인자로 주어진 Imgae path 로부터 이미지를 로드한다.
        public BitmapImage LoadImageFromPath(string path)
        {
            return new BitmapImage(new Uri(path));
        }
    }
}
