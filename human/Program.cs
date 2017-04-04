using System;

namespace ConsoleApplication
{

           public class Human{
            // Create a base Human class with five attributes: name, strength, intelligence, dexterity, and health.
            public string name {get; set;}

            public int strength = 3;
            public int intelligence = 3;

            public int dexterity = 3;
            public int health = 100;   
        

        public Human(string nme, int str, int intel, int dex, int hp){

            name = nme;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp; 
        }

        public void Attack(object target){
            Human dude = target as Human; 
            if(dude !=null){
            dude.health -= 5 *strength;
            }
         }
     }
 }
                
            // Console.WriteLine("Hello World!");




