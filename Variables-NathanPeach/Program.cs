using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_NathanPeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Introduction to Variables-");
            Console.WriteLine();

            //int = integer, integers are always whole numbers
            //float = decimals and/or fractions
            //string = stores strings of text

            //V V V V V Variable declaration V V V V V
            //Variable "score" declared as an integer, and set to = 0
            int score = 100;
            int enemyValue = 50;
            int turn = 0;
            //Note, adding the = 0 at the end is a seperate step, and used as a shortcut

            int lives = 2;
            //Amount of lives would be 5 for a fresh player
            int health = 75;
            //Maximum hp is 100 (important later)
            float survivalRate = ((lives) * (health)) / 100f;
            //On a fresh player, survivalRate should be 5.0 ((5 * 100) / 100)) = 5
            
            string realName;
            string GamerTag;
            //The shortcut "string realName = "Nathan Peach"" is not used for this example like above
            realName = "Nathan Peach";
            GamerTag = "PeachCubed";

            float percentile;
            percentile = (92434f / 380923f) * 100f;
            //Multiplied by 100 to show that it's a percent out of 100

            //Alternatively, score += enemyvalue; (shortcut)
            score = score + enemyValue;
            //The = sign sets the variable on the left equal to the complete varibale on the right ex:
            //score = 0 + 2, therefore score = 2
            
            Console.WriteLine("Welcome Back to Dungeon Crusher, " + GamerTag + " (" + realName + ")");
            Console.WriteLine("Global Rank: " + percentile + "%");
            Console.WriteLine("Current Survival Rate: " + survivalRate);

            //HUD
            Console.WriteLine("____________________________________");
            Console.WriteLine("Health: "+health+" Lives: "+lives+" Score: "+score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - TURN "+turn+" - - - - - - -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();
            
            //Events in between turns are here
            turn = turn + 1;
            //Enemy killed worth 50 points
            score = score + enemyValue;
            //Events in between turns are here

            Console.WriteLine("____________________________________");
            Console.WriteLine("Health: " + health + " Lives: " + lives + " Score: " + score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - TURN " + turn + " - - - - - - -");
            Console.WriteLine();
            Console.WriteLine(GamerTag+" has killed 1 enemy and gained 50 points!");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();

            //Events in between turns are here
            turn = turn + 1;
            //1 life is gained
            lives = lives + 1;
            //Events in between turns are here

            Console.WriteLine("____________________________________");
            Console.WriteLine("Health: " + health + " Lives: " + lives + " Score: " + score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - TURN " + turn + " - - - - - - -");
            Console.WriteLine();
            Console.WriteLine(GamerTag+" picked up a life!");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();

            //Events in between turns are here
            turn = turn + 1;
            //HP picked up
            health = health + 60;
            if (health > 100);
                {
                health = 100;
                }
            //Events in between turns are here

            Console.WriteLine("____________________________________");
            Console.WriteLine("Health: " + health + " Lives: " + lives + " Score: " + score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - TURN " + turn + " - - - - - - -");
            Console.WriteLine();
            Console.WriteLine(GamerTag + " used a health potion and gained 60 HP!");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();

            //Events in between turns are here
            turn = turn + 1;
            //Events in between turns are here

            Console.WriteLine("____________________________________");
            Console.WriteLine("Health: " + health + " Lives: " + lives + " Score: " + score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - TURN " + turn + " - - - - - - -");
            Console.WriteLine();
            Console.WriteLine(GamerTag + " escaped the Decrepit Ruins!");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine();
            Console.WriteLine("Final Stats:");
            survivalRate = ((lives) * (health)) / 100f;
            Console.WriteLine("Current Survival Rate: " + survivalRate);
            Console.WriteLine("Health: " + health + " Lives: " + lives + " Score: " + score);
            Console.WriteLine("Press any key to exit game --->");
            Console.ReadKey();
        }
    }
}
