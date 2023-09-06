using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloDungeon
{
    class Game
    {

        Random random = new Random();
       bool gameover=false;

        //EnemyValue
        float enmDmg = 1.0f;
        float EnmHealth = 1.0f;
        bool EnemyEncounter = false;
        string enemyname = "";


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
        int Scenenumber = 0;
        string playerchoice = "";
        string name = "";

        // Player State of Being/Game State
        bool PlayerAlive = true;

        void PrintStats()
        {
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Defense: " + Defense); 
            Console.WriteLine("Luck: " + Luck + "\nStrength: " + Strength + "\n Intellect: " + intellect + "\n Speed: " + speed + "\n Magus: " + Magus + "\n Damage: "+ dmg + "\n CritChance: "+ critchance); 
            return;
        }
        string DisplayMenu(string prompt, string options1, string option2, string option3 )
        {
            playerchoice = "";
            while (playerchoice != "1" && playerchoice != "2" && playerchoice != "3")
            {
                //Display Prompt
                Console.Clear();
                Console.WriteLine(prompt);
                //Display options
                Console.WriteLine("1." + options1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);

                
                
                //Player input
                Console.Write(">");
                playerchoice = Console.ReadLine();


                //Display error message
                if (playerchoice != "1" && playerchoice != "2" && playerchoice != "3")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    Console.ReadKey(true);
                    Console.WriteLine("press any key to continue");

                }
                
            }
            return playerchoice;

        }
        void BattleSystem()
        {
            
            Random random = new Random();
            int rand = random.Next(1, 100);


            String BattleChoice = "";
           
            while (Health>0 && EnmHealth>0)
            {

                // Battle UI
                Console.WriteLine(" ====================================");
                Console.WriteLine("| 1. Light Attack    2. Heavy Attack |");
                Console.WriteLine("| 3. Dodge           4. Block        | ");
                Console.WriteLine("|            5. Heal                 |");
                Console.WriteLine(" ====================================");
                Console.WriteLine("Health: " + Health);
                Console.WriteLine(enemyname + "Health: " + EnmHealth);
                BattleChoice=Console.ReadLine();

                if (BattleChoice == "1" + (rand<=75))
                {
                    //Quick Attack Success
                    Console.WriteLine(" You Dash Forward and Strike Your Enemy Twice in Quick Succession");
                    Console.WriteLine("You Were to Quick For The Enemy To React");
                    Console.WriteLine("You deal" + dmg + "and prepare for your opponents next move");
                    Console.ReadKey();
                }

                else if (BattleChoice == "1" + (rand <= 25))
                {
                    //Quick Attack Fail
                    Console.WriteLine(" You Dash Forward and Strike at Your Enemy Twice in Quick Succession");
                    Console.WriteLine(" Your oppenent anticipated a hasty strike and countered");
                    Console.WriteLine("Enemey Deals" + dmg + "You lose" + Health);
                    Console.ReadKey();
                } 
                if(BattleChoice == "2" + (rand <=25))
                {
                    //Heavy Attack Crit
                     Console.WriteLine("You wind up for a heavyblow and" + "THWACK!!" + "Dealt" + dmg*2);
                    Console.WriteLine("Enemy falls down and loses" + EnmHealth);
                    Console.ReadKey();
                }
                else if(BattleChoice == "2" + (rand<=50))
                {
                    //Heavy Attack Success
                    Console.WriteLine("You wind up for a heavyblow and" + "Dealt" + dmg);
                    Console.WriteLine("Enemy stumbles but collects himself hastily" + "Loses" +EnmHealth);
                    Console.ReadKey();
                }
                else if(BattleChoice == "2" + (rand <= 25))
                {
                    // Heavy Attack Fail
                    Console.WriteLine("Enemy saw your attack from a mile away and dodged");
                    Console.WriteLine("Battle Returns to Still");
                    Console.ReadKey();
                }
                if (BattleChoice == "3" + (rand<=50))
                {
                    // DOdge Success
                    Console.WriteLine("Quick on your feet you saw your enemy make his move before they did");
                    Console.WriteLine("You avoided his blow this time");
                    Console.ReadKey();
                }
                else if (BattleChoice == "3" + (rand <= 50))
                { 
                    // DOdge Fail
                    Console.WriteLine("Quick on your feet you saw your enemy make his move before they did");
                    Console.WriteLine("However you were to slow to avoid his blow");
                    Console.WriteLine("You lost" + Health);
                    Console.ReadKey();

                }
                if (BattleChoice == "4" + (rand <= 100))
                {
                    // Block Damage
                    Console.WriteLine("You Block their strike and return to still");
                    Console.ReadKey();
                }
                if ( BattleChoice == "5" + (rand <= 100))
                {
                    // Health Spell
                    Console.WriteLine("Holding your palms to your heart you shout 'Salutem recuperandam'");
                    Console.WriteLine("You Recover" + Health);
                    Console.ReadKey();

                }


                

            }


        }
        void OpeningScene()
        {

            // Welcomes Player into game and allows Player to name Character and pick Character class
            Console.WriteLine("In the land of Ertuum you awake in a haze.");
            Console.WriteLine("You slowly come to your senses and notice a figure moving toward you.");
            Console.WriteLine("You prepare yourself for conflict, However you let your guard down when they stop.");
            Console.WriteLine("With a puzzled expression they ask 'Who are You?' ");
            Console.Write(">");
            // loop that allows player to Rename character
            while (playerchoice != "1")
            {




                name = Console.ReadLine();


                Console.WriteLine("So " + name + " is that correct?");

                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Console.Write(">");

                playerchoice = Console.ReadLine();
                Console.Write(">");

                if (playerchoice == "1")
                {
                    Console.WriteLine("Nice to meet you " + name + ".");
                }

                else if (playerchoice == "2")
                {
                    Console.WriteLine("I see your just waking up so who are you really?");
                }

            }
        }
        void Scene1()
        {
            bool ClassSelected = false;
            while (ClassSelected == false)
            {
                Scenenumber = 2;
                playerchoice = DisplayMenu("Now that i know your name what is your aptitude?", "Mage", "Knight", "Rogue");

                //Mage Stats
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

                    Console.WriteLine(name + "Has Chosen Mage");
                    PrintStats();

                }
                //Knight Stats
                else if (playerchoice == "2" || playerchoice == "Knight")
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

                    Console.WriteLine(name + " Has Chosen Knight");
                    PrintStats();
                }
                //Rogue Stats
                else if (playerchoice == "3" || playerchoice == "Rogue")
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
                    PrintStats();

                }






                Console.WriteLine("Is this the class you wish to be?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                playerchoice = Console.ReadLine();



                if (playerchoice == "1")
                {
                    ClassSelected = true;
                }
                if (playerchoice == "2")
                {

                }


            }
        }
        void Scene2()
        {

            // Story Cont...
            Console.WriteLine("Well" + name);
            Console.WriteLine("I would not recommend sleeping on the ground my friend.");
            Console.WriteLine("My name is Nio Sef but my friends call me Mr.Anderson");
            Console.WriteLine("I only jest.");
            Console.WriteLine("I run the local inn so its my job to get acquainted with all new faces i come across");


            // Player 1st choice
            DisplayMenu("Would you like to accompany me to the inn" + name + "?", " Accompany Nio to the Inn and Start the Tutorial", "Skip the tutorial and Find Your own way in the land of Ertuum", "Punch Nio");
            Console.Clear();

            if (playerchoice == "1")
            {
                //BarFight!!


                Console.WriteLine("The Inn is alive with bards and drunkards singing their songs." +
                    "You and Nio make way to the bar and accidentally bump shoulders with a large oaf of a man named Frank." +
                    "His Face visibly steaming he says' You made me spill my ale; know I'm going to spill your guts'" +
                    "He throws a Right hook and you back up ready to engage.");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("Soon you find your self swarmed by large smelly drunks." +
                    "You grab a chair and smack one of Franks' pals." +
                    "He falls unconscience." +
                    "Nio Takes a sip of ale and Frank snatches it and throws it toward" + name +
                    "." +
                    "You catch the glass and see one of the smelly oafs is charging toward you." +
                    "You slip to the side and lay out foot intent on tripping him.");
                Console.ReadKey(true);
                Console.Clear();
                Console.WriteLine("The Smelly oaf falls to his face and you pour the ale on his swollen head." +
                    "You see that only Frank remains and you wave come see taunting him." +
                    "Frank flexes his arms and you meet in the center of the room." +
                    "Frank takes a step foward to throw a jab  and you flinch." +
                    "Frank feined his jab and knocked you out with an overhand.");
                Console.ReadKey(true);
                Console.Clear();

                playerchoice = DisplayMenu("End Of Game Preview: Do you want to play again?", "Yes", "No", "Maybe Later When the game is actually finished");




            }
            if (playerchoice == "2")
            {
                playerchoice = DisplayMenu("End Of Game Preview: Do you want to play again?", "Yes", "No", "Maybe Later When the game is actually finished");

            }
            if (playerchoice == "3")
            {
                playerchoice = DisplayMenu("End Of Game Preview: Do you want to play again?", "Yes", "No", "Maybe Later When the game is actually finished");
            }

        }

        public void Run()
        {
           
            
            OpeningScene();


            Scene1();

            Scene2();








            
        }
    }
}
