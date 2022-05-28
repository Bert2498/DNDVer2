using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing the Diaog class
            CarsonDialog.StartingDialoge();

            //asking the user to enter the weapon of choice and saving it as pWeapon
            string pWeapon = Action.getWeapon();

            //using the combat method to simulate a fight
            Action.Combat(pWeapon);

            Console.Read();
        }
    }
}
