using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Value_1 :{a}\tValue_2 :{b}");
            Utilities.Swap(ref a, ref b);
            Console.WriteLine($"Value_1 :{a}\tValue_2 :{b}");

            Console.ReadKey();
        }
    }
}