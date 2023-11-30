namespace Lista6
{
    public class UnidadeMilitar
    {
        public virtual void Mover()
        {
            Console.WriteLine("A unidade está se movendo.");
        }

        public virtual void Atacar()
        {
            Console.WriteLine("A unidade está atacando.");
        }
    }
}