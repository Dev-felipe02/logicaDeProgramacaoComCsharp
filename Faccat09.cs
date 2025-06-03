using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Faccat09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de seu salario atual: ");
            float salario = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite o valor percentual do reajuste do seu salario: ");
            float reajuste = Convert.ToSingle(Console.ReadLine());
            float salarioReaj = (reajuste / 100 * salario) + salario;
            Console.WriteLine($"O valor do novo seu novo salario é: R${salarioReaj}");
        }
    }
}
