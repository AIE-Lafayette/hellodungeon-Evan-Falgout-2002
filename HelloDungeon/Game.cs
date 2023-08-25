using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            // Player Stat Numbers
            float Health = 100.0f;
            float Defense = 25.0f;
            int Luck = 1;
            int Strength = 1;
            int intellect = 1;
            int speed = 1;
            float Magus = 100.0f;
            float dmg = 5.5f;
            float critchance = 3.0f;

            //Class Weapons

            // Player State of Being/Game State
            bool PlayerAlive = true;
            // Welcomes Player into game and allows Player to name Character and pick Character class
            Console.WriteLine("In the land of Ertuum you awake in a haze.");
            Console.WriteLine("You slowly come to your senses and notice a figure moving toward you.");
            Console.WriteLine(" You prepare yourself for conflict, However you let your guard down when they stop.");
            Console.WriteLine(" With a puzzled expression they ask 'Who are You?' ");
            string name = Console.ReadLine();
            Console.WriteLine("Now that i know your name what is your aptitude?");
            Console.WriteLine("1.Mage");
            Console.WriteLine("2.Knight");
            Console.WriteLine("3.Rogue");

            string playerchoice = Console.ReadLine();

            if (playerchoice == "1" || playerchoice == "Mage") 
            {
                Health = 75.0f;
                Defense = 25.0f;
                Magus = 150.0f;
                dmg = 15.0f;
                critchance = 1.2f;
                Luck = 2;
                Strength = 5;
                intellect = 8;
                speed = 6;

                Console.WriteLine ( name + "Has Chosen Mage");
                         }
            if (playerchoice == "2" || playerchoice == "Knight")
            {
                Health = 100.0f;
                Defense = 75.0f;
                Magus = 20.0f;
                dmg = 25.0f;
                critchance = 2.5f;
                Luck = 4;
                Strength = 8;
                intellect = 3;
                speed = 4;

                Console.WriteLine( name + " Has Chosen Knight");  
            }
            if (playerchoice == "3" || playerchoice == "Rogue")
            {
                Health = 75.0f;
                Defense = 50.0f;
                Magus = 50.0f;
                dmg = 20.0f;
                critchance = 5.0f;
                Luck = 6;
                Strength = 4;
                intellect = 5;
                speed = 8;

                Console.WriteLine(name + "has chosen Rogue");

            }

             // Story Cont...
            Console.WriteLine("Well" + name);
            Console.WriteLine("I would not recommend sleeping on the ground my friend.");
            Console.WriteLine("My name is Nio Sef but my friends call me Mr.Anderson");
            Console.WriteLine("I only jest.");
            Console.WriteLine("I run the local inn so its my job to get acquainted with all new faces i come across");
            Console.WriteLine("Would you like to accompany me to the inn" + name + "?");

            






        }
    }
}
