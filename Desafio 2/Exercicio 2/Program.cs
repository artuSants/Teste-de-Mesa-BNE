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
            Console.WriteLine("Insira o valor a ser aplicado: ");
            double VP = double.Parse(Console.ReadLine());
            double n = 6;
            double i = 0.0125;
            double RendL, RendA, RendT = VP;
            for(int j = 0; j <n; j++)
            {
                RendL = (VP * Math.Pow(1+i,j))-VP;
                Console.WriteLine("Renda Liquida do mes "+ (j+1) +" = "+ RendL.ToString("C") );
                RendA = VP + RendL;
                Console.WriteLine("Renda Acumulada do mes " + (j+1) + " = " + RendA.ToString("C"));
                RendT = RendT + RendL;
                Console.WriteLine("Renda Total do mes " + (j+1) + " = " + RendT.ToString("C"));
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
