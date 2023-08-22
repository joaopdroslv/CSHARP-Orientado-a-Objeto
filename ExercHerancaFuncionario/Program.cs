/*
    *Crie a superclasse Funcionário
    *Crie uma subclasse Mensalista(qtdeHorasTrabalhadas)
    *Crie outra subclasse Horista(qtdeHorasSemana)
    *Crie o construtor de todas as classes
    *Crie um método para CalcularSalario(), para utilizar o polimorfismo
        e com lógica que você pensar
    *Na main() instanciar um objeto referente a cada classe usando os construtores
*/

using ExercHerancaFuncionario;

//Para declarar dessa forma, é necessário um construtor vazio na classe
Funcionario func1 = new Funcionario();
func1.Salario = 33; 
func1.Nome = "JOÃO PEDRO"; 
func1.Cpf = 62497313209;
func1.Salario = 3400.99;
func1.MostrarFuncionario();

/*METODO CALCULAR SALÁRIO EXIGE UM PARAMETRO, VAI DA B.O NO POLIMOSFISMO*/
Mensalista mens1 = new Mensalista();
mens1.Matricula = 44; 
mens1.Nome = "YASMIN SILVA";
mens1.Cpf = 89713455681;
mens1.QtdeHorasTrabalhadas = 170;
mens1 = CalcularSalario(890.90);
mens1.MostrarFuncionario();