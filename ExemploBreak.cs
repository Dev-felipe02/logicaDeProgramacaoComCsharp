using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploBreak
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
