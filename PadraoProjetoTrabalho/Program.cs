// Método Main()

using PadraoProjetoTrabalho;
// O orçamento pode receber um desconto de acordo com o tipo
// da venda que será efetuada.
// Se o cliente comprar mais de 5 itens, ele recebe 10% de desconto;
// se ele fez uma compra casada de alguns produtos, recebe 7%
// de desconto e assim por diante.

Item it1 = new Item("mouse", 100.10);
Item it2 = new Item("pendrive", 80.90);
Item it3 = new Item("monitor", 950.99);
Item it4 = new Item("impressora", 2000.55);
Item it5 = new Item("rj45", 1.09);
Item it6 = new Item("cadeira", 500.34);

Orcamento orcamento = new Orcamento();

orcamento.AdicionarItem(it1);
orcamento.AdicionarItem(it2);
orcamento.AdicionarItem(it3);
//orcamento.AdicionarItem(it4);
orcamento.AdicionarItem(it5);
//orcamento.AdicionarItem(it6);

orcamento.CalcularTotalOrcamento();
orcamento.MostrarOrcamento();
orcamento.MostrarItemOrcamento();

CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
Console.WriteLine("\nO total do desconto é: " + calculadora.Calcular(orcamento));

