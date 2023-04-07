using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Factorial
    {
        public static void Fact()
        {
            int fact=1,i=1;
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());

            while(i<=num)
            {
                fact = fact * i;
                Console.WriteLine(fact);
                i++;
            }
        }
    }
}
