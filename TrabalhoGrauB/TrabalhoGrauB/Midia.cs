using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Midia
    {
        public int id;
        public string tipo;
        public string titulo;
        public string genero;
        public string ano;
        public string classificacao;

        public Midia(string tipo, string titulo, string genero, string ano, string classificacao)
        {
            this.tipo = tipo;
            this.titulo = titulo;
            this.genero = genero;
            this.ano = ano;
            this.classificacao = classificacao;
        }

        public virtual void ExibirInformacoes(int id)
        {
            //exibe os atributos gerais
        }
    }
}
