using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class WeekDay
    {
        public static void Day()
        {
            Console.WriteLine("Enter Day");
            int day = Convert.ToInt32(Console.ReadLine());

            switch(day)
            {
                case 1: 
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thuresday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturesday");
                    break;
                default:
                    Console.WriteLine("Enter Correct Days not more than 1-7");
                    break;
            }
        }
    }
}
