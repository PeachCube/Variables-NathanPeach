﻿using System;
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
            Console.WriteLine("-Variables-");
            Console.WriteLine();
            
            //Variable "score" declared as an integer, and set to = 0
            int score = 0;
            //Note, adding the = 0 at the end is a seperate step, and used as a shortcut
            int enemyValue = 250;


            string realName;
            string GamerTag;
            //The shortcut "string realName = "Nathan Peach"" is not used for this example
            realName = "Nathan Peach";
            GamerTag = "PeachCubed";
            
            float percentile;
            percentile = 92434f / 380923f;
            
            //Alternatively, score += enemyvalue; (shortcut)
            score = score + enemyValue;
            //The = sign sets the variable on the left equal to the complete varibale on the right ex:
            //score = 0 + 2, therefore score = 2


            Console.WriteLine("Welcome, "+GamerTag);
            //
            Console.WriteLine("Current Score: "+score);
            //
            Console.WriteLine("Percentile Rank: " + percentile);
            
            Console.WriteLine("Press any key to continue --->");
            Console.ReadKey();


        }
    }
}
