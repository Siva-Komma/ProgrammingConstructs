using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class EligibilityCriteria
    {
        public static void Marks()
        {
            int Totalmarks = 0;
            Console.WriteLine("Enter Physics marks");
            int Physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks");
            int Chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks");
            int maths = Convert.ToInt32(Console.ReadLine());

            Totalmarks = Physics + Chemistry + maths;
            Console.WriteLine($"Total Marks {Totalmarks}");


            if (Physics >= 55 && Chemistry >= 51 && maths >= 65)
            {
                if (Totalmarks >= 180)
                {
                    Console.WriteLine("Candidate Eligible");
                }
                else
                {
                    Console.WriteLine("Candidate not eligible");
                }
            }
            else if (maths + Physics >= 140 || maths + Chemistry >= 140)
            {
                Console.WriteLine("Candidate Eligible");
            }
            else
            {
                Console.WriteLine("Candidate not eligible");
            }
        }
    }
}
