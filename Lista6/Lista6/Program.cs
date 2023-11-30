namespace Lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------Exercicio 1-----------------------");


            List<UnidadeMilitar> unidades = new List<UnidadeMilitar>();

            Soldado soldado = new Soldado();
            Arqueiro arqueiro = new Arqueiro();
            Cavaleiro cavaleiro = new Cavaleiro();

            unidades.Add(soldado);
            unidades.Add(arqueiro);
            unidades.Add(cavaleiro);

            foreach (var unidade in unidades)
            {
                unidade.Mover();
                unidade.Atacar();
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------Exercicio 2-----------------------");
            
            List<Assinatura> assinaturas = new List<Assinatura>();

            AssinaturaSimples assinaturaSimples = new AssinaturaSimples();
            AssinaturaPremium assinaturaPremium = new AssinaturaPremium();

            assinaturas.Add(assinaturaSimples);
            assinaturas.Add(assinaturaPremium);

            foreach (var assinatura in assinaturas)
            {
                Console.WriteLine($"Tipo: {assinatura.GetType().Name}");
                Console.WriteLine($"Preço: R$ {assinatura.CalcularPreco():F2}");
                assinatura.ExibirDetalhes();
                Console.WriteLine();
            }
        }
    }
}
