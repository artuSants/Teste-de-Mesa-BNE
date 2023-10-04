using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int[] v = new int[6];
            while (a<6) {
                v[a] = 10 * a;
                Console.WriteLine("v[a] = "+ v[a]);
                a += 1;
                Console.WriteLine("a = "+ a);
            }
            Console.ReadKey();
        }
    }
}
