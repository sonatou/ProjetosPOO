using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    internal class Usuario
    {
        public string nomeDeUsuario;
        public string senha;
        public Album album;
        public Usuario() { }

        public string getNomeDeUsuario() { return nomeDeUsuario; }
        public void Cadastrar(string nomeDeUsuario, string senha)
        {
            
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
