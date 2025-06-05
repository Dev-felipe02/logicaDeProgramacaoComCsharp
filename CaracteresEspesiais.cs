using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class CaracteresEspesiais
    {
        public static void Main(string[] args)
        {
            string txt1 = "Jesus\tNome";
            string txt2 = "Jesus\nNome";
            string txt3 = "Jesus\b Nome";

            Console.WriteLine(txt1);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);

        }
    }
}
