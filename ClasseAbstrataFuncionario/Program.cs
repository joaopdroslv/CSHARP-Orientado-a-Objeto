//main()

using ClasseAbstrataFuncionario;

// Instânciando funcionário - PASSED
Comissionado f1 = new Comissionado(33, "JOÃO PEDRO", 2000, 0.20);
f1.CalcularSalario(24);
Comissionado f2 = new Comissionado(44, "YASMIN DAINEZE", 2000, 0.20);
f2.CalcularSalario(24);
Comissionado f3 = new Comissionado(55, "JOSÉ DA SILVA", 2000, 0.20);
f3.CalcularSalario(24);
Assalariado f4 = new Assalariado(66, "EYDE PEDRO", 3000);
f4.CalcularSalario(24);
Assalariado f5 = new Assalariado(77, "VALÉRIA CRISTINA", 3000);
f5.CalcularSalario(24);
Assalariado f6 = new Assalariado(88, "BRENDON FEITOSA", 3000);
f6.CalcularSalario(24);

// Instânciando departamento - PASSED
Departamento dep1 = new Departamento(302, "Atendimento");

// Admitindo funcionário - PASSED
dep1.Admitir(f1);
dep1.Admitir(f2);
dep1.Admitir(f3);

// Listando funcionário - PASSED
dep1.ListarFuncionarios();

// Instânciando departamento - PASSED
Departamento dep2 = new Departamento(403, "Financeiro");

// Admitindo funcionário - PASSED
dep2.Admitir(f4);
dep2.Admitir(f5);
dep2.Admitir(f6);

// Listando funcionário - PASSED
dep2.ListarFuncionarios();

// Demitindo funcionário - PASSED
/* 
    dep1.Demitir(33);
    dep3.Demitir(111);
    dep3.Demitir(122);

    Console.WriteLine("\n****Após a exclusão****");
    dep1.ListarFuncionarios();
    dep2.ListarFuncionarios();
    dep3.ListarFuncionarios(); 
*/

// Exibindo folha de pagamento - PASSED
Console.WriteLine("\n****Folha de pagamento dos pertamentos****\n");
Console.WriteLine($"Departamento: {dep1.Descricao} \t| Folha: {dep1.CalcularFolha(24):C}");
Console.WriteLine($"Departamento: {dep2.Descricao} \t| Folha: {dep2.CalcularFolha(24):C}");

// Instânciando dependente - PASSED
Dependente depen1 = new Dependente(913, "RAFAEL BERTASSO", 15);
Dependente depen2 = new Dependente(781, "ENZO GABRIEL", 21);
Dependente depen3 = new Dependente(981, "IGOR GONÇALVES", 11);
Dependente depen4 = new Dependente(113, "VIKTOR HERNANDEZ", 19);

// Adicionando dependentes ao funcionário - PASSED
f1.AdicionarDependente(depen1);
f1.AdicionarDependente(depen2);
f1.AdicionarDependente(depen3);
f1.AdicionarDependente(depen4);

// Exibindo dependente - PASSED
f1.ListarDependentes();

// Removendo dependentes maiores de idade - PASSED
    // A respeito do método RemoverDependente - Tinha feito de uma forma que removeria 
    // automaticamento todos os maiores de idade, mas vi no exercício que é pedido um código
    // de dependente como parâmetro, então alterei pra forma atual do método.

f1.RemoverDependente(981); // Não deve retirar menor de idade - PASSED
f1.RemoverDependente(781); // Retirar maior de idade - PASSED
f1.RemoverDependente(113); // Retirar maior de idade - PASSED
f1.ListarDependentes();

// Contando quantidade de dependentes de um departamento - PASSED
dep1.MostrarQtdeDependentes(); // Aqui deve printar 2 dependentes - PASSED

// Adicionando mais dependentes ao departamento1 para validar
// se método MostrarQtdeDependentes() está correto
Dependente depen5 = new Dependente(913, "RAFAEL BERTASSO", 15);
Dependente depen6 = new Dependente(913, "RAFAEL BERTASSO", 15);
Dependente depen7 = new Dependente(913, "RAFAEL BERTASSO", 15);
Dependente depen8 = new Dependente(913, "RAFAEL BERTASSO", 15);
f2.AdicionarDependente(depen5);
f2.AdicionarDependente(depen6);
f2.AdicionarDependente(depen7);
f2.AdicionarDependente(depen8);

// f1 tem 3 dependentes | f2 tem 4 dependentes
dep1.MostrarQtdeDependentes(); // Aqui deve printar 6 dependentes - PASSED