using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class L05G
    {
        public static void Main(string[] args)
        {
            long exp = 0;
            long exp2 = 0;
            long i = 1;
            
            long contador = 2;

            Console.WriteLine("3^0 = 1");
            Console.WriteLine("3^1 = 3");
            

            for (i = 1; i < 16; i++)
            {

                exp = 3 * (3 * i);
                exp2 = 3 * exp;
                
                Console.WriteLine($"3^{contador} = {exp}");

                contador++;
            }
        }
    }
}
