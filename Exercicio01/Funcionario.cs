using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; set; } = 100;

        public Funcionario(int cod, string nome, double sal) {
        
            Codigo = cod;
            Nome = nome;
            Salario = sal;

            Contador++;
        }

        public void MostrarFuncionario() {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        } 

        public void Reajuste(double porc) {
            double novoSal = Salario + (Salario * porc / 100);
            Salario = novoSal;
        }
    }
}