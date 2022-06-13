using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = false;

            bool atBeach = true;

            string sunblock = "Sunblock is a good idea.";
  
            string noSunblock = "Sunblock isn't needed.";

            bool goAnyway = true;

            string going = "Awesome! Glad you don't mind clouds!";
            
            string nextTime = "No worries! Hopefully next time we will have some sun!";

            if (isSunny)
            {
                Console.WriteLine("Wear sunglasses!");
             if (atBeach)
                {
                    Console.WriteLine(sunblock);
                }
                else
                {
                    Console.WriteLine(noSunblock);
                }
            }
            else
            {
                Console.WriteLine("You don't need to wear sunglasses.");
            if (goAnyway)
            {
                Console.WriteLine(going);
            }
            else
            {
                Console.WriteLine(nextTime);
            }
            }

            


        }
    }
}