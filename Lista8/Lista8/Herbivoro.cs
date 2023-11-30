namespace Lista8
{
    public class Herbivoro : Animal, IVeggie
    {
        public Herbivoro(string nome) : base(nome) { }

        public void Pastar()
        {
            Console.WriteLine($"{nome} está pastando.");
        }

        public new void ExibirDescricao()
        {
            base.ExibirDescricao();
            Console.WriteLine("Este é um animal herbívoro.");
        }
    }
}