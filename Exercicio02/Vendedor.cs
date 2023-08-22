using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Vendedor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Comissao { get; set; }

        public Vendedor(int cod, string n, double com) {
            Codigo = cod;
            Nome = n;
            Comissao = com;
        }
        public void MostrarVendedor() {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tComissão: " + Comissao);
        }
    }
}