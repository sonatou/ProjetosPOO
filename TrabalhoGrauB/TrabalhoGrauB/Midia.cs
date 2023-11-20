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
        public int ano;
        public int classificacao;

        public virtual void ExibirInformacoes(int id)
        {
            //exibe os atributos gerais
        }
    }
}
