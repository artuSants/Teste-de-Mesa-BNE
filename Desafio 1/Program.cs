using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = (a + b) / 2;
            c = c - 40;
            int[] v = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    v[i] = a + b + c;
                }
            }
            Console.WriteLine(v[3]);
            Console.ReadKey();
        }
    }
}
