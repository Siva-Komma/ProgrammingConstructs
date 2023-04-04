using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class VoteEligibility
    {
        public static void Age()
        {
            Console.WriteLine("Enter Age");
            int age =Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine($"Candidate eligible for Voting: {age}");
            }
            else
            {
                Console.WriteLine($"Candidate not eligible for Voting: {age}");
            }
        }
    }
}
