using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        public string DtValidade { get; set; }
        public string DtFabricacao { get; set; }
        public int Lote { get; set; }
        public Perecivel(int cod, string nom, double preco, string dtVal, string dtFab, int lote) 
        : base(cod, nom, preco) //Atributos base da super classe
        {
            DtValidade = dtVal;
            DtFabricacao = dtFab;
            Lote = lote;
        }
        public override void Mostrar() 
        {
            base.Mostrar();
            Console.WriteLine($"\tData de Válidade: {DtValidade} \tData de Fabricação: {DtFabricacao} \tLote {Lote}");
        }
    }
}