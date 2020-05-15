namespace CalculoImposto.Entities
{
    abstract class Rendimentos
    {

        public string Nome { get; set; }
        public double Faturamento { get; set; }

        public Rendimentos()
        {
        }

        public Rendimentos(string nome, double faturamento)
        {
            Nome = nome;
            Faturamento = faturamento;
        }

        public abstract double TotalImposto();
        
        

    }
}
