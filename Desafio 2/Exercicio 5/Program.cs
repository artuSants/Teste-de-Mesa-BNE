using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor que deseja atingir: ");
            double VF = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do juros: ");
            double taxa = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("Insira o periodo: ");
            double periodo = double.Parse(Console.ReadLine());

            double VP = VF / Math.Pow(1 + taxa, periodo);
            Console.WriteLine("Para atingir "+VF.ToString("c")+" Você precisará investir "+VP.ToString("c"));
            Console.ReadKey();
        }
    }
}
