using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercício02Gemini
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior valor do array");
            double[] numeros = new double[4];
            int contador = 0;

            foreach (int i in numeros)
            {
                Console.WriteLine("Digite um numeros: ");
                numeros[contador] = Convert.ToDouble(Console.ReadLine());
                contador++;
            }
            Console.WriteLine($"O maior valor digitados é: {numeros.Max()}");
        }
    }
}
