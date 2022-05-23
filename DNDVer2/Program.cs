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
            int roll20 = dice.D20();
            WriteLine(roll20);
            int roll12 = dice.D12();
            WriteLine(roll12);
            int roll10 = dice.D10();
            WriteLine(roll10);
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
