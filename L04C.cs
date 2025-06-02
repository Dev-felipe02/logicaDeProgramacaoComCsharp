using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L04C
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numeros divisiveis por 4 menores que 200");
            int i = 1;

            do
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 201);
        }
    }
}
