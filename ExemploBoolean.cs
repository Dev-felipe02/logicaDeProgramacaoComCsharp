using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploBoolean
    {
        public static void Main(string[] args)
        {
            int myAge = 25;
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("Pode votar");
            }
            else
            {
                Console.WriteLine("Não pode votar");
            }
        }
    }
}
