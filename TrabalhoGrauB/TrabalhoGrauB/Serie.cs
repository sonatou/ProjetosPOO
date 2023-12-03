using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Serie : Midia
    {
        public string temporadas;
        public List<string> episodios = new List<string>();
        
        public Serie(string tipo, string titulo, string genero, string ano, string classificacao, string temporadas, List<string> episodios) : base(tipo, titulo, genero, ano, classificacao)
        {
            this.temporadas = temporadas;
            this.episodios = episodios;
        }
        public override void ExibirInformacoes(int id)
        {

        }
        public void ListarEpisodios(int temporada)
        {

        }
    }
}
