using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class EvenorOdd
    {
        public static void CheckNumbersEvenorOdd()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("Even Number {0}", num);
            }
            else
            {
                Console.WriteLine("Odd Number {0}", num);
            }
        }
    }
}
