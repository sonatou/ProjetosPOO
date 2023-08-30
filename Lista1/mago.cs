using System;

class Mago {
    // Atributos de classe
    public static bool possuiMagia = true;

    // Atributos de instância
    private string nome;
    private int idade;
    private string escola;
    private int mana;
    private int vida;

    // Método construtor
    public Mago(string nome, int idade, string escola, int mana, int vida) {
        this.nome = nome;
        this.idade = idade;
        this.escola = escola;
        this.mana = mana;
        this.vida = vida;
        Console.WriteLine("\n Mago " + this.nome + " foi criado!");
    }

    // Outros métodos
    public void Andar() {
        Console.WriteLine("\n Estou andando");
    }

    public void Falar() {
        Console.WriteLine("\n Ola amigue! Meu nome é " + this.nome);
    }

    public void InvocarMagia() {
        Console.WriteLine("\n Invocando magia! ");
    }

    public void PotarMana()
    {
        Random random = new Random();
        int manaAmount = random.Next(1, 21);
        this.mana += manaAmount;
        Console.WriteLine("\n Recuperou: {0} ", manaAmount);
    }

    public void PotarVida()
    {
        Random random = new Random();
        int vidaAmount = random.Next(1, 21);
        this.vida += vidaAmount;
        Console.WriteLine("\n Curou: {0} ", vidaAmount);
    }

    // Destrutor
    ~Mago() {
        Console.WriteLine("Deixou de existir!");
    }
}
