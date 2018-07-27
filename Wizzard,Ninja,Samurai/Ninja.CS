using System;

        namespace Wizzard_Ninja_Samurai{

            public class Ninja : Human{

                public Ninja(string name):base(name){
                    dexterity = 175;
                }

                public void steal(object target){
                    Human enemy = target as Human;
                    enemy.health -= 10;
                    this.health += 10;
                    Console.WriteLine($"{this.playername} stole 10 hp from {enemy.playername}. {this.playername} now has {this.health} hp");

                }

                public void flee(){
                    this.health -= 15;
                    Console.WriteLine($"{this.playername} fleed from battle taking 15 damage.");
                }








            }
































        }