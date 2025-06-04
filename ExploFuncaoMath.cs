using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExploFuncaoMath
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o maior numero que está dentro dos parametros.
            Console.WriteLine(Math.Max(5, 10));

            //Matjh.Min mostra o menos numero que está dentro dos parametros.
            Console.WriteLine(Math.Min(5, 10));

            //Math.Sqrt mostra a raiz quadrada de um numero que está dentro do parametros.
            Console.WriteLine(Math.Sqrt(64));

            //Math.Abs retorna o valor absoluto de um numero que está dentro do parametros.
            Console.WriteLine(Math.Abs(-4.7));

            //Math.Round Arredonda o valor de numero que está dentro do parametros.
            Console.WriteLine(Math.Round(9.75));
        }
    }
}
