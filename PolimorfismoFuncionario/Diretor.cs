using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario)
        : base(codigo, nome, salario) {}

        public override double CalcularBonificacao()
        {
            //Chama o método padrão da super classe, depois modifica a resposta
            return base.CalcularBonificacao() + 1000;
        }
    }
}