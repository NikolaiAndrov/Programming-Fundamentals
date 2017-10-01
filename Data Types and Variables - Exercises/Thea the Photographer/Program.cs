using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {

            var pictureCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterPercentuage = int.Parse(Console.ReadLine());
            var singlePicUploadTimeSeconds = int.Parse(Console.ReadLine());

            var filterTimeSeconds = (long)pictureCount * singlePictureFilterTimeSeconds;
            var pictureToUploadCount = (long)Math.Ceiling(pictureCount * (filterPercentuage / 100d));
            var uploadTimeSeconds = pictureToUploadCount * singlePicUploadTimeSeconds;

            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
