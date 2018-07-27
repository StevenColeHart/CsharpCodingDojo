using System;

namespace Wizzard_Ninja_Samurai{

    public class Samurai:Human{
        int maxhealth = 200;
        public static int count;
        public Samurai(string name):base(name){
            health = 200;
            count ++;
            
        }

        public void deathblow(object target){
            Human enemy = target as Human;
            if(enemy.health < 50){
                enemy.health = 0;
            }
            Console.WriteLine($"{enemy.playername} has taken a fatal blow and now has {enemy.health} hp" );
        }

        public void meditate(){
            this.health = maxhealth;
            Console.WriteLine($"{this.playername} meditated and regained full health. Current hp {health}");
        }

        public static void how_many(){
            Console.WriteLine($"There are {count} Samurai on the battlefield!");

        }

    }




































}