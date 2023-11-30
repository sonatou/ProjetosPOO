namespace Lista8
{
    public class Animal
    {
        public string nome;

        public Animal(string nome)
        {
            this.nome = nome;
        }

        public void ExibirDescricao()
        {
            Console.WriteLine($"Nome do animal: {nome}");
        }
    }
}