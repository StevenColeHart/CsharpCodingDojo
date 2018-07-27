using System;

namespace Wizzard_Ninja_Samurai{

    public class Wizard : Human{
        public Wizard(string name) : base(name){
            health = 50;
            intelligence = 25;
        }

        public void heal(){
            health += 10*intelligence;
        }

        public void throwfireball(object target){
            Human enemy = target as Human;
            Random rand = new Random();
            int damage = rand.Next(20,50);
            enemy.health -= damage;
            Console.WriteLine($"{this.playername} threw a fireball at {enemy.playername} for {damage} damage. {enemy.playername}'s has been reduced to {enemy.health} hp");

        }
























    }






































}