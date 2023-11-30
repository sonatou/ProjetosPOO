namespace Lista8
{
    public class Carnivoro : Animal, ICarnivoro
    {
        public Carnivoro(string nome) : base(nome) { }

        public void Cacar()
        {
            Console.WriteLine($"{nome} está caçando.");
        }

        public new void ExibirDescricao()
        {
            base.ExibirDescricao();
            Console.WriteLine("Este é um animal carnívoro.");
        }
    }
}