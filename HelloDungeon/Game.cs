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
            int Strength= 1;
            // Player State of Being/Game State
            bool PlayerAlive = true;
            
            // Welcomes Player into game and allows Player to name Character
            Console.WriteLine("In the land of Ertuum you awake in a haze." +
                " You slowly come to your senses and notice someone walking towards you." +
                " You prepare yourself for conflict, However you let your guard down when they stop." +
                " With a puzzled expression they ask 'Who are You?' ");
            string name =Console.ReadLine();
            // Game Cont...
            Console.WriteLine("Well" + name + "I would not recommend sleeping on the ground my friend." +
                "My Name is NPC");
            


           
               
        }
    }
}
