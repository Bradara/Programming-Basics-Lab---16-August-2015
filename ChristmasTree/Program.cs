using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1, k=n; i <= n; i+=2, k--)
            {
                Console.WriteLine("{0}{1}{0}",new string('\'',k), new string('^',i));

            }
            for (int i = 3, k = n-1; i <= n+2; i += 2, k--)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', k), new string('^', i));
            }
            for (int i = 0; i < n/2+1; i++)
            {
                Console.WriteLine("{0}| |{0}", new string('\'', n-1));
            }
            Console.WriteLine(new string('-', 2*n+1));
        }
    }
}
