namespace TrabalhoGrauA
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            AlbumManager manager = new AlbumManager();

            // Carregar os dados dos arquivos ao iniciar o programa
            //LoadDataFromFiles("usuarios.csv", "figurinhas.csv", "trocas.csv");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("-------------------------Menu---------------------");
                Console.WriteLine("1 - Novo Álbum");
                Console.WriteLine("2 - Acessar Álbum");
                Console.WriteLine("3 - Sair do Aplicativo");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        manager.LoadDataFromFiles();
                        break;
                    case "2":
                        //AcessarAlbum();
                        break;
                    case "3":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            // Salvar as alterações nos arquivos ao sair do aplicativo
            //SalvarDadosEmArquivos("usuarios.csv", "figurinhas.csv", "trocas.csv");
        }
    }
    }