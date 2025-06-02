using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L04A
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadrados dos numeros inteiros de 15 a 200");
            int i = 15, quadrados = 0;

            do
            {
                quadrados = i * i;
                Console.WriteLine($"{i}² = {quadrados}");
                i++;
            } while (i < 201);
        }
    }
}
