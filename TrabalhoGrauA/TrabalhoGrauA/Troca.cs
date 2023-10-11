using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    internal class Troca
    {
        public string nomeProponente;
        public int figurinhaRequerida;
        public int figurinhaDisponivel;
        public int status;

        public Troca(string nomeProponente, int figurinhaRequerida, int figurinhaDisponivel, int status) 
        {
            this.nomeProponente = nomeProponente;
            this.figurinhaRequerida = figurinhaRequerida;
            this.figurinhaDisponivel = figurinhaDisponivel;
            this.status = status;
        }

        public void Aceitar(bool aceitas)
        {
            
        } 
    }
}
