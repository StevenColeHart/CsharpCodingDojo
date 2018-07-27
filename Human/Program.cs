using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ken = new Human("Ken");
            Human Ryu = new Human("Ryu");

            Ken.attack(Ryu);
            Human.getstats(Ryu);
            
        }
    }
}
