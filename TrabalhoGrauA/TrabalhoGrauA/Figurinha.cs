using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    public class Figurinha
    {
        public int numero;
        public string nome;
        public string conteudo;
        public int status;
        public int nroPagina;

        public Figurinha(int numero, string nome, string conteudo, int status, int nroPagina)
        {
            this.numero = numero;
            this.nome = nome;
            this.conteudo = conteudo;
            this.status = status;
            this.nroPagina= nroPagina;
        }
    }
}
