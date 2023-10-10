using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Juros
    {
        private double Principal;
        private double taxaMensal;

        public Juros(double principal, double taxaMensal)
        {
            this.Principal = principal;
            this.taxaMensal = taxaMensal;
        }
        public void  ImprimirTabela(double meses, double saque)
        {
            double VF = 0;
            int mesesInteiros = (int)meses;
            double mesesFracionarios = meses - mesesInteiros;
            Console.WriteLine($"| {"PERIODO",7} | {"VALOR INVESTIDO",15} | {"TAXA DE JUROS",12} | {"SAQUE",13} | {"VALOR FINAL",12} |");
            for (int i = 0; i < mesesInteiros; i++)
            {
                if (i == 4)
                {
                    VF -= saque;
                    Console.WriteLine($"| {i,7} | {Principal.ToString("c"),15} | {taxaMensal,12}% | {saque.ToString("c"),13} | {VF.ToString("c"),12} |");
                    Principal = VF;
                }
                else
                {
                    Console.WriteLine($"| {i,7} | {Principal.ToString("c"),15} | {taxaMensal,12}% | {0.ToString("c"),13} | {VF.ToString("c"),12} |");
                }
                VF = Principal * Math.Pow(1 + (taxaMensal / 100), i);
            }
            if (mesesFracionarios > 0)
            {
                double dias = meses % 10;
                VF += (Principal * Math.Pow(1 + (taxaMensal / 100), (meses % 10))) - Principal;
                Console.WriteLine($"| {mesesFracionarios,7:F1} | {Principal.ToString("c"),15} | {taxaMensal,12}% | {0.ToString("c"),13} | {VF.ToString("c"),12} |");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor a investir: ");
            double VP = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do juros: ");
            double taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o período (meses): ");
            double meses = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());


            Juros rendimento = new Juros(VP, taxa);

            rendimento.ImprimirTabela(meses, saque);
            Console.ReadKey();


        }
    }

}



