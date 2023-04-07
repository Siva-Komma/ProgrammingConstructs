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
            Console.WriteLine("1.CheckTwoNumbers\n2.EvenorOdd\n3.Vote eligibility\n4.LargestNumber\n5.Eligibility Criteria\n6.WeekDay\n7.Arithmetic Operations\n8.PowerofTable\n9.SumofSquares\n10.Factorial\n11.FlipCoin\n12.Reverse Word\n13.SumofNNaturalNumbers");
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
                case 8:
                    PowerofTable.Table();
                    break;
                case 9:
                    SumofSquares.Square();
                    break;
                case 10:
                    Factorial.Fact();
                    break;
                case 11:
                    FlipCoin.Coin();
                    break;
                case 12:
                    ReverseWord.Word("Hello"); 
                    break;
                case 13:
                    SumofNaturalNumbers.NaturalNumbers();
                    break;
            }
            Console.ReadLine();
        }
    }
}
