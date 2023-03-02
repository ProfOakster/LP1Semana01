using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string steamed="Oh no\u274C, that isn't smoke.";
            string hams = "It's steam\u2705, from the Steamed Hams\u2122 we're having.";
            string borealis = "In this time of year\nIn this time of day";

            string scout = @"Allow C:\tierra\qliphort.exe ? <Y/N>...[Y]";

            Console.WriteLine(steamed);
            Console.WriteLine(hams);
            Console.WriteLine(borealis);
            Console.WriteLine(scout);
        }
    }
}
