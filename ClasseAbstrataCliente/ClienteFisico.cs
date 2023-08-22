using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public string Cpf { get; set; }
        public ClienteFisico(int codigo, string nome, string cpf) 
        : base(codigo, nome)
        {
            Cpf = cpf;
        }
        public override void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Cpf: {Cpf}");
        }
    }
}