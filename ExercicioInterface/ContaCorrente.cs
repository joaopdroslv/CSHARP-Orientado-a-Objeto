namespace ExercicioInterface
{
    public class ContaCorrente : ITributavel
    {
        public int Codigo { get; set; }
        public string Proprietario { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente(int cod, string prop, double saldo)
        {
            Codigo = cod;
            Proprietario = prop;
            Saldo = saldo;
        }

        public double CalcularTributos()
        {
            return Saldo * 0.05;
        }
    }
}