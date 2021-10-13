using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZBUZZ
{
    class Program
    {
        static string output = "";
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                output = "";
                if ((i % 3) == 0) { output += "FIZZ"; }
                if ((i % 5) == 0) { output += "BUZZ"; }
                if ((i % 7) == 0) { output += "FUZZ"; }
                else if ((i % 3) != 0 && (i % 5) != 0 && (i % 7)!= 0) { output = i.ToString(); }
                Console.WriteLine(output);
                Console.ReadKey(true);
            }
        }
    }
}
