using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TratamentoExcessaoConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Proprietario { get; set; }
        public double Saldo { get; set; }
        public Conta(int num, string prop, double saldo)
        {
            Numero = num;
            Proprietario = prop;
            Saldo = saldo;
        }
        public void MostrarConta()
        {
            Console.WriteLine($"\nNúmero: {Numero} | Nome proprietário: {Proprietario} | Saldo: {Saldo}");
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();
            else
                Saldo += valor;
                Console.WriteLine("\nDepósito realizado com sucesso!");
        }
    }
}