using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Comprador
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Verba { get; set; }

        public Comprador(int cod, string n, double verba)
        {
            Codigo = cod;
            Nome = n;
            Verba = verba;
        }

        public void MostrarComprador() {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tVerba: " + Verba);
        }
    }
}