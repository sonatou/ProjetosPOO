namespace Lista6
{
    public class Arqueiro : UnidadeMilitar
    {
        public override void Mover()
        {
            Console.WriteLine("O arqueiro está se deslocando silenciosamente.");
        }

        public override void Atacar()
        {
            Console.WriteLine("O arqueiro está atirando flechas.");
        }
    }
}