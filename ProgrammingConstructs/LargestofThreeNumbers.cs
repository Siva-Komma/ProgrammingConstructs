using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class LargestofThreeNumbers
    {
        public static void LargestNumber()
        {
            int[] arr = new int[3] {100,100,30};
            
            if (arr[0] >= arr[1] && arr[0] >= arr[2])
            {
                 Console.WriteLine($"First Number {arr[0]} is larger than Second Number {arr[1]} and Third Number {arr[2]}");
            }
            else if (arr[1] >= arr[2])
            {
                 Console.WriteLine($"Second Number {arr[1]} is Larger than First Number {arr[0]} and Third Number {arr[2]}");
            }
            else
            {
                 Console.WriteLine($"Third Number {arr[2]} is Larger than First Number {arr[0]} and Second Number {arr[1]}");
            }
        }
    }
}
