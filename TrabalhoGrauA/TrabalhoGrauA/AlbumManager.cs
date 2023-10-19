using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace TrabalhoGrauA
{
    class AlbumManager
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Figurinha> figurinhas = new List<Figurinha>();
        public List<Troca> trocas = new List<Troca>();

        private string trocasFilePath = "trocas.csv";
        private string figurinhasFilePath = "figurinhas.csv";
        private string usuariosFilePath = "usuarios.csv";

        public void LoadDataFromFiles()
        {            
            usuarios = LoadUsuariosFromFile();
            
            figurinhas = LoadFigurinhasFromFile();

            trocas = LoadTrocasFromFile();
        }

        public void SaveDataOnFiles()
        {
            SaveFigurinhasOnFile();
            SaveUsuariosOnFile();
            SaveTrocasOnFile();
        }

        public void CriarNovoUsuario()
        {
            Console.Write("Digite o nome de usuario: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (usuarios.Exists(u => u.nomeDeUsuario == nomeUsuario))
            {
                Console.WriteLine("este nome de usuario ja esta em uso. Tente novamente.");
                return;
            }

            Usuario novoUsuario = new Usuario(nomeUsuario, senha);
            usuarios.Add(novoUsuario);

            Console.WriteLine("usuario criado com sucesso.");
            SaveUsuariosOnFile();
        }

        public void AcessarAlbum()
        {
            Console.Write("Digite o nome de usuario: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            Usuario usuario = usuarios.Find(u => u.nomeDeUsuario == nomeUsuario && u.senha == senha);
            if (usuario == null)
            {
                Console.WriteLine("nome de usuario ou senha incorretos. Tente novamente.");
                return;
            }
            else
            {
                bool menu2 = true;
                while(menu2)
                {
                    Console.WriteLine($"--------------Album de {usuario.nomeDeUsuario}---------");
                    Console.WriteLine("O que deseja fazer?");
                    Console.WriteLine("1 - Ver album");
                    Console.WriteLine("2 - Gerenciar colecao");
                    Console.WriteLine("3 - Abrir pacote de figurinhas");
                    Console.WriteLine("4 - Voltar ao menu anterior");
                    string escolha = Console.ReadLine();

                    switch (escolha)
                    {
                        case "1":
                            usuario.album.MostrarAlbum();
                            break;
                        case "2":
                            MostraColecao();
                            break;
                        case "3":
                            AbrirPacoteDeFigurinhas();
                            break;
                        case "4":
                            menu2= false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
        }

        public void MostraColecao()
        {
            List<Figurinha> colecao = figurinhas.Where(f => f.status == 0).ToList();
            Console.Clear();
            foreach(Figurinha figurinha in colecao)
            {
                Console.WriteLine($"{figurinha.numero} - {figurinha.nome} - {figurinha.conteudo} - {figurinha.nroPagina}");
            }

            bool menu3 = true;

            while (menu3)
            {
                Console.WriteLine("-------------Coleção---------------");
                Console.WriteLine("1 - Colar Figurinha");
                Console.WriteLine("2 - Disponibilizar para troca");
                Console.WriteLine("3 - Propor troca de figurinhas");
                Console.WriteLine("4 - Revisar solicitações de troca");
                Console.WriteLine("5 - Voltar ao menu Anterior");

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
                        
                        break;

                    case "5":
                        menu3 = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        public void AbrirPacoteDeFigurinhas()
        {
            Random random = new Random();
            List<Figurinha> figurinhasSorteadas = new List<Figurinha>();

            for (int i = 0; i < 3; i++)
            {
                int numeroSorteado = random.Next(1, 101);
                Figurinha figurinhaSorteada = figurinhas.FirstOrDefault(f => f.numero == numeroSorteado);

                if (figurinhaSorteada != null)
                {
                    figurinhaSorteada.status = 0;
                    figurinhasSorteadas.Add(figurinhaSorteada);
                }
            }

            Console.Clear();
            Console.WriteLine("voce obteve as seguintes figurinhas:");
            foreach (var figurinha in figurinhasSorteadas)
            {
                Console.WriteLine($"{figurinha.numero} - {figurinha.nome}");
            }
            SaveFigurinhasOnFile();
        }

        private List<Usuario> LoadUsuariosFromFile()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            List<string[]> dados = LerDadosDoCSV(usuariosFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 2)
                {
                    string nomeUsuario = linha[0];
                    string senha = linha[1];

                    Usuario usuario = new Usuario(nomeUsuario, senha);
                    listaUsuarios.Add(usuario);
                }
            }
            return listaUsuarios;
        }

        private List<Figurinha> LoadFigurinhasFromFile()
        {
            List<Figurinha> listaFigurinhas = new List<Figurinha>();

            List<string[]> dados = LerDadosDoCSV(figurinhasFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 4)
                {
                    if (int.TryParse(linha[0], out int numero) && int.TryParse(linha[3], out int status) && int.TryParse(linha[4], out int nroPagina))
                    {
                        string nome = linha[1];
                        string conteudo = linha[2];

                        Figurinha figurinha = new Figurinha(numero, nome, conteudo, status, nroPagina);
                        listaFigurinhas.Add(figurinha);
                    }
                }
            }
            Console.WriteLine(listaFigurinhas.Count);
            return listaFigurinhas;
        }


        private List<Troca> LoadTrocasFromFile()
        {
            List<Troca> listaTrocas = new List<Troca>();

            List<string[]> dados = LerDadosDoCSV(trocasFilePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 4)
                {
                    string nomeProponente = linha[0];
                    if (int.TryParse(linha[1], out int figurinhaRequerida) && int.TryParse(linha[2], out int figurinhaDisponivel) && int.TryParse(linha[3], out int status))
                    {
                        Troca troca = new Troca(nomeProponente, figurinhaRequerida, figurinhaDisponivel, status);
                        listaTrocas.Add(troca);
                    }
                }
            }

            return listaTrocas;
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

        private void SaveFigurinhasOnFile()
        {
            using (StreamWriter writer = new StreamWriter(figurinhasFilePath))
            {
                foreach (Figurinha figurinha in figurinhas)
                {
                    writer.WriteLine($"{figurinha.numero},{figurinha.nome},{figurinha.conteudo},{figurinha.status}");
                }
            }
        }

        private void SaveTrocasOnFile()
        {
            using (StreamWriter writer = new StreamWriter(trocasFilePath))
            {
                foreach (Troca troca in trocas)
                {
                    writer.WriteLine($"{troca.nomeProponente},{troca.figurinhaRequerida},{troca.figurinhaDisponivel},{troca.status}");
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
                    string[] valores = linha.Split(',');

                    linhas.Add(valores);
                }
            }

            return linhas;
        }
    }
}
