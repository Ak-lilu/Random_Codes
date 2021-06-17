using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class BasicEvents
    {
        public event EventHandler Channel;
        ConsoleKeyInfo info;
        public void ears()
        {
            Channel += Speakers;
        }

        private void Speakers(object sender, EventArgs e)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("I heard something!");
                if (info.Key == ConsoleKey.X)
                    break;
            }
            }

        public void Ears()
        {
          
            if (info.Key == ConsoleKey.Spacebar)
                {
                    Channel(this, EventArgs.Empty);
                }
        }

    }
}
