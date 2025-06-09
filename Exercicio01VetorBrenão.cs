using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Exercicio01VetorBrenão
    {
        public static void Main(string[] args)
        {
            int[] numero = { 9, 6, 4, 7, 2 };
            int soma = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                soma = soma + numero[i];

                Console.WriteLine(numero[i]);
            }
            Console.WriteLine(soma);
        }
    }
}
