using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class SubStringEIndexOF
    {
        public static void Main(string[] args)
        {
            string nome = "Salada de Fruta";
            
            int charPos = nome.IndexOf("d");

            string ultimoNome = nome.Substring(charPos);

            Console.WriteLine(ultimoNome);
        }
    }
}
