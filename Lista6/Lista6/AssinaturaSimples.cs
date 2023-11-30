namespace Lista6
{
    public class AssinaturaSimples : Assinatura
    {
        public override float CalcularPreco()
        {
            return 29.99f;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("Assinatura Simples: Acesso a filmes e séries em qualidade padrão.");
        }
    }
}