using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Faccat08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o total de eleitores de um Municipio: ");
            float eleitores = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o total de votos validos desse Municipio: ");
            float validos = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o total de votos brancos desse Municipio: ");
            float brancos = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o total de votos nulos desse Municipio: ");
            float nulos = Convert.ToSingle(Console.ReadLine());
            float validosPerc = validos / eleitores * 100;
            float brancosPerc = brancos / eleitores * 100;
            float nulosPerc = nulos / eleitores * 100;
            Console.WriteLine($"O valor percentual de votos validos é {validosPerc}%");
            Console.WriteLine($"O valor percentual de votos brancos é {brancosPerc}%");
            Console.WriteLine($"O valor percentual de votos nulos é {nulosPerc}%");
        }
    }
}
