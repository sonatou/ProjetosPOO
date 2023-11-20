using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Catalogo
    {
        public List<Serie> series = new List<Serie>();
        public List<Filme> filmes = new List<Filme>();
        public List<Documentario> documentarios = new List<Documentario>();
        public List<Animacao> animacoes = new List<Animacao>();
        public List<Programa> programas = new List<Programa>();

        public void AdicionarMidia(Midia midia, string tipo)
        {

        }

        public void ObterLista(string tipo)
        {

        }
    }
}
