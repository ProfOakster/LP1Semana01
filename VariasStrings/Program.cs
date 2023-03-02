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
            string aurora = "In this time of year\nIn this time of day";

            string scout = @"Allow C:\tierra\qliphort.exe ? <Y/N>...[Y]";

            string borealis = aurora + "\nIn this part of the country";
            borealis += "\nLocalized entirely within your kitchen?";

            byte answer = 21;
            string stupitt = $"What's 9 + 10?\n{answer}";
            byte val = 2;
            string quick_mafs = $"{val}+{val} is {val * 2} minus 1 that's {(val*2)-1}";
            string command= String.Format(
                "Command?\nFight{0} Spell{1}\nRun{0} Item{0}","\u274C","\u2705"
                );



            Console.WriteLine(steamed);
            Console.WriteLine(hams);
            Console.WriteLine(borealis);
            Console.WriteLine(scout);

            Console.WriteLine(borealis);
            Console.WriteLine(stupitt);
            Console.WriteLine(quick_mafs);
            Console.WriteLine(command);
            Console.WriteLine(
                "CL1 {0} target {1}, CL2 {1} target {0}", "Cir", "Dante"
                );
            
        }
    }
}
