using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L04B
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatoria de todos numeros pares entre 1 a 500");
            int i = 2, somatoria = 0;

            do
            {
                somatoria = i + somatoria;
                i = i + 2;

            } while (i < 501);
            Console.WriteLine(somatoria);
        }
    }
}
