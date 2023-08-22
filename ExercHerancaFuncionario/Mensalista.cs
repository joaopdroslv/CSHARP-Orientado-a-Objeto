using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercHerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        protected int qtdeHorasTrabalhadas;
        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        public Mensalista() {}
        public Mensalista(int matricula, string nome, long cpf, double sal, int qtdeHoras) 
        : base(matricula, nome, cpf, sal)
        {
            QtdeHorasTrabalhadas = qtdeHoras;
        }
        public override void MostrarFuncionario()
        {
            base.MostrarFuncionario();
            Console.WriteLine("\tQuantidade de horas trabalhadas: " + QtdeHorasTrabalhadas);
        }
        public override double CalcularSalario()
        {
            /*
                Quantidade de dias trabalhados: 22 dias;
                Valor do dia trabalhado: R$ 120;
            */
            return base.CalcularSalario() + QtdeHorasTrabalhadas / 22 * 120;
        }
    }
}