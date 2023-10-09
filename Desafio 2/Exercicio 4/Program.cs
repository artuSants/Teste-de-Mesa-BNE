using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int periodo = 0;
            Console.WriteLine("Insira o valor a ser aplicado: ");
            double VP = double.Parse(Console.ReadLine());
            Console.WriteLine("Isira o periodo em meses: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Isira o valor da taxa(%): ");
            double i = double.Parse(Console.ReadLine()) / 100;
            double RendL, RendA, VF = VP, Saque = 0;
            for (int j = 0; j < 8; j++)
            {
                RendL = (VP * Math.Pow(1 + i, periodo)) - VP;
                RendA = VP + RendL;
                VF = VF + RendL;
                if (periodo == 4)
                {
                    Saque += 1000;
                    VF = RendA + RendL - Saque;
                    VP = VF;
                    periodo = 0;
                }
                
                Console.WriteLine("Rendimento Liquido no mes " + (j + 1) + " = " + RendL.ToString("C"));
                Console.WriteLine("Rendimento Acumulado no mes " + (j + 1) + " = " + RendA.ToString("C"));
                if(j == 4)
                {
                    Console.WriteLine("Saque de " + Saque.ToString("c") + " efetuado!");
                }
                Console.WriteLine("Valor Total no mes " + (j + 1) + " = " + VF.ToString("C"));
                Console.WriteLine("Pressione Enter para continuar!");
                Console.WriteLine();
                Console.ReadKey();
                periodo++;
            }
        }
    }
}
