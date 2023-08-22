using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercHerancaFuncionario
{
    public class Horista : Funcionario
    {
        private int qtdeHorasSemana;
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }
        public
        public Horista(int matricula, string nome, long cpf, double sal)
        : base(matricula, nome, cpf, sal) 
        {

        }
    }
}