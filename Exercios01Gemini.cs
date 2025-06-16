using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercios01Gemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somar todos elementos de uma array");

            double[] numeros = new double[5];

            Console.WriteLine("Digite o primeiro valor");
            foreach(int i in numeros)
            {
                numeros[1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o próximo valor");
            }
            Console.WriteLine($"\nA soma de todos os numeros digitados é {numeros.Sum()}");
        }
    }
}
