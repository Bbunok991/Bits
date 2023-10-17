using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits b = new Bits(10L);

            byte by;
            int i;
            long l;
            Bits bit1 = 10L;
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(bit1);
            Console.ReadLine();
        }
    }
}
