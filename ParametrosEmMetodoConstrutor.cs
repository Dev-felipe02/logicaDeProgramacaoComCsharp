using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDeCsharp
{
    internal class ParametrosEmMetodoConstrutor
    {
        public string modelo;

        public ParametrosEmMetodoConstrutor(string nomeModelo)
            {
                modelo = nomeModelo;
            }

        public static void Main(string[] args)
            {
                ParametrosEmMetodoConstrutor Ford = new ParametrosEmMetodoConstrutor("Mustang");
                Console.WriteLine(Ford.modelo);
            }
    }   
}
