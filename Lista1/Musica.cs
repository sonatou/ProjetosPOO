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
        private int duracao;
        
        public void Play()
        {
            Console.WriteLine("Tocando agora: {0}", this.nome);
        }

        public void Pause()
        {
            Console.WriteLine("Musica pausada!");
        }
    }
}
