using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class CheckTwoNumbers
    {
        public static void Numbers()
        {
            Console.WriteLine("Enter FirstNumber");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2= Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("Both numbers are Equal num1 {0} and num2 {1}",num1,num2);
            }
            else
            {
                Console.WriteLine("Both Lines are not Equal num1 {0} and num2 {1}",num1,num2);
            }
        }
    }
}
