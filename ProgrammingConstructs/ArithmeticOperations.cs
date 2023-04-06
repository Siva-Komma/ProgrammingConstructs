using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class ArithmeticOperations
    {
        public static void Operations()
        {
            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your Operations");
            int Option=Convert.ToInt32(Console.ReadLine());

            switch(Option)
            {
                case 1:
                    int Sum = num1 + num2;
                    Console.WriteLine($"Sum of two Numbers {Sum}");
                    break;
                case 2:
                    int Sub = num1 - num2;
                    Console.WriteLine($"Subtraction of two Numbers {Sub}");
                    break;
                case 3:
                    int Mul = num1 * num2;
                    Console.WriteLine($"Multiplication of two Numbers {Mul}");
                    break;
                case 4:
                    int Div = num1 / num2;
                    Console.WriteLine($"Division of two Numbers {Div}");
                    break;
            }
        }
    }
}
