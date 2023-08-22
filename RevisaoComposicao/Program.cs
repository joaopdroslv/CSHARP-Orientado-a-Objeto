using RevisaoComposicao;

Contatos c1 = new Contatos("PEDRO", "PEDRO@GMAIL.COM","111");
Contatos c2 = new Contatos("JOSÉ", "JOSE@GMAIL.COM","222");
Contatos c3 = new Contatos("RAFAELA", "RAFAELA@GMAIL.COM","333");
Contatos c4 = new Contatos("GABRIEL", "GABRIEL@GMAIL.COM","444");

List<Contatos> vet1 = new List<Contatos>();
vet1.Add(c1);
vet1.Add(c2);
CatalogoContatos cat1 = new CatalogoContatos("TurmaPOO", vet1);
Console.WriteLine("\nNome do catalogo: " + cat1.NomeCatalogo + "....");
cat1.ExibirContatos();

List<Contatos> vet2 = new List<Contatos>();
vet2.Add(c3);
vet2.Add(c4);
CatalogoContatos cat2 = new CatalogoContatos("TurmaBancoDeDados",vet2);
Console.WriteLine("\nNome do catalogo: " + cat2.NomeCatalogo + "....");
cat2.ExibirContatos();

//As linhas abaixo são OPCIONAIS para o programador
cat1 = null; //Retirada a referência de memória do objeto
cat2 = null;
GC.Collect(); //Chamada do coletor de lixo