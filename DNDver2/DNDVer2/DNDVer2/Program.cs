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
            Dice dice = new Dice();
            string input = ReadLine();
            Enemy en = new Enemy(input);
            WriteLine(en.hp);
                    
        }
    }
    

    //creating the enemies class
    class Enemy
    {
        public int hp { get; set;}  
        public string Orc = "Orc";
        public string Giant = "Giant";
        public string Slime = "Slime";
        public string Dragon = "Dragon";
        public string Satan = "The Big Cheese";

        //creating the enemy constructor
        public Enemy(string enemy)
        {
            if (enemy == Orc)
            {
                this.hp = 200;
            }

            else if (enemy == Giant)
            {
                this.hp = 400;
            }

            else if (enemy == Slime)
            {
                this.hp = 50;
            }

            else if (enemy == Dragon)
            {
                this.hp = 800;
            }

            else if (enemy == Satan)
            {
                this.hp = 15000;
            }

        }
    }
    //creating the class for the dice roll
    class Dice
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
