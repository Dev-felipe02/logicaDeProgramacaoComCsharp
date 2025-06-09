using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ReturnMetodo
    {
        static int Soma(int x)
        {
            return 5 + x;
        }

        //Multiplos parametros

        static int Multiplicacao(int x, int y)
        {
            return x * y;
        }
        public static void Main(string[] args)
        {
            int z = Multiplicacao(5, 9);
            Console.WriteLine(Soma(2));
            Console.WriteLine(Multiplicacao(5, 10));
            Console.WriteLine(z);
        }
    }
}
