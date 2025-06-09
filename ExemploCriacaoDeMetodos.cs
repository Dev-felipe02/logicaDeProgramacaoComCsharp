using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploCriacaoDeMetodos
    {
        static void MeuMetodo()
        {
            Console.WriteLine("Isso é um exemplo para criação de metodos");
        }
        public static void Main(string[] args)
        {
            MeuMetodo();
            MeuMetodo();
            MeuMetodo();
        }
    }
}
