using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
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
        public double CalculaRendimento(double meses, double saque)
        {
            double VF = 0;
            for(int i = 0; i < (int)meses;i++)
            {
                if(i == 4)
                {
                    VF -= saque;
                    Principal = VF;
                }
                VF = Principal * Math.Pow(1 + (taxaMensal / 100), i);
            }
            if (meses % 10 > 0)
            {
                VF += (Principal * Math.Pow(1 + (taxaMensal / 100), (meses % 10)))-Principal;
            }
            return VF;
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

            double ValorFinal = rendimento.CalculaRendimento(meses, saque);

            Console.WriteLine("O rendimento final foi de: " + ValorFinal.ToString("c"));
            Console.ReadKey();

        }
    }

}



