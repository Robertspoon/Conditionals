using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");
            Console.WriteLine();

            string gamertag;
            int score;
            score = 0;
            gamertag = "Spoon";

            if(gamertag == "Spoon")
            {
                score = 100000000;
            }



            Console.WriteLine("score: " + score);
            if (score == 0)
            {
                Console.WriteLine("why cruel world");

            }
            else if (score > 100)
            {
                Console.WriteLine("I need mental help");
            }

            else
            {
                Console.WriteLine("I AM NOT CRAZY!");
            }



            Console.ReadKey(true);
        }
    }
}
