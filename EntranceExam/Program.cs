using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EntranceExam
{
    class Program
    {
      
        static void Main(string[] args)
        {
            DelegatingClass delegating = new DelegatingClass();
            DelegatingClass.Greet delegatingClass = new DelegatingClass.Greet(delegating.messageOne);
            DelegatingClass.Greet delegatingClass2 = new DelegatingClass.Greet(delegating.message2);
            DelegatingClass.Greet delegatingClass3 = new DelegatingClass.Greet(delegating.message3);

            //Invocation 
            delegatingClass();
            delegatingClass2();
            delegatingClass3();

        }
    }
    public class DelegatingClass
    {
        public delegate void Greet();
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

    
