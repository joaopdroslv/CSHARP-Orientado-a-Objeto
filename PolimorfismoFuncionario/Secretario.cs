using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Secretario : Funcionario //:Funcionario significa que Secretario herda de Funcionario
    {
        public int NumeroSecretario { get; set; }
        public Secretario(int codigo, string nome, double salario, int numsecr) //atributos da super classe
        //: base() referencia o construtor da super classe
        : base(codigo, nome, salario)  //necessário citar os atributos
        {
            NumeroSecretario = numsecr;
        }

        /* 
            Não é necessário citar o método da super classe, já é implicito que a classe filha
            herdara os métodos da super classe
        */

        /* 
            //override permite sobreescrever o método original da super classe
            public override double CalcularBonificacao()
            {
                //base.NomeDoMetodo significa que executara exatamente o mesmo método que existe na super classe
                return base.CalcularBonificacao(); 
            } 
        */
    }
}