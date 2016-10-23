using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            var batteryInitial = Console.ReadLine();
            var batteryStart = 0;
            if (batteryInitial.Length == 4)
            {
                batteryStart = int.Parse(batteryInitial.Substring(0, 3));
            }
            else if (batteryInitial.Length == 3)
            {
                batteryStart = int.Parse(batteryInitial.Substring(0, 2));
            }
            else
            {
                batteryStart = int.Parse(batteryInitial.Substring(0, 1));
            }
            
            string processes = Console.ReadLine();
            var batteryStat = batteryStart;
           // bool needCharge = false;
            bool phoneOff = true;
            var countProgram = 0;

            while (processes.ToLower() != "end" )
            {
                var proces = int.Parse(processes.Substring((processes.Length - 3), 2));

                if (batteryStat > 15)
                {
                    phoneOff = false;
                    batteryStat = batteryStat - proces;
                    if (batteryStat <= 15 && batteryStat > 0)
                    {
                      //  needCharge = true;
                    }
                    else if (batteryStat <= 0)
                    {
                        phoneOff = true;
                    }
                }
                else if (batteryStat <= 15 && batteryStat > 0)
                {
                    //  needCharge = true;
                    countProgram++;
                }
                else
                {
                    phoneOff = true;
                    countProgram++;
                }

                processes = Console.ReadLine();
            }

            if (batteryStat>15)
            {
                Console.WriteLine("Successful complete -> {0}%", batteryStat);
            }
            else if (batteryStat <= 15 && phoneOff==false)
            {
                Console.WriteLine("Connect charger -> {0}%", batteryStat);
                Console.WriteLine("Programs left -> {0}", countProgram);
            }
            else if (batteryStat <= 15 && phoneOff == true)
            {
                Console.WriteLine("Phone Off");
            }
        }
    }
}
