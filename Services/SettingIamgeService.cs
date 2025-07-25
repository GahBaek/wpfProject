using Microsoft.Win32;
using ShowRoomDisplay.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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

        // Json 파일 저장
        public void SaveConfigJson(string filePath, IEnumerable<FacilityModel> facilities)
        {
            try
            {
                // 들여쓰기 설정
                var options = new JsonSerializerOptions { WriteIndented = true };
                // Json 직렬화
                var json = JsonSerializer.Serialize(facilities, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Facility 저장 실패] {ex.Message}");
            }
        }

        // Json 파일 로드
        public ObservableCollection<FacilityModel> LoadFacilitiesFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return new ObservableCollection<FacilityModel>();

                var json = File.ReadAllText(filePath);

                // Json 역직렬화
                var loaded = JsonSerializer.Deserialize<List<FacilityModel>>(json);

                return new ObservableCollection<FacilityModel>(loaded ?? new List<FacilityModel>());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Facility 불러오기 실패] {ex.Message}");
                return new ObservableCollection<FacilityModel>();
            }
        }
    }
}
