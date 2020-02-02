using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urls = new string[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/C_Sharp_wordmark.svg/1200px-C_Sharp_wordmark.svg.png",
                                           "https://www.vippng.com/png/detail/398-3984434_c-language-circle.png",
                                           "https://i.pinimg.com/236x/97/cf/2c/97cf2ccd659ef9b00dd0aa15137130ec.jpg"};

            ImageDownloaderClass imgDwn = new ImageDownloaderClass();

            //TODO

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
