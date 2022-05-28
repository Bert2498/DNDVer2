using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class CarsonDialog : Dice
    {
        public static void StartingDialoge()
        {
            Dice roll = new Dice();
            //creating the name string 
            string name;
            string response;
            int rolledNum;
            WriteLine("Hello traveler what is your name?: ");
            name = ReadLine();
            // Writes the dialogue for the entrance to the game
            WriteLine("Welcome {0}, to Heck", name);
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("Congratulations you are dead.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("Down here in heck, everything is decided by the rolling of dice. Every time you need to roll a dice, say 'roll' and our magical dice demons will eagerly roll them for you");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("If you wish to know the circumstances with which the cessation of your life has occured, say 'I guess', if you wish to continue on in blissful ignorance, say 'NO GOD PLEASE NO' >> ");
            response = ReadLine();

            //while the input is not either or 
            while (!response.Equals("I guess") && !response.Equals("NO GOD PLEASE NO"))
            {
                WriteLine("You're dead, get over it. Choose one >:( ");
                response = ReadLine();
            }

            //inserting the second line

            // determines whether or not to write the adventurerer's death 
            if (response.Equals("I guess"))
            {
                //prompts the uer to enter "roll"
                WriteLine("You have chosen rather seductively to know what caused your demise, very well.");
                WriteLine("Press enter: ");
                ReadLine();
                WriteLine("Roll a d6 >> ");
                response = ReadLine();
                while (!response.Equals("roll"))
                {
                    WriteLine("Say 'roll' >> ");
                    response = ReadLine();
                }
                // rolls a d6 to determine what the cause of death was
                WriteLine("You ");

                rolledNum = roll.D6();

                //if statement for each dice roll
                if (rolledNum == 1)
                {
                    Write("1: tripped over your own shoelaces while walking along the road, landed on your face, breaking your neck.");
                    WriteLine("Unfortuntely that is not when you died, all that did was paralyze you, you landed in a pile of human fecal matter, which blocked your airflow, suffocating you");
                }
                if (rolledNum == 2)
                {
                    Write("2: tried to get #SWOLE by sticking a leaf blower in your mouth and turning it on.");
                    WriteLine("We're still not sure quite what you expected to happened but your lungs blew up inside of your chest.");
                }
                if (rolledNum == 3)
                {
                    Write("3: borrowed your neighbor's kid's bicycle in order to run away from the cops, but the bike was very small and you ended up getting shot with 'nerf guns' in the forhead and run over thirteen times by police cruisers made out of 'balloons'.");
                    WriteLine("You jay-walked.");
                }
                if (rolledNum == 4)
                {
                    Write("4: ate too many cupcakes at your work's annual morale-boosting-so-you-won't-want-to-go-to-the-up-party, and had a heart attack.");
                }
                if (rolledNum == 5)
                {
                    Write("5: got mugged by an 87 year old woman named Beatrice. You didn't even try to fight back or anything you just let it happen, all while crying and peeing your pants in fear.");
                    WriteLine("You're actually kind of a legend down here, no one has ever responded that horribly to getting mugged by an old lady before.");
                }
                if (rolledNum == 6)
                {
                    Write("6: fell asleep next to your thirty three cats.");
                    WriteLine("They thought you were dead, so they ate you.");
                }
            }
            //adding the second part if the user picks the second option
            else if (response.Equals("NO GOD PLEASE NO"))
            {
                WriteLine("Golly gee alright then you didn't have to be so rude about it.");
            }
            WriteLine("Now before I continue, are you content with being dead, or do you want more out of life?");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("say 'yah no Im aight' or 'GIVE ME MORE' >> ");
            response = ReadLine();
            while (!response.Equals("yah no Im aight") && !response.Equals("GIVE ME MORE"))
            {
                WriteLine("say 'yah no Im aight' or 'GIVE ME MORE' >> ");
                response = ReadLine();
            }
            if (response.Equals("yah no Im aight"))
            {
                WriteLine("Oh, you .. you're alright? Huh. That's never happened before, so you just wanna stay down here and get tortured for all eternity? 'yeah sure, sounds peaceful' or 'oh nevermind then I want more' >> ");
                response = ReadLine();
                while (!response.Equals("oh nevermind then I want more") && !response.Equals("yeah sure, sounds peaceful"))
                {
                    WriteLine("you must enter either 'yeah sure, sounds peaceful' or 'oh nevermind then I want more' >> ");
                    response = ReadLine();
                }
                if (response.Equals("yeah sure, sounds peaceful"))
                {
                    WriteLine("Very well then, byyyyyyye");
                    WriteLine("Press enter: ");
                    ReadLine();
                    WriteLine("GAME OVER NOOB");
                    return;
                }
                else if (response.Equals("GIVE ME MORE"))
                {
                    WriteLine("Oh goody, I just knew you'd change your mind.");
                }
                //inserting the final piece of the puzzle to finish his story line
                WriteLine("Wonderful, now I have a business proposition for you, there's this guy named 'BrAd' who's a real sleaze bag, total butt stain of a guy, I mean really just a walking sack of Richards.");
                WriteLine("Press enter: ");
                ReadLine();
                WriteLine("I need you to kill him");
                WriteLine("Press enter: ");
                ReadLine();
                WriteLine("Now you may be thinking, 'What, isnt this Heck? How am I supposed to kill this dude if he's already dead?' but fret not you tiny insecure little thing, for I have an answer!!");
                WriteLine("Press enter: ");
                ReadLine();
                WriteLine("It doesnt matter now shut up and go do what I say.");
                WriteLine("Press enter: ");
                ReadLine();
                WriteLine("*COUH COUGH YOURE TOTALLY GONNA FAIL AND GET STUCK HERE FOR ETERNITY TO GET TORTURED* Ahem apologies, there's a sort of dry spell going on right now.");
            }
            WriteLine("So you set off on this perilous journey.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("On your quest to find and kill Brad, you endure blistering winds and scorching deserts.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("You climbed to the highest bloody room in the tallest bloody tower.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("And what do you find? Some really hot wolf man in a suit telling you that Brad is already dead!!!");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("Now you have a choice, live forever with this absolute HUNK Mr. Wolf, or go back to Big Poppa Satan and tell him of your failure.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("Fortunately for you, you dont actually have a choice and you're going to roll a dice heavily weighted against your favor, good luuuck.");
            WriteLine("Press enter: ");
            ReadLine();
            WriteLine("now roll the d20!!! >> ");
            response = ReadLine();
            while (response.Equals("roll"))
            {
                WriteLine("YOU HAVE TO SAY 'roll' YOU DONT HAVE A CHOICE");
                response = ReadLine();
            }

            rolledNum = roll.D20();
            if (rolledNum < 19)
            {
                WriteLine("HA LOSER YOU GOTTA GO BACK TO SATAN AND GET TORTURED FOREVER YOU SUCK EVERYONE HATES YOU THEY ALL SAY THEY DONT BUT THEY DO");
            }
            else
            {
                WriteLine("Aw man you get to go life with the beautiful steed that is Mr. Wolf, but believe you me one day we will get you, AND YOUR LITTLE DOG TOO!!!");
            }
            WriteLine("");
            WriteLine("");
        }
    }
}
