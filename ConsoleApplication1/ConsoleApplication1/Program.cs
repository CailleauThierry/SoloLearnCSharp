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
            int age;
            Console.WriteLine("Enter a vlaue for age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value 16 or 42 or 70 will result in non-default case. Entered value was: {0}", age);

            switch (age)
            {
                case 16:
                    Console.WriteLine("Too young");
                    break;
                case 42:
                    Console.WriteLine("Adult");
                    break;
                case 70:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }
        }
    }
}