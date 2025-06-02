using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L03B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatoria dos 100 primeiros numeros inteiros!");
            int i = 1, totalSoma = 0;

            while(i < 101)
            {
                totalSoma = i + totalSoma;
                i++;
            }
            Console.WriteLine($"A soma é igual a: {totalSoma}");
        } 
    }
}
