using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do litro do combustível: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância percorrida: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de litros gastos por Km: ");
            double n3 = double.Parse(Console.ReadLine());

            double resultado = n2 / n3 * n1;

            Console.WriteLine("O total gasto na viagem é: R$" + resultado);
            Console.ReadKey();

        }
    }
}
