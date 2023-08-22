// funçao main()
using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Funcionário", 1000);
Console.WriteLine($"{f.Nome} - Bonificação {f.CalcularBonificacao():C}");

Secretario s = new Secretario(1, "Secretário", 1000, 33);
Console.WriteLine($"{s.Nome} - Bonificação {s.CalcularBonificacao():C}");

Gerente g = new Gerente(1, "Gerente", 1000);
Console.WriteLine($"{g.Nome} - Bonificação {g.CalcularBonificacao():C}");

Diretor d = new Diretor(1, "Diretor", 1000);
Console.WriteLine($"{d.Nome} - Bonificação {d.CalcularBonificacao():C}");