﻿// função Main() implícita

using ArrayConta;

//declaração de vetor
Conta[] vetConta = new Conta[3];

for(int i = 0; i < vetConta.Length; i++)
{
    vetConta[i] = new Conta();
    Console.Write("Digite o número: ");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetConta[i].titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
}

foreach (Conta c in vetConta)
    c.MostrarAtributos();

for(int i = 0; i < vetConta.Length; i++)
    vetConta[i].MostrarAtributos();
