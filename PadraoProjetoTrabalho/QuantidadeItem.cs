using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoProjetoTrabalho
{
    public class QuantidadeItem : Desconto
    {
        public double calcularDesconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5) {
                return orcamento.Valor * 0.10;
            } else {
                return orcamento.Valor * 0.07;
            }
        }
    }
}