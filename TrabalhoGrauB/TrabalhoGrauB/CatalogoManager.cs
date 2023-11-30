using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class CatalogoManager
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Midia> midias = new List<Midia>();

        private string usuariosFilePath = "ExemploUsuarios.csv";
        private string midiasFilePath = "CatalogoExemplo.csv";

        public void LoadDataFromFiles()
        {            
            usuarios = LoadUsuariosFromFile();
            midias = LoadMidiasFromFile();
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
                            Console.WriteLine("Qual Perfil deseja acessar?");
                            string perfilEscolhido = Console.ReadLine();
                            Perfil perfil = usuario.perfis.Find(p => p.nome == perfilEscolhido);
                            if(perfil == null)
                            {
                                Console.WriteLine("Perfil não encontrado");
                                break;
                            }
                            else
                            {
                                AcessarPerfil(perfil);
                            }
                            break;
                        case "2":
                           
                            break;
                        case "3":
                            Console.WriteLine("Digite o nome do perfil: "); 
                            string nomePerfil = Console.ReadLine();
                            Console.WriteLine("Digite a idade do perfil: ");
                            int idadePerfil = Convert.ToInt32(Console.ReadLine());
                            usuario.AdicionarPerfil(nomePerfil, idadePerfil);
                            break;
                        case "4":
                            
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

        private void AcessarPerfil(Perfil perfil)
        {
            bool menu3 = true;
            while (menu3)
            {
                Console.Clear();
                Console.WriteLine("1 - Buscar por nome");
                Console.WriteLine("2 - Ultimos assistidos");
                Console.WriteLine("3 - Favoritos");
                Console.WriteLine("4 - Filmes");
                Console.WriteLine("5 - Series");
                Console.WriteLine("6 - Documentarios");
                Console.WriteLine("7 - Animaçoes");
                Console.WriteLine("8 - Programas de TV");
                Console.WriteLine("9 - Voltar ao menu anterior");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do filme: ");
                        string nome = Console.ReadLine();
                       
                        break;
                    case "2":
                        WriteAllMidias();
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":

                        break;
                    case "9":
                        menu3 = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }

        private List<Usuario> LoadUsuariosFromFile()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            List<string[]> dados = LerDadosDoCSV(usuariosFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 3)
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

        private List<Midia> LoadMidiasFromFile()
        {
            List<Midia> listaMidias = new List<Midia>();

            List<string[]> dados = LerDadosDoCSV(midiasFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 3)
                {
                    string tipo = linha[1];
                    string titulo = linha[2];
                    string genero = linha[3];
                    string ano = linha[4];
                    string classificacao = linha[5];
                    string temporadas = linha[6];
                    string diretor = linha[7];
                    string produtor = linha[8];
                    string tema = linha[9];
                    string studio = linha[10];

                    Midia midia = new Midia(tipo, titulo, genero, ano, classificacao);
                    listaMidias.Add(midia);
                }
            }
            return listaMidias;
        }   

        public void WriteAllMidias()
        {
            foreach (Midia midia in midias)
            {
                Console.WriteLine($"{midia.tipo},{midia.titulo},{midia.genero},{midia.ano},{midia.classificacao}");
            }
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

