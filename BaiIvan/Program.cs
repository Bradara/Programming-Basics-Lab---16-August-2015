using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiIvan
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOfWeek = int.Parse(Console.ReadLine());
            var availableMoney = decimal.Parse(Console.ReadLine());
            var literWant = decimal.Parse(Console.ReadLine());

            var literCanBuy = 0.0m;
            var condition = "sober";

            switch (dayOfWeek)
            {
                case 0: literCanBuy = availableMoney / 25.0m;break;
                case 1: literCanBuy = availableMoney / 21.0m; break;
                case 2: literCanBuy = availableMoney / 14.0m; break;
                case 3: literCanBuy = availableMoney / 17.0m; break;
                case 4: literCanBuy = availableMoney / 45.0m; break;
                case 5: literCanBuy = availableMoney / 59.0m; break;
                case 6: literCanBuy = availableMoney / 42.0m; break;
            }
            if (literCanBuy>=1.5m)
            {
                condition = "very drunk";
            }
            else if (literCanBuy>=1.0m)
            {
                condition = "drunk";
            }

            if (literCanBuy>literWant)
            {
                Console.WriteLine("Bai Ivan is {0:f2} and very happy and he shared {1:f2} l. of alcohol with his friends",
                                  condition,
                                  literCanBuy-literWant);
            }
            else if (literCanBuy<literWant)
            {
                Console.WriteLine("Bai Ivan is {0:f2} and quite sad. He wanted to drink another {1:f2} l. of alcohol",
                                  condition,
                                  literWant-literCanBuy);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0:f2} and happy. He is as drunk as he wanted", condition);
            }
        }
    }
}
