using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercHerancaFuncionario
{
    public class Funcionario
    {
        protected int matricula;
        protected string nome;
        protected long cpf;
        protected double salario;
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = CalcularSalario(value); }
        }
        public Funcionario() {}
        public Funcionario(int matricula, string nome, long cpf, double sal)
        {
            Matricula = matricula;
            Nome = nome;
            Cpf = cpf;
            Salario = sal;
        }
        public virtual void MostrarFuncionario()
        {
            Console.WriteLine($"Matricula: {Matricula} | \tNome: {Nome} | \tCpf: {Cpf} | \tSalário: {Salario}");
        }

        public virtual double CalcularSalario(double value)
        {
            //Bonificação de R$ 250 aplicada a todos
            return value + 250;
        }
    }
}