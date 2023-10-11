using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    class AlbumManager
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Figurinha> figurinhas = new List<Figurinha>();
        private List<Troca> trocas = new List<Troca>();

        public void LoadDataFromFiles()
        {            
            usuarios = LoadUsuariosFromFile();
            
            figurinhas = LoadFigurinhasFromFile();

            //trocas = LoadTrocasFromFile(trocasFile);
        }

        public void SalvarDadosEmArquivos(string usuariosFile, string figurinhasFile, string trocasFile)
        {
            // Implemente o código para salvar os dados nos arquivos aqui
            SaveUsuariosToFile(usuariosFile, usuarios);
            SaveFigurinhasToFile(figurinhasFile, figurinhas);
            SaveTrocasToFile(trocasFile, trocas);
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
                Console.WriteLine("Nome de usuario ou senha incorretos. Tente novamente.");
                return;
            }

            // Implementar as opções de acesso ao álbum para o usuário
            // Por exemplo, listar figurinhas, adicionar figurinhas, fazer trocas, etc.
        }

        // Funções auxiliares para carregar dados dos arquivos
        private List<Usuario> LoadUsuariosFromFile()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string filePath = "C:\\Users\\allan.almeida\\Desktop\\Study\\UNISINOS\\ProjetosPOO\\TrabalhoGrauA\\TrabalhoGrauA\\usuarios.csv"; // Substitua pelo caminho do seu arquivo CSV

            List<string[]> dados = LerDadosDoCSV(filePath);

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
            string filePath = "C:\\Users\\allan.almeida\\Desktop\\Study\\UNISINOS\\ProjetosPOO\\TrabalhoGrauA\\TrabalhoGrauA\\figurinhas.csv";

            List<string[]> dados = LerDadosDoCSV(filePath);

            foreach (string[] linha in dados)
            {
                if (linha.Length >= 4)
                {
                    if (int.TryParse(linha[0], out int numero) && int.TryParse(linha[3], out int status))
                    {
                        string nome = linha[1];
                        string conteudo = linha[2];

                        Figurinha figurinha = new Figurinha(numero, nome, conteudo, status);
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
            string filePath = "C:\\Users\\allan.almeida\\Desktop\\Study\\UNISINOS\\ProjetosPOO\\TrabalhoGrauA\\TrabalhoGrauA\\trocas.csv"; // Substitua pelo caminho do seu arquivo CSV

            List<string[]> dados = LerDadosDoCSV(filePath);

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

        // Funções auxiliares para salvar dados nos arquivos
        private void SaveUsuariosToFile(string filePath, List<Usuario> usuarios)
        {
            // Implemente a lógica para salvar os dados dos usuários no arquivo
        }

        private void SaveFigurinhasToFile(string filePath, List<Figurinha> figurinhas)
        {
            // Implemente a lógica para salvar os dados das figurinhas no arquivo
        }

        private void SaveTrocasToFile(string filePath, List<Troca> trocas)
        {
            // Implemente a lógica para salvar os dados das trocas no arquivo
        }

        static List<string[]> LerDadosDoCSV(string filePath)
        {
            List<string[]> linhas = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split(','); // Assumindo que os valores estejam separados por vírgula

                    linhas.Add(valores);
                }
            }

            return linhas;
        }
    }
}
