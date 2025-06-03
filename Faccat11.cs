using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Faccat11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salario fixo por mes: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o numero de carros vendidos por você: ");
            float carrosVendidos = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor total das suas vendas: ");
            double valorVendas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor que você por carro vendido: ");
            double valorCarros = Convert.ToDouble(Console.ReadLine());
            double salarioFinal = salario + carrosVendidos * valorCarros + 0.5 * valorVendas;
            Console.WriteLine($"O salario final do vendedor é R${salarioFinal}");
        }
    }
}
