using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ForeacheMatriz
    {
        public static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
