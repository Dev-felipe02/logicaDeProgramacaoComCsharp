using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploPasagemDeParametroMetodo
    {
        static void SegundoMetodo(string fname)
        {
            Console.WriteLine(fname + " Silva");
        }

        //Multiplos Parametros
        static void TerceiroMetodo(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome}, e tenho {idade} anos.");
        }
        public static void Main(string[] args)
        {
            SegundoMetodo("Felipe");
            SegundoMetodo("Luccas");
            SegundoMetodo("Brenão");
            TerceiroMetodo("Felipe", 19);
            TerceiroMetodo("Larissa", 20);
        }
    }
}
