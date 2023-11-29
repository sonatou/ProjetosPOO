using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class CatalogoManager
    {
        public List<Usuario> usuarios = new List<Usuario>();

        private string usuariosFilePath = "ExemploUsuarios.csv";

        public void LoadDataFromFiles()
        {            
            usuarios = LoadUsuariosFromFile();
        }

        public void SaveDataOnFiles()
        {
            SaveUsuariosOnFile();
        }

        public void CriarNovoUsuario(string nomeUsuario, string senha)
        {
            Console.Clear();
            Console.WriteLine("Qual plano deseja");
            Console.WriteLine("Simples: ");
            Console.WriteLine("Direito a 3 perfis");
            Console.WriteLine("Propagandas entre mídias assistidas ");
            Console.WriteLine("Custo R$29,90 mensal ");
            Console.WriteLine("");
            Console.WriteLine("Premium: ");
            Console.WriteLine("Direito a 5 perfis");
            Console.WriteLine("Sem propaganda");
            Console.WriteLine("Custo 49,90 mensal");

            string plano = Console.ReadLine();

            if (usuarios.Exists(u => u.nomeDeUsuario == nomeUsuario))
            {
                Console.WriteLine("este nome de usuario ja esta em uso. Tente novamente.");
                return;
            }

            Usuario novoUsuario = new Usuario(nomeUsuario, senha, plano);
            usuarios.Add(novoUsuario);

            Console.WriteLine("usuario criado com sucesso.");
            SaveUsuariosOnFile();
        }

        public void Acessar(string nomeUsuario, string senha)
        {               
            Usuario usuario = usuarios.Find(u => u.nomeDeUsuario == nomeUsuario && u.senha == senha);
            if (usuario == null)
            {
                Console.WriteLine("usuario inexistente.");
                return;
            }
            else
            {
                bool menu2 = true;
                while(menu2)
                {
                    Console.Clear();
                    Console.WriteLine($"--------------Olá {usuario.nomeDeUsuario} - Assinatura {usuario.assinatura}---------");
                    usuario.MostraPerfis();
                    Console.WriteLine($"");
                    Console.WriteLine("1 - Acessar perfil");
                    Console.WriteLine("2 - Editar perfil");
                    Console.WriteLine("3 - Adicionar perfil");
                    Console.WriteLine("4 - Remover perfil");
                    Console.WriteLine("5 - Voltar ao menu anterior");
                    string escolha = Console.ReadLine();

                    switch (escolha)
                    {
                        case "1":
                           
                            break;
                        case "2":
                           
                            break;
                        case "3":
                            
                            break;
                        case "4":
                            menu2= false;
                            break;
                        case "5":
                            menu2= false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
        }

        private List<Usuario> LoadUsuariosFromFile()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            List<string[]> dados = LerDadosDoCSV(usuariosFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 2)
                {
                    string nomeUsuario = linha[1];
                    string senha = linha[2];
                    string assinatura = linha[3];

                    Usuario usuario = new Usuario(nomeUsuario, senha, assinatura);
                    listaUsuarios.Add(usuario);
                }
            }
            return listaUsuarios;
        }

        private void SaveUsuariosOnFile()
        {           
            using (StreamWriter writer = new StreamWriter(usuariosFilePath))
            {
                foreach (Usuario usuario in usuarios)
                {
                    writer.WriteLine($"{usuario.nomeDeUsuario},{usuario.senha}");
                }
            }
        }

        static List<string[]> LerDadosDoCSV(string filePath)
        {
            List<string[]> linhas = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split(';');

                    linhas.Add(valores);
                }
            }

            return linhas;
        }
    }
}

