using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string DataNascimento { get; set; }    

        public Cliente(string n, int c, string dt)
        {
            Nome = n;
            Cpf = c;
            DataNascimento = dt;
        }
    }
}