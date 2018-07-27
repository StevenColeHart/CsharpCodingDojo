using System;

namespace Wizzard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Gandolf= new Wizard("Gandolf");
            Human Ryu = new Human("Ryu");
            Ninja Tenchu = new Ninja("Tenchu");
            Samurai jack = new Samurai("Jack");
            Samurai jin = new Samurai("jin");
            Wizard.getstats(Gandolf);
            Gandolf.throwfireball(Ryu);
            Gandolf.throwfireball(Tenchu);
            Tenchu.steal(Gandolf);
            Ryu.attack(jack);
            Ryu.attack(jack);
            Gandolf.throwfireball(jack);
            jack.meditate();
            Tenchu.flee();
            Samurai.how_many();


            
        
        }
    }
}
