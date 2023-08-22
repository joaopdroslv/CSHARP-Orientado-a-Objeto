using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int cod, string n, double p, int tam)
        {
            Codigo = cod;
            Nome = n;
            Preco = p;
            Quantidade = tam;
        }

        public void MostrarProduto() {
            Console.WriteLine($"Código: " + Codigo + "\tNome: " + Nome + "\tPreço: " + Preco + "\tQuantidade: " + Quantidade);
        }
    }
}