using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming Constructs");
            Console.WriteLine("1.CheckTwoNumbers\n2.EvenorOdd\n");
            Console.WriteLine("Choose your Option: ");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    CheckTwoNumbers.Numbers();
                    break;
                case 2:
                    EvenorOdd.CheckNumbersEvenorOdd();
                    break;
            }
            Console.ReadLine();
        }
    }
}
