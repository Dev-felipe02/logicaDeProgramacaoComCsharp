using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05F
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 201; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"Todos os numeros divisiveis por 4 é: {i}");
                }
            }
        }
    }
}
