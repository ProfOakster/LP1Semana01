using System;

namespace ArgInt2Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            //cycles through the inputted arguments with var i as position tracker
            for (int i = 0; i < args.Length; i++)
            {
                //if argument is integer, will store its numeric value
                int value = 0;
                //checks if argument is integer and stores numeric value in var value
                bool integer = int.TryParse(args[i], out value);


                if (integer)
                {
                    //if integer, writes argument and its value in hex 
                    Console.WriteLine(
                        "{0} -> É inteiro, valor hexadecimal:{1,4:x}",args[i],value
                        );
                }
                else
                {
                    //if not integer, writes argument
                    Console.WriteLine("{0} -> Não é inteiro",args[i]);
                }

            }








            
        }
    }
}
