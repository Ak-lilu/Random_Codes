using System;
using System.Collections.Generic;
using System.Threading;

namespace EntranceExam
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

    }
    public class DelegatingClass
    {
        public delegate void Greet(string str);

       public List<Product> Items { get; set; } = new List<Product>();
        public void PopulateProduct()
        {
            Items.Add(new Product { Id = 1, Name = "Book", Level = 1 });        
            Items.Add(new Product { Id = 2, Name = "Movies", Level = 2 });        
            Items.Add(new Product { Id = 3, Name = "Musics", Level = 5 });        
        }
        public void News(Greet greet) { Console.WriteLine("\" ? \""); }
        public void messageOne(string s)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"this is message from 1st method {s}");
            
        }
        public void message2(string s)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"this is message from 2nd method {s}");
        }
        public void message3(string s)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"this is message from 3rd method {s}");
        }
    }
}

    
