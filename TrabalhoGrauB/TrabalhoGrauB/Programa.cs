using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Programa : Midia
    {
        public int episodios;
        public List<string> listaEpisodios;

        public Programa(string tipo, string titulo, string genero, string ano, string classificacao) : base(tipo, titulo, genero, ano, classificacao)
        {
        }

        public override void ExibirInformacoes(int id)
        {

        }

        public void ListarEpisodios()
        {

        }
    }
}
