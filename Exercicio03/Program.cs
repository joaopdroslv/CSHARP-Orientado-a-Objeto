using Exercicio03;

Cliente c1 = new Cliente("JOAO PEDRO", 333, "28/03/2002"); //instânciando cliente

//instânciando contas corrente
ContaCorrente cc1 = new ContaCorrente(021, 2000, 500);
ContaCorrente cc2 = new ContaCorrente(077, 2500, 600);
ContaCorrente cc3 = new ContaCorrente(103, 3500, 800);

//atribuindo titular para contas corrente
cc1.Titular = c1;
cc2.Titular = c1;
cc2.Titular = c1;

//instânciando contas poupança
ContaPoupanca cp1 = new ContaPoupanca(033, 3000);
ContaPoupanca cp2 = new ContaPoupanca(069, 5700);
ContaPoupanca cp3 = new ContaPoupanca(217, 33300);

cp1.Titular = c1;
cp2.Titular = c1;
cp3.Titular = c1;

//criando list de contas correntes
List<ContaCorrente> VetCC = new List<ContaCorrente>();
VetCC.Add(cc1);
VetCC.Add(cc2);
VetCC.Add(cc3);

//criando list de contas poupança
List<ContaPoupanca> VetCP = new List<ContaPoupanca>();
VetCP.Add(cp1);
VetCP.Add(cp2);
VetCP.Add(cp3);

//instânciando banco
Banco b1 = new Banco("JP BANK", "Ativo",VetCC, VetCP);

b1.MostrarContas();

b1.DecretarFalencia();

b1.MostrarContas();

//TESTE CHEQUE ESPECIAL
/* ContaCorrente cc1 = new ContaCorrente(021, 2000, 500);

cc1.Sacar(2500);

cc1.Depositar(1000);

cc1.GerarExtrato(); */