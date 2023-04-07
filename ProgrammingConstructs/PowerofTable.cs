using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class PowerofTable
    {
        public static void Table()
        {
            Console.WriteLine("Enter the 2 power table");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<num;i++)
            {
                double table = Math.Pow(2,i);
                Console.WriteLine($"2^{i}={table}");
            }
        }
    }
}
