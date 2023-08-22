using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;           
        }
        /*
            A palavra abstract na frente do método, faz com que
            a subclasse seja obrigada a implementar o método,
            ou seja, a lógica do método sera implementada de acordo
            com a necessidade da subclasse. (Polimorfismo)
        */
        public abstract void Mostrar();
    }
}