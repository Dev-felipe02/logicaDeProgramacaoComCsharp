using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05E
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (!(i %  2 == 0))
                {
                    Console.WriteLine($"Os numeros impares entre 0 e 20 é: {i}");
                }
            }
        }
    }
}
