namespace Lista8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carnivoro leao = new Carnivoro("Leão");
            leao.ExibirDescricao();
            leao.Cacar();

            Console.WriteLine();

            Herbivoro girafa = new Herbivoro("Girafa");
            girafa.ExibirDescricao();
            girafa.Pastar();

            Console.WriteLine();

            Onivoro urso = new Onivoro("Ser Humano");
            urso.ExibirDescricao();
            urso.Comer();
        }
    }
}
