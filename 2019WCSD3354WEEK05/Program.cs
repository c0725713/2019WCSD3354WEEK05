using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019WCSD3354WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new testques2();
            a.Play();
        }
    }

    class testques2
    {
        public int myfavvari = 0;
        public void Play()
        {
            //write a for loop

            for (; my();)
            {
                if (myfavvari <= 10)
                    Console.WriteLine("you are fool");
                break;
            }
            Console.WriteLine("shit for loop again");
        }
        public bool my()
        {
            myfavvari++;
            return true;
        }
    }
}