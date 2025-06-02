using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L04D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatoria do numero de grãos de trigo em um tabuleiro de xadrez");
            ulong i = 0, anterior = 1, atual = 1, somaTrigo = 0;

            do
            {
                atual = atual * 2;
                somaTrigo = atual + anterior;
                anterior = somaTrigo;
                i++;
            } while (i < 65);
            Console.WriteLine($"A somatoria dos grãos de trigo é: {somaTrigo}");
        }
    }
}
