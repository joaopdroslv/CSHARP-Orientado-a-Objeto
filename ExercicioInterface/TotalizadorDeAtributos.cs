namespace ExercicioInterface
{
    public class TotalizadorDeAtributos
    {
        public double Total { get; private set; }
        public void Adicionar(ITributavel t)
        {
            this.Total += t.CalcularTributos();
        }
    }
}