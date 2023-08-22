using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoProjetoTrabalho
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens {get; private set;}
        public Orcamento()
        {
            Valor = 0;
            Itens = new List<Item>();
        }
        public void MostrarOrcamento()
        {
            Console.WriteLine("\nO valor do orçamento é: " + Valor);
        }
        public void MostrarItemOrcamento()
        {
            Console.WriteLine("\nExibindo os itens do orçamento:");
            foreach (Item item in Itens)
            {
                Console.WriteLine($"\tNome do item: {item.Nome} | Valor do item: {item.Valor}");
            }
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
        public void CalcularTotalOrcamento()
        {
            double total = 0;
            foreach (Item item in Itens)
            {
                total += item.Valor;
            }

            Valor = total;
        }
    }
}