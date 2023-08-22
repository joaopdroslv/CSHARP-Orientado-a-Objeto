//função Main()

using TratamentoExcessaoConta;

Conta conta = new Conta(33, "JOÃO PEDRO", 2450);
conta.MostrarConta(); // Antes de tentar depositar

try
{
    conta.Depositar(-500); // Não pode permitir o depósito - PASSED
}
catch (ArgumentException)
{
    Console.WriteLine("\nArgumento Inválido!");
}

conta.MostrarConta(); // Depois de tentar depositar