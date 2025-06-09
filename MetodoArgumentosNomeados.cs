using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class MetodoArgumentosNomeados
    {
        static void Criancas(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine($"A criança mais jovem é {crianca3}");
        }

        public static void Main(string[] args)
        {
            Criancas(crianca3: "Lorena", crianca1: "Clarice", crianca2: "Maysa");
        }
    }
}
