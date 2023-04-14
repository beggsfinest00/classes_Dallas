using System;
using System.Collections.Generic;
using System.Text;

namespace classes_Dallas
{
    class Greetings
    {
        /// <summary>
        /// prints Hello Traveler, welcome!
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }
        /// <summary>
        /// prints out name and thank you joining us today!
        /// </summary>
        /// <param name="name">prints out name</param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you joining us today!");
        }
    }
}
