using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkAni
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCabin = long.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var currentPos = 0L;
            var oldPos = 0L;
            var steps = 0L;
            var allSteps = 0L;

            while (command!= "Found a free one!")
            {

                currentPos = (long.Parse(command) + currentPos) % numberOfCabin;
                steps = currentPos - oldPos;
                if (steps>0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(steps));
                }
                else if (steps<0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(steps));
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }
                allSteps += Math.Abs(steps);
                oldPos = currentPos;
                command = Console.ReadLine();
            }
            Console.WriteLine("Moved a total of {0} steps.", allSteps);
        }
    }
}
