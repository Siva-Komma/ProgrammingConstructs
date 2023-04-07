using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumofNaturalNumbers
    {
        public static void NaturalNumbers()
        {
            int sum = 0;
            Console.WriteLine("Enter Range of numbers");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<=num;i++)
            {
                 sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
}
