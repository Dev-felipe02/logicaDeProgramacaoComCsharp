using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05D
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine($"A soma dos  numeros pares entre 1 a 500 é: {soma}");
        }
    }
}
