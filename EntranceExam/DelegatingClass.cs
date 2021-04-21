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
        public delegate void Greet();
        static Product product = new Product();
       public List<Product> Items { get; set; } = new List<Product>();
        public void PopulateProduct()
        {
            Items.Add(new Product { Id = 1, Name = "Book", Level = 1 });        
            Items.Add(new Product { Id = 2, Name = "Movies", Level = 2 });        
            Items.Add(new Product { Id = 3, Name = "Musics", Level = 5 });        
        }
        
        public void messageOne()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"this is message from 1st method");
            
        }
        public void message2()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"this is message from 2nd method");
        }
        public void message3()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"this is message from 3rd method");
        }
    }
}

    
