using System.Linq;

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
  
}

    
