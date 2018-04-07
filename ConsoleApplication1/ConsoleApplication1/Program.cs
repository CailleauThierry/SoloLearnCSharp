using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 3;
            if (x>y)
            {
                Console.WriteLine(" x is: {0}\n y is: {1}", x, y);
                Console.WriteLine(" x is greater than y by: {0}", (x-y));
            }

        }
    }
}
