using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    public class Usuario
    {
        public string nomeDeUsuario;
        public string senha;
        public Album album;

        public string getNomeDeUsuario() { return nomeDeUsuario; }

        public Usuario(string nomeDeUsuario, string senha) 
        {
            this.nomeDeUsuario= nomeDeUsuario;
            this.senha= senha;
            this.album= new Album();
        }

        public bool VerificarLogin(string usuario, string senha) 
        {
            if(usuario == this.nomeDeUsuario && senha == this.senha) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Album GetAlbum() { return album; }
    }
}
