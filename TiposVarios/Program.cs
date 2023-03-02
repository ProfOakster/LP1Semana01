using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            sbyte neg_smallest = -1;
            short neg_small = -1337;
            int neg_average = -1984;
            long neg_big = -5318008L;
            byte smallest = 1;
            ushort small = 1337;
            uint average = 1984U;
            ulong big = 5318008UL;

            char reverseR = '\u1D19';
            char deceased = '\u2620';

            float scientific = 3.1415F;
            double scientificer = 6.6784e-11;
            decimal scientificest = 6.022e23M;



            Console.WriteLine(neg_smallest);
            Console.WriteLine(neg_small);
            Console.WriteLine(neg_average);
            Console.WriteLine(neg_big);
            Console.WriteLine(smallest);
            Console.WriteLine(small);
            Console.WriteLine(average);
            Console.WriteLine(big);

            Console.WriteLine(reverseR);
            Console.WriteLine(deceased);

            Console.WriteLine(scientific);
            Console.WriteLine(scientificer);
            Console.WriteLine(scientificest);

            



        }
    }
}
