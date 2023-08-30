using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new Mago("Dumbledore", 180, "Escola de Magia de Hogwarts", 10, 10);
            mago1.Andar();
            mago1.Falar();
            mago1.InvocarMagia();
            mago1.PotarMana();
            mago1.PotarVida();

            Mago mago2 = new Mago("Harry", 16, "Escola de Magia de Hogwarts", 6, 5);
            mago2.Andar();
            mago2.Falar();
            mago2.InvocarMagia();
            mago2.PotarMana();
            mago2.PotarVida();

            Mago mago3 = new Mago("Snape", 40, "Escola de Magia de Hogwarts", 8, 7);
            mago3.Andar();
            mago3.Falar();
            mago3.InvocarMagia();
            mago3.PotarMana();
            mago3.PotarVida();

            Data data = new Data(24, 07, 1998);
            data.ImprimirData();
            data.ImprimirDataPorExtenso("Porto Alegre");

            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
