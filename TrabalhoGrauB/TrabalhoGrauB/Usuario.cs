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
        public List<Perfil> perfis;

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

        public void AdicionarPerfil(string nome, int idade)
        {
            perfis.Add(new Perfil(nome, idade));
        }

        public void RemoverPerfil(string nome)
        {

        }

        public void AlterarSenha(string senha)
        {

        }

        public void AlterarPlano(bool plano)
        {

        }

    }
}
