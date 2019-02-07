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
            var a = new TestQuestion2();
            //a.PlayingWithForLoops();
            Console.ReadLine();

            var b = new birthdayParty();
            b.setupPartyList();
            b.printPartyList();
        }
    }


    class TestQuestion2
    {
        public int myFavouriteVariable = 0;
        public void PlayingWithForLoops()
        {
            for (; MyMethod();)
            {
                if (myFavouriteVariable > 10)
                {
                    Console.WriteLine("i am so out of here");

                    break;
                }
                else
                {
                    Console.WriteLine("oh no i have to go through this again");

                }
            }
        }
        public bool MyMethod()
        {
            myFavouriteVariable++;
            return true;
        }
    }

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;

        }

        public string dog_name;
        public string dog_breed;
        public dog nextdog;
        public dog previousdog;
    }
    class birthdayParty
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temp;

        public void setupPartyList()
        {
            peanut = new dog("peanut", "bichon");
            fifi = new dog("fifi", "poodle");
            clarence = new dog("Clarence", "German Sheppard");
            roy = new dog("roy", "beagle");

            peanut.previousdog = null;
            peanut.nextdog = fifi;
            fifi.previousdog = peanut;
            fifi.nextdog = clarence;
            clarence.previousdog = fifi;
            clarence.nextdog = roy;
            roy.previousdog = clarence;
            roy.nextdog = null;

            head = peanut;
            tail = roy;
        }

        public string printPartyList(dog startOfList, dog endOfList)
        {
            string inviteList = "---";
            temp = startOfList;
            while (temp.nextdog != null)
            {
                inviteList += temp.dog_name + "*---";
            }
            return inviteList;
        }
    }
}