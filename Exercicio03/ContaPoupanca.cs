using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class ContaPoupanca
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public ContaPoupanca(int n, double s)
        {   
            Numero = n;
            Saldo = s;
        }

        public void MostrarAtributos() {
            Console.WriteLine($"Número: {Numero} | Saldo: R$ {Saldo}");
        }

        public void Depositar (double val) {
            if (val > 0) {
                Saldo += val;
                Console.WriteLine("Depósito efetuado com sucesso!");
            } else {
                Console.WriteLine("Valor de deposito deve ser maior que zero!");
            }
        }

        public void Sacar (double val) {
            if (val > 0) {
                if (val > Saldo) {
                    Console.WriteLine("Valor inválido, ultrapassa saldo da conta!");
                } else {
                    Saldo -= val;
                    Console.WriteLine("Saque efetuado com sucesso!");
                }
            } else {
                Console.WriteLine("O valor de saque deve ser maior que zero.");
            }
        }

        public void GerarRendimento (double rend) {
            double valRend = Saldo * (rend / 100);
            Saldo += valRend;
            Console.WriteLine("Rendimento aplicado com sucesso!");
            Console.WriteLine("Total rendido: " + valRend);
            Console.WriteLine("Novo saldo: " + Saldo);
        }
    }
}