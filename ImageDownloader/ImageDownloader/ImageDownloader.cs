using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ImageDownloader
{
    class ImageDownloaderClass
    {
        
        public ImageDownloaderClass()
        {
           
        }
        public async Task<byte[]> DownloadImage(string path)
        {
            Console.WriteLine($"Start downloading an image from {path}...");
            throw new NotImplementedException();
        }

        public async Task RotateImage(string imagePath)
        {
            Console.WriteLine($"Rotating {imagePath} image by 90 degrees...");

            using (System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath))
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipX);
                img.Save($"{imagePath.Split('.')[0]}Rotated.jpg");
            }
        }

        public void SaveImage(byte[] bytes, string imagePath)
        {
            Console.WriteLine("Saving {0} image", imagePath);
            throw new NotImplementedException();
        }
    }
}
