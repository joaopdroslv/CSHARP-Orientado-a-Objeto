//main()

using ClasseAbstrataCliente;

// Não é possível instância objetos da classe abstrata
/* Cliente c1 = new Cliente(33, "JOÃO PEDRO"); */

ClienteFisico cf = new ClienteFisico(33, "JOÃO PEDRO", "111.222.333-44");
cf.Mostrar();