using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPoo
{
    class Musica
    {
        private int id;
        private string nome;
        private string artista;
        private string genero;
        private int ano;
        private float duracao;
        

        public Musica(int id, string nome, string artista, string genero, int ano, float duracao)
        {
            this.id = id;
            this.nome = nome;
            this.artista = artista;
            this.genero = genero;
            this.ano = id;
            this.duracao = id;
        }
        public void Play()
        {
            Console.WriteLine("Tocando agora: {0} - {1}", this.nome, this.artista);
        }

        public void Pause()
        {
            Console.WriteLine("Musica pausada!");
        }
    }
}
