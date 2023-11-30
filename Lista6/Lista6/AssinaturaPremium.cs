namespace Lista6
{
    public class AssinaturaPremium : Assinatura
    {
        public override float CalcularPreco()
        {
            return 49.99f;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Assinatura Premium: Acesso a filmes e séries em qualidade HD e Ultra HD.");
        }
    }
}