using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace ShowRoomDisplay.Services
{
    public class SettingImageService
    {
        public string? SelectImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png"
            };
            return openFileDialog.ShowDialog() == true ? openFileDialog.FileName : null;
        }

        public BitmapImage LoadImageFromPath(string path)
        {
            return new BitmapImage(new Uri(path));
        }
    }
}
