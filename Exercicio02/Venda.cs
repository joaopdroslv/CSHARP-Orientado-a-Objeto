using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Venda
    {
        public static int Codigo { get; set; }
        public Comprador Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> VetProd { get; set; }

        static Venda() {
            Codigo = 0;
        }

        public Venda() {
            Codigo ++;
        }

        public void MostrarVenda() {
            Console.WriteLine("\n************ Exbindo venda! ************");
            Console.WriteLine("\nCódigo da venda: " + Codigo);
            Comprador.MostrarComprador();
            Vendedor.MostrarVendedor();
        }
    }
}