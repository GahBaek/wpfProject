using ShowRoomDisplay.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Services
{
    public class SettingHotspotService
    {
        private int _currentIndex = 1;

        public HotspotModel CreateNewHotspot(double x, double y, double width = 50, double height = 50)
        {
            return new HotspotModel
            {
                Index = _currentIndex++,
                X = x,
                Y = y,
                Width = width,
                Height = height,
                Color = "#FF0000",

                VideoPath = ""
            };
        }

        public void DeleteHotspot(ObservableCollection<HotspotModel> list, HotspotModel target)
        {
            if (list.Contains(target))
                list.Remove(target);
        }

        public void ResetIndex() => _currentIndex = 1;


        public void SaveHotspotsToFile(string filePath, IEnumerable<HotspotModel> hotspots)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(hotspots, options);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Hotspot 저장 실패] {ex.Message}");
            }
        }
        public ObservableCollection<HotspotModel> LoadHotspotsFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return new ObservableCollection<HotspotModel>();

                var json = File.ReadAllText(filePath);
                var loaded = JsonSerializer.Deserialize<List<HotspotModel>>(json);

                // 현재 인덱스 최신화
                if (loaded != null && loaded.Count > 0)
                    _currentIndex = loaded.Max(h => h.Index) + 1;

                return new ObservableCollection<HotspotModel>(loaded ?? new List<HotspotModel>());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Hotspot 불러오기 실패] {ex.Message}");
                return new ObservableCollection<HotspotModel>();
            }
        }
        public void LinkVideoToHotspot(HotspotModel hotspot, string videoPath)
        {
            if (hotspot == null || string.IsNullOrEmpty(videoPath))
                return;

            hotspot.VideoPath = videoPath;
        }
    }

}
