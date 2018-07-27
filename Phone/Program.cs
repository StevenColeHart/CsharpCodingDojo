using System;

namespace Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Doo do Doo Doo");
            Nokia elevenhundred = new Nokia("1100", 50, "metor PCS", "ringg ring ringg");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine("");

            elevenhundred.DisplayInfo();
            Console.WriteLine(elevenhundred.Ring());
            Console.WriteLine(elevenhundred.Unlock());
            Console.WriteLine("");            



        }
    }
}
