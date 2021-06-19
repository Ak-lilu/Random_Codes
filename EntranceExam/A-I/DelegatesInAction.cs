using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class DelegatesInAction
    {
    }
    public class PhotoFilters
    {
        public void Brightness(Photo photo)
        {
            System.Console.WriteLine("applyig brightness ...");
        }
        public void Contrast(Photo photo)
        {
            System.Console.WriteLine("applyig brightness ...");
        }

    }
    public class PhotoStickers
    {
        public void AddGlitters(Photo photo)
        {
            Console.WriteLine("Glitter added");
        }
    }
    public class photoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void EditPicture(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
        }
    }
    public class Photo
    {
        public int sum()
        {
            var twoSqr = Math.Sqrt(2);
            return 1;
        }
        public static Photo Load(string photo)
        {
            return new Photo();
        }
    }
}
