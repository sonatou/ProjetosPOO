using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Usuario
    {
        public string nomeDeUsuario;
        public string senha;
        public string assinatura;
        public List<Perfil> perfis = new List<Perfil>();

        public Usuario(string nomeDeUsuario, string senha, string assinatura)
        {
            this.nomeDeUsuario = nomeDeUsuario;
            this.senha = senha;
            this.assinatura = assinatura;
        }

        public void MostraPerfis()
        {
            if(perfis != null)
            {
                foreach(Perfil perfil in perfis)
                {
                    Console.WriteLine($"{perfil.nome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum perfil criado, crie um perfil");
            }
        }

        public Perfil AdicionarPerfil(string nome, string idade)
        {
            Perfil perfilCriado = new Perfil(nome, idade);
            perfis.Add(perfilCriado);
            return perfilCriado;
        }

        public void RemoverPerfil(string nome)
        {
            perfis.Remove(perfis.Find(x => x.nome == nome));
        }

        public void AlterarSenha(string senha)
        {

        }

        public void AlterarPlano(bool plano)
        {

        }

    }
}
