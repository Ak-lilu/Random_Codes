using EntranceExam.A_I;
using EntranceExam.L_P;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    class Program
    {
      
        static void Main(string[] args)
        {

            Console.WriteLine(Stacked.IsStacked(19));
        }

        private static void EvenNumberUnder10UsingLinq()=>
            Console.WriteLine(string.Join(",",Enumerable.Range(0, 10).Where(x => x % 2 == 0).ToList()));
        

        static void messages(string s) => Console.WriteLine("what is happenning here?");
        static void AddFrames(Photo photo) => Console.WriteLine("Frame added!");
    } 
   
}


//var photo = Photo.Load("");
//var stickers = new PhotoStickers();
//var processor = new photoProcessor();
//var filters = new PhotoFilters();
//Action<Photo> filterHandler = filters.Brightness;
//filterHandler += filters.Contrast;
//filterHandler += stickers.AddGlitters;
//filterHandler += AddFrames;
//processor.EditPicture("0000", filterHandler);
//DelegatingClass delegatingClass = new DelegatingClass();
//delegatingClass.News(delegatingClass.message2);