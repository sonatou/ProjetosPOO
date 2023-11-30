namespace Lista8
{
    public class Onivoro : Animal, ICarnivoro, IVeggie
    {
        public Onivoro(string nome) : base(nome) { }

        public void Comer()
        {
            Random random = new Random();
            int escolha = random.Next(2);

            if (escolha == 0)
            {
                Cacar();
            }
            else
            {
                Pastar();
            }
        }

        public void Cacar()
        {
            Console.WriteLine($"{nome} está caçando.");
        }

        public void Pastar()
        {
            Console.WriteLine($"{nome} está pastando.");
        }
    }
}