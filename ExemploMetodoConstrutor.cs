using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ExemploMetodoConstrutor
    {
        public string Modelo;

        public ExemploMetodoConstrutor()
        {
            Modelo = "Opala";
        }

        public static void Main(string[] args)
        {
            ExemploMetodoConstrutor Chevrollet = new ExemploMetodoConstrutor();
            Console.WriteLine(Chevrollet.Modelo);
        }
    }
}
