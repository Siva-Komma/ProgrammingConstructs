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
            int fact=1;
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num;i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);
            }
        }
    }
}
