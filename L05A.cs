using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05A
    {
        public static void Main(string[] args)
        {
            for (int i = 15; i < 201; i++)
            {
                int quadrado = i * i;
                Console.WriteLine($"{i}² = {quadrado}");
            }
        }
    }
}
