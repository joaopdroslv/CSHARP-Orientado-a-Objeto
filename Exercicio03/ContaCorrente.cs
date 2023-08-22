using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double ChequeEspecial { get; set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int n, double s, double c)
        {
            Numero = n;
            Saldo = s;
            ChequeEspecial = c;
        }

        public void GerarExtrato() {
            Console.WriteLine($"Número: {Numero} | Saldo: R$ {Saldo} | Cheque Especial: R$ {ChequeEspecial}");
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
                    double Abs = Math.Abs(Saldo - val);
                    if (Abs > ChequeEspecial) {
                        Console.WriteLine("Valor inválido, ultrapassa limite do cheque especial!");
                    } else {
                        Saldo -= val;
                        Console.WriteLine("Saque efetuado com sucesso!");
                        Console.WriteLine("Novo saldo: | \t" + Saldo);
                    }
                } else {
                    Saldo = Saldo - val;
                    Console.WriteLine("Saque efetuado com sucesso!");
                    Console.WriteLine("Novo saldo: | \t" + Saldo);
                }
            } else {
                Console.WriteLine("O valor de saque deve ser maior que zero.");
            }
        }
    }
}