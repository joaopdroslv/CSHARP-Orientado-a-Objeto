//função Main()

using ExercicioInterface;

ContaCorrente conta1 = new ContaCorrente(11, "JOÃO PEDRO", 2450.99);

SeguroDeVida seguro1 = new SeguroDeVida();

TotalizadorDeAtributos totalizador1 = new TotalizadorDeAtributos();
totalizador1.Adicionar(conta1);
totalizador1.Adicionar(seguro1);

Console.WriteLine($"O total é:  " + totalizador1.Total);
