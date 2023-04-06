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
            Console.WriteLine("1.CheckTwoNumbers\n2.EvenorOdd\n3.Vote eligibility\n4.LargestNumber\n5.Eligibility Criteria\n6.WeekDay\n7.Arithmetic Operations");
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
                case 3:
                    VoteEligibility.Age();
                    break;
                case 4:
                    LargestofThreeNumbers.LargestNumber();
                    break;
                case 5:
                    EligibilityCriteria.Marks();
                    break;
                case 6:
                    WeekDay.Day();
                    break;
                case 7:
                    ArithmeticOperations.Operations();
                    break;
            }
            Console.ReadLine();
        }
    }
}
