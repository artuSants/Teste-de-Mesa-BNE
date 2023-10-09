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
            Console.WriteLine("Insira o valor a ser aplicado: ");
            double VP = double.Parse(Console.ReadLine());
            Console.WriteLine("Isira o periodo em meses: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Isira o valor da taxa(%): ");
            double i = double.Parse(Console.ReadLine())/100;
            double VF = VP * (Math.Pow(1 + i, n));
            Console.WriteLine("Rendimento = " + VF.ToString("C"));
            Console.ReadKey();
        }
    }
}
