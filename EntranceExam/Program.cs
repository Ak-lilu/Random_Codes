using System;
using System.Linq;

namespace EntranceExam
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var photo = Photo.Load("");
            var stickers = new PhotoStickers();
            var processor = new photoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.Brightness;
            filterHandler += filters.Contrast;
            filterHandler += stickers.AddGlitters;
            filterHandler += AddFrames; 
            processor.EditPicture("", filterHandler);
   
        }
        static void AddFrames(Photo photo) => Console.WriteLine("Frame added!");
    } 
   
}

    
