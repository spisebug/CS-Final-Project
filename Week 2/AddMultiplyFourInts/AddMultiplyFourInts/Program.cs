using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMultiplyFourInts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int int1 = 13, int2 = 55, int3 = 123, int4 = 325;
            int sum = int1 + int2 + int3 + int4;
            int product = int1 * int2 * int3 * int4;

            Console.WriteLine("Nikki Malmanger's Copy");
            Console.WriteLine($"The sum of {int1}, {int2}, {int3} and {int4} = {sum}");
            Console.WriteLine($"The product of {int1}, {int2}, {int3} and {int4} = {product}");
        }
    }
}
