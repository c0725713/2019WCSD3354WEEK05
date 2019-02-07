using System;


namespace _2019WCSD3354WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new testques2();
            //a.Play();
            birthday_party b = new birthday_party();
            b.setupPartyList();
            b.printPartyList();
            b.printPartyListreverse();
            Console.WriteLine(b.printPartyList());
            Console.WriteLine(b.printPartyListreverse());
        }
    }

    //class testques2
    //{
    // public int myfavvari = 0;
    // public void Play()
    // {
    // //write a for loop

    // for (; my();)
    // {
    // if (myfavvari <= 10)
    // Console.WriteLine("you are fool");
    // break;
    // }
    // Console.WriteLine("shit for loop again");
    // }
    // public bool my()
    // {
    // myfavvari++;
    // return true;
    // }
    //}

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }

        public dog()
        {
        }

        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;

    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog Giselle;
        public dog Lulu;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("Fifi", "Poodle");
            clarence = new dog("Clarence", "German Sheppard");
            Giselle = new dog("Giselle", "Lebra");
            Lulu = new dog("Lulu", "Bulldog");
            roy = new dog("Roy", "Beagle");

            peanut.prev_dog = null;
            peanut.next_dog = fifi;

            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;


            clarence.prev_dog = fifi;
            clarence.next_dog = Giselle;


            Giselle.prev_dog = clarence;
            Giselle.next_dog = Lulu;


            Lulu.prev_dog = Giselle;
            Lulu.next_dog = roy;

            roy.prev_dog = Lulu;
            roy.next_dog = null;
            head = peanut;
            tail = roy;

        }

        public string printPartyList()

        {

            string inviteList = "*--";

            temporary = head;

            while (temporary.next_dog != null)

            {

                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.next_dog;
            }
            inviteList += temporary.dog_name + " * --- * ";
            return inviteList;
        }

        public string printPartyListreverse()

        {

            string inviteList = "*--";

            temporary = tail;

            while (temporary.prev_dog != null)


            {

                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.prev_dog;
            }



            return inviteList;

        }



    }

}