using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class SumofSquares
    {
        public static void Square()
        {
            int sum = 0, i=1;
            Console.WriteLine("Enter Square range");
            int num=Convert.ToInt32(Console.ReadLine());

            while(i<=num)
            {
                sum += i * i;
                Console.WriteLine(sum);
                i++;
            }
        }
    }
}
