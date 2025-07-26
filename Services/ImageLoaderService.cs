using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ShowRoomDisplay.Services
{
    public class ImageLoaderService
    {
        public BitmapImage Load(string path) => new BitmapImage(new Uri(path));
    }
}
