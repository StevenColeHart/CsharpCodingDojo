using System;





namespace human{
    public class Human{


        public string playername;
        public int strength = 3;
        public int intelligence =3;
        public int dexterity =3;
        public int health = 100;

        public Human(string name){
            playername = name;

        }

        public Human( string n, int s, int i, int d, int h){
            playername = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;

        }

        public static void getstats(Human name){
            var playername =  name as Human;
            Console.WriteLine($"{playername.playername} stats are: Strength {playername.strength} Intelligence {playername.intelligence} Dexterity {playername.dexterity} Health {playername.health}");
        }

        public void attack(Human target){
            Human enemy = target as Human;
            int damage = this.strength * 5;
            enemy.health -= damage;
            
            Console.WriteLine($"{this.playername} viciously attacked {enemy.playername} for {damage} damage. {enemy.playername} health is now {enemy.health}");
        }






    }








}