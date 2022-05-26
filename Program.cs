using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DNDVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please chose a weapon: " +
                "\naxe: " +
                "\nsword: " +
                "\nkatana: " +
                "\nshield: " +
                "\ndagger: ");
            string weapon = ReadLine();
            Action.Combat(weapon);
            WriteLine("Nicely done, unless you ran away of course.. ");
            Console.Read();
        }
    }

    //creating the combat class
    public class Action : Dice
    {
        //creating the attacks
        public int attack { get; set; }

        //adding the play hp as well
        public int php;

        //the total enemy hp
        public int enemyHP;

        //creating the weapons 
        public string axe = "axe";
        public string sword = "sword";
        public string katana = "katana";
        public string shield = "shield";
        public string dagger = "dagger";

        public void Damage(string weapon)
        {
            //setting the damages equal to the weapons ability
            if (weapon == axe)
            {
                attack = 25;
            }

            else if (weapon == sword)
            {
                attack = 50;
            }

            else if (weapon == katana)
            {
                attack = 60;
            }

            else if (weapon == shield)
            {
                attack = 10;
            }

            else if (weapon == dagger)
            {
                attack = 20;
            }
        }

        //creating the enemies class
        //reusing the enemy class to merge together with the combat class
        public int hp;
        public string Orc = "Orc";
        public string Giant = "Giant";
        public string Slime = "Slime";
        public string Dragon = "Dragon";
        public string Satan = "The Big Cheese";

        //creating the enemy constructor
        public int Enemy()
        {
            string enemy = " ";

            if (enemy == Orc)
            {
                hp = 200;
            }

            else if (enemy == Giant)
            {
                hp = 400;
            }

            else if (enemy == Slime)
            {
                hp = 50;
            }

            else if (enemy == Dragon)
            {
                hp = 800;
            }

            else if (enemy == Satan)
            {
                hp = 15000;
            }
            return hp;

        }

        //creating the actual combat constructor that will take the enemies hp, weapon stat and turn base option
        public static void Combat(string weapon)
        {
            //string enemy;

            WriteLine("An enemy appears before you, how do you respond?: \nrun or fight? ");
            string action = ReadLine();

            while (!action.Equals("run") && !action.Equals("fight"))
            {
                WriteLine("Please choose run or fight");
                action = ReadLine();
            }

            //if statements depending on what the user entered 
            //if the user entered run, return
            if (action.Equals("run"))
            {
                return;
            }

            //if the user chose to fight
            else if (action.Equals("fight"))
            {
                WriteLine("Press enter to roll for initiative: ");
                action = ReadLine();
                //creating the dice to see which enemy to fight
                Dice roll = new Dice();
                int enemyRoll = roll.D10();

                //showing what number the player rolled
                WriteLine(enemyRoll);

                //deciding which enemies will apear
                if (enemyRoll <= 4)
                {
                    WriteLine("A slime stands in front of you: ");

                }

                //else if it is above 4
                else if (enemyRoll >= 5 && enemyRoll <= 7)
                {
                    WriteLine("An Orc stands in front of you: ");
                }

                //else if it is higher than 7
                else if (enemyRoll >= 8 && enemyRoll <= 9)
                {
                    WriteLine("A Giant stands in front of you: ");
                }

                //if it is a 10
                else if (enemyRoll > 9)
                {
                    WriteLine("Unlucky, a Dragon stands in front of you: ");
                }
            }
        }
        
    }
    //creating the class for the dice roll
    public class Dice
    {

        //creating the method for rolling
        
        //creating the random object
        Random rand = new Random();
        public int num;
        //the 20 sided dice
        public int D20()
        {
            num = rand.Next(20);
            return num;
        }

        //the 12 sided dice
        public int D12()
        {
            num = rand.Next(12);
            return num;
        }

        //the 10 sided dice
        public int D10()
        {
            num = rand.Next(10);
            return num;
        }

        //8 sided dice
        public int D8()
        {
            num = rand.Next(8);
            return num;
        }

        //the 6 sided dice
        public int D6()
        {
            num = rand.Next(6);
            return num;
        }

        //the 4 sided dice
        public int D4()
        {
            num = rand.Next(4);
            return num;
        }
    }
}
