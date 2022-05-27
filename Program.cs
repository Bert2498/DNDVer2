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
            //asking the user to enter the weapon of choice and saving it as pWeapon
            string pWeapon = Action.getWeapon();

            //using the combat method to simulate a fight
            Action.Combat(pWeapon);

            Console.Read();
        }
    }

    //creating the combat class
    public class Action : Dice
    {

        //creating the starting weapon method
        public static string getWeapon()
        {
            string[] weapons = { "axe", "sword", "katana", "claymore", "dagger" };

            //prompting the user to ener a weapon choice
            WriteLine("Please chose a weapon: " +
                "\naxe: " +
                "\nsword: " +
                "\nkatana: " +
                "\nclaymore: " +
                "\ndagger: ");
            //adding a space in between for aesthetic
            WriteLine();
            
            //asking the user to enter the weapon type
            string weapon = ReadLine();

            //seeing if the input is a correct weapon type
            while (!weapons.Contains(weapon))
            {
                WriteLine("No, " + weapon + " is not a weapon, try again >:( ");
                weapon = ReadLine();
            }
            //this is just to test
            //WriteLine(weapon);
            
            return weapon;
        }

        //creating a new method for the weapon damage
        public static int getWeaponDamage(string weapon)
        {
            int weaponDamage = 0;

            if (weapon.Equals("axe"))
            {
                weaponDamage = 75;
            }
            else if (weapon.Equals("sword"))
            {
                weaponDamage = 100;
            }
            else if (weapon.Equals("katana"))
            {
                weaponDamage = 200;
            }
            else if (weapon.Equals("claymore"))
            {
                weaponDamage = 250;
            }
            else if (weapon.Equals("dagger"))
            {
                weaponDamage = 50;
            }
            //for testing weapon damage
            //WriteLine("The weapon damage is " + weaponDamage);

            //returning the damage number 
            return weaponDamage;
        }
        //creating the method for setting the enemy health
        public static int getEnemyHP(string enemy)
        {
            //initializing health
            int enemyHealth = 0;

            if (enemy.Equals("orc"))
            {
                enemyHealth = 200;
            }

            else if (enemy.Equals("giant"))
            {
                enemyHealth = 400;
            }

            else if (enemy.Equals("slime"))
            {
                enemyHealth = 50;
            }

            else if (enemy.Equals("dragon"))
            {
                enemyHealth = 800;
            }

            else if (enemy.Equals("Satan"))
            {
                enemyHealth = 1500;
            }
            return enemyHealth;

        }

        //creating the actual combat constructor that will take the enemies hp, weapon stat and turn base option
        public static void Combat(string weapon)
        {
            //asking the user if they want to run or fight
            WriteLine("An enemy appears before you, how do you respond?: " +
                "\nrun or fight? ");

            //reading the users input
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
                //call the user a coward and send them back to the first prompt
                WriteLine("What a coward, but you live to see another day I guess.. ");
                
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
                WriteLine("You rolled a " + enemyRoll);

                //deciding which enemies will apear
                if (enemyRoll <= 4)
                {
                    WriteLine("A slime stands in front of you: ");
                    TurnCombat(weapon, "slime");

                }

                //else if it is above 4
                else if (enemyRoll >= 5 && enemyRoll <= 7)
                {
                    WriteLine("An Orc stands in front of you: ");
                    TurnCombat(weapon, "orc");
                }

                //else if it is higher than 7
                else if (enemyRoll >= 8 && enemyRoll <= 9)
                {
                    WriteLine("A Giant stands in front of you: ");
                    TurnCombat(weapon, "giant");
                }

                //if it is a 10
                else if (enemyRoll > 9)
                {
                    WriteLine("Unlucky, a Dragon stands in front of you: ");
                    TurnCombat(weapon, "dragon");
                }
            }
        }

        //creating the turn based combat method
        public static void TurnCombat(string weapon, string enemy)
        {
            //creating the int for the total health
            
            //testing to see if the weapon and enemy health are correct
            int weaponDamage = getWeaponDamage(weapon);

            //WriteLine("The weapon damage is " + weaponDamage);
            int enemyHealth = getEnemyHP(enemy);

            //WriteLine("Enemy HP is " + enemyHealth);

            //while the monster still has health, stay in combat mode
            while (enemyHealth > 0)
            {
                WriteLine("The enemy has " + enemyHealth + " health");
                WriteLine("Press enter to attack: ");
                ReadLine();
                enemyHealth = enemyHealth - weaponDamage;
            }

            //once the player defeats the enemy
            WriteLine("Congrats!! I mean, that " + enemy + " was pretty weak, but good job either way..");
            


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
