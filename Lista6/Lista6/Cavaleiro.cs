namespace Lista6
{
    public class Cavaleiro : UnidadeMilitar
    {
        public override void Mover()
        {
            Console.WriteLine("O cavaleiro está galopando a cavalo.");
        }

        public override void Atacar()
        {
            Console.WriteLine("O cavaleiro está atacando com sua lança.");
        }
    }
}