using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05C
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            for (int num = 1; num < 101;  num++)
            {
                soma = num + soma;
                Console.WriteLine($"A soma dos 100 primeiros numeros inteiros é = {soma}");
            }
        }
    }
}
