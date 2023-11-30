namespace Lista6
{
    public class Soldado : UnidadeMilitar
    {
        public override void Mover()
        {
            Console.WriteLine("O soldado está marchando.");
        }

        public override void Atacar()
        {
            Console.WriteLine("O soldado está atacando com sua espada.");
        }
    }
}