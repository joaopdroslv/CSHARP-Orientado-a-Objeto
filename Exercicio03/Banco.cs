using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Banco
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public List<ContaCorrente> VetCC { get; set; }
        public List<ContaPoupanca> VetCP { get; set; }

        public Banco(string n, string e,List<ContaCorrente> cc, List<ContaPoupanca> cp)
        {
            Nome = n;
            Estado = e;
            VetCC = cc;
            VetCP = cp;
        }

        public void MostrarContas () {
            if (Estado == "Ativo") {
                Console.WriteLine("\nExibindo dados do Banco: " + Nome + " | Estado: " + Estado);
                Console.WriteLine("\nExibindo contas corrente!");
                foreach (ContaCorrente contaC in VetCC) {
                    contaC.GerarExtrato();
                }
                Console.WriteLine("\nExibindo contas poupança!");
                foreach (ContaPoupanca contaP in VetCP) {
                    contaP.MostrarAtributos();
                }
            } else {
                Console.WriteLine("\nO banco: " + Nome + " esta com falência decretada!");
            }
        }

        public void DecretarFalencia() {
            if (Estado == "Ativo") {
                Estado = "Inativo";

                Console.WriteLine("\nDecretando falência do banco: " + Nome);

                VetCC = null;
                VetCP = null;

            } 
        }
    }
}