using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L03C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatoria de todos numeros pares de 1 a 500!");
            int i = 2, totalSoma = 0;

            while (i < 501)
            {
                totalSoma = i + totalSoma;
                i = i + 2;
            }
            Console.WriteLine($"A soma é igual a: {totalSoma}");
        }
    }
}
