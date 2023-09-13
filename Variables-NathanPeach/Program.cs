using System;
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
            
            //Variable "score" declared as an integer, and set to = 0
            int score = 0;
            //Note, adding the = 0 at the end is a seperate step, and used as a shortcut
            int enemyValue = 250;

            int lives = 2;
            //maximum lives would be 5 for a fresh player
            int health = 75;
            //maximum hp would be 100
            float survivalRate = (5 - lives) / (100 - health);
            
            
            string realName;
            string GamerTag;
            //The shortcut "string realName = "Nathan Peach"" is not used for this example
            realName = "Nathan Peach";
            GamerTag = "PeachCubed";
            
            float percentile;
            percentile = (92434f / 380923f) * 100f;
            //Multiplied by 100 to show that it's a percent out of 100
            
            //Alternatively, score += enemyvalue; (shortcut)
            score = score + enemyValue;
            //The = sign sets the variable on the left equal to the complete varibale on the right ex:
            //score = 0 + 2, therefore score = 2

            Console.WriteLine("Welcome, "+GamerTag+ " ("+realName+")");
            Console.WriteLine("Current Score: "+score);
            Console.WriteLine("Percentile Rank: " + percentile +"%");
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();


        }
    }
}
