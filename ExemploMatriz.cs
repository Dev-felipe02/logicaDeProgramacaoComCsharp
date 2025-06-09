using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(numero[0, 1]);
            Console.WriteLine(numero[1, 0]);

            // Alterar elemento de uma matriz

            numero[1, 0] = 9;
            Console.WriteLine(numero[1, 0]);
        }
    }
}
