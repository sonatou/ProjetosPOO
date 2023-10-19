namespace TrabalhoGrauA
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Program
    {
        static void Main(string[] args)
        {
            AlbumManager manager = new AlbumManager();

            manager.LoadDataFromFiles();

            bool menu1 = true;

            while (menu1)
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
                        manager.CriarNovoUsuario();
                        break;
                    case "2":
                        manager.AcessarAlbum();
                        break;
                    case "3":
                        manager.SaveDataOnFiles();
                        menu1 = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}