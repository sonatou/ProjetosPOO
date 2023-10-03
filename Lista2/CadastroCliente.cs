using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2
{
    internal class CadastroCliente
    {
        public string Nome;
        public string Sobrenome;
        public string DataNascimento;
        public string Email;
        public string CPF;
        public string Senha;

        private int tentativasSenhaErrada = 0;

        private bool bloqueado = false;

        public CadastroCliente(string nome, string sobrenome, string dataNascimento, string email, string cpf, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Email = email;
            CPF = cpf;
            Senha = senha;
        }

        public bool Logar(string email, string senha)
        {
            if (bloqueado)
            {
                Console.WriteLine("Sua conta está bloqueada. Entre em contato com o suporte.");
                return false;
            }

            if (Email == email && Senha == senha)
            {
                Console.WriteLine("Login bem sucedido.");
                tentativasSenhaErrada = 0;
                return true;
            }
            else
            {
                Console.WriteLine("email ou senha incorretos.");

                tentativasSenhaErrada++;
                if (tentativasSenhaErrada >= 3)
                {
                    Console.WriteLine("sua conta foi bloqueada devido a multiplas tentativas de senha incorretas.");
                    bloqueado = true;
                }
                return false;
            }
        }

        public void ConsultarDados()
        {
            if (!bloqueado)
            {
                Console.WriteLine($"\n nome: {Nome} {Sobrenome}");
                Console.WriteLine($"\n Data de nascimento: {DataNascimento}");
                Console.WriteLine($"\nemail: {Email}");
                Console.WriteLine($"\n CPF: {CPF}");
            }
            else
            {
                Console.WriteLine("Sua conta está bloqueada. Entre em contato com o suporte.");
            }
        }
    }
}
