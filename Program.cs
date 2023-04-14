using System;

namespace classes_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            //links the Greetings.cs to this class.
            Greetings greetings = new Greetings();
            //prints out welcome line from greetings.
            greetings.Welcome();

            //ask for players name.
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            //says hello to the player.
            greetings.Hello(userName);
        }
    }
}
