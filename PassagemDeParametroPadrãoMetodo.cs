using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class PassagemDeParametroPadrãoMetodo
    {
        static void Pais(string pais = "Brasil")
        {
            Console.WriteLine(pais);
        }
        public static void Main(string[] args)
        {
            Pais("Venezuela");
            Pais("Cuba");
            Pais("Coreia do Norte");
            Pais("Russia");
            Pais();
            Pais("China");
        }
    }
}
