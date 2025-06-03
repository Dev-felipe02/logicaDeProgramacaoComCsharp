using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Faccat10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do custo de fabrica de um carro: ");
            double fabrica = Convert.ToSingle(Console.ReadLine());
            double custoFinal = (0.28 * fabrica) + (0.45 * fabrica) + fabrica;
            Console.WriteLine($"O custo final deste carro ira ficar em R${custoFinal}");
        }
    }
}
