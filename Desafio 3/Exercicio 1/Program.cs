using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Juros
    {
        private decimal Principal;
        private double taxaMensal;

        public Juros(decimal principal, double taxaMensal)
        {
            this.Principal = principal;
            this.taxaMensal = taxaMensal;
        }
        public decimal CalculaRendimento(double meses)
        {
            decimal VF = Principal * (decimal)Math.Pow(1+(taxaMensal/100), meses);
            return VF;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor a investir: ");
            decimal VP = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do juros: ");
            double taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o período (meses): ");
            double meses = double.Parse(Console.ReadLine());

            Juros rendimento = new Juros(VP, taxa);

            decimal ValorFinal = rendimento.CalculaRendimento(meses);

            Console.WriteLine("O rendimento final foi de: " + ValorFinal.ToString("c"));
            Console.ReadKey();

        }
    }
    
}

    

