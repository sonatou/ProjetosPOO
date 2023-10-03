using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class Competidor
    {
        public string nome;

        public int posicao;

        public Competidor(string nome)
        {
            this.nome = nome;
            this.posicao = 0;
        }

        public void Atualizar()
        {
            Random rand = new Random();
            int numeroDeCasas = rand.Next(1, 7);

            this.posicao += numeroDeCasas;

            if (this.posicao % 5 == 0)
            {
                this.posicao -= 1;
            }
            else if (this.posicao == 7 || this.posicao == 17)
            {
                this.posicao += 2;
            }
            else if (this.posicao == 13)
            {
                this.posicao = 0;
            }

            if (this.posicao >= 20)
            {
                this.posicao = 20;
                Console.WriteLine($"{nome} venceu a corrida!");
            }
        }

        public int GetPos()
        {
            return this.posicao;
        }
    }
}
