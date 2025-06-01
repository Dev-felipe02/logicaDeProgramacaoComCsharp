using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class Faccat07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento e veja ela em dias!");
            Console.WriteLine("Digite o dia que você nasceu: ");
            int dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o mes que você nasceu: ");
            int mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o ano que você nasceu: ");
            int ano = Convert.ToInt16(Console.ReadLine());
            int anoDias = (2025 - ano) * 365;
            int mesDias = mes * 30;
            int idadeDias = dia + mesDias + anoDias;
            Console.WriteLine($"Sua idade em dias é: {idadeDias}");

        }
    }
}
