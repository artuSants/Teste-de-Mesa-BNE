using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = a - 6;
            int[] v = new int[6];
            Console.WriteLine("b = "+ b);
            while (b<a)
            {
                v[b] = b + a;
                Console.WriteLine("v[b] = "+ v[b]);
                b = b + 2;
                Console.WriteLine("b = " + b);
            }
            Console.ReadKey();
        }
    }
}
