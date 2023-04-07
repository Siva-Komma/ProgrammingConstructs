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
            int sum = 0;
            Console.WriteLine("Enter Square range");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num;i++)
            {
                sum += i * i;
                Console.WriteLine(sum);
            }
        }
    }
}
