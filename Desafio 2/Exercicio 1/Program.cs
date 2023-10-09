using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor a ser aplicado: ");
            double VP = double.Parse(Console.ReadLine());
            Console.WriteLine("Isira o periodo em meses");
            double n = double.Parse(Console.ReadLine());
            double i = 0.053;
            double VF = VP * (Math.Pow(1 + i, n));
            Console.WriteLine("Valor Futuro = " + VF.ToString("C"));
            Console.ReadKey();
        }
    }
}
