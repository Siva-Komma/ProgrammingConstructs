using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    internal class ReverseWord
    {
        public static void Word(string stringInput)
        {
            string revword = "";
            int length=stringInput.Length-1;

            while(length>=0)
            {
                revword = revword + stringInput[length];
                length--;
            }
            Console.WriteLine(revword +"\n");
        }
    }
}
