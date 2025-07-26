using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace ShowRoomDisplay.Services
{
    /*
     *  Facility, Hotspot의 Json 저장 및 로드 담당
     */
    public class JsonPersistenceService
    {
        // Json 형식으로 파일에 저장
        public void SaveToFile<T>(string path, IEnumerable<T> data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(data, options));
        }

        // Json 파일로부터 Facility, Hotspot 로드하기
        public ObservableCollection<T> LoadFromFile<T>(string path)
        {
            if (!File.Exists(path)) return new ObservableCollection<T>();
            var json = File.ReadAllText(path);
            var list = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            return new ObservableCollection<T>(list);
        }
    }
}
