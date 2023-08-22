
using Exercicio01;

Funcionario f1 = new Funcionario(Funcionario.Contador, "JOÃO", 2500);

Funcionario f2 = new Funcionario(Funcionario.Contador, "RENAN", 3000);

Funcionario f3 = new Funcionario(Funcionario.Contador, "PEDRO", 4000);

f1.MostrarFuncionario();
f1.Reajuste(15);
f1.MostrarFuncionario();

f2.MostrarFuncionario();
f2.Reajuste(12);
f2.MostrarFuncionario();

f3.MostrarFuncionario();
f3.Reajuste(10);
f3.MostrarFuncionario();