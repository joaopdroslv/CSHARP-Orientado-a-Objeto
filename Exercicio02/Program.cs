//função Main() implícita

using Exercicio02;

//criando venda
Venda v1 = new Venda();

//criando comprador
Comprador comprador1 = new Comprador(011, "JOSÉ PAULO", 100);

//criando vendedor
Vendedor vendedor1 = new Vendedor(037, "ANTONIO APARECIDO", 20);

//criando produtos
Produto p1 = new Produto(013, "CAFÉ", 19.99, 1);
Produto p2 = new Produto(078, "COCA-COLA", 6.50, 4);
Produto p3 = new Produto(054, "DESINFETANTE", 12.99, 1);

//adicionando comprador na v1
v1.Comprador = comprador1;

//adicionando vendedor na v1
v1.Vendedor = vendedor1;

//criando vetor de produtos na v1
v1.VetProd = new List<Produto>();

//adicionando produtos na v1
v1.VetProd.Add(p1);
v1.VetProd.Add(p2);
v1.VetProd.Add(p3);

//exibindo venda
v1.MostrarVenda();

//exibindo produtos da venda
foreach(Produto p in v1.VetProd) {
    p.MostrarProduto();
}
