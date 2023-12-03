using System;

namespace TrabalhoGrauB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatalogoManager manager = new CatalogoManager();
            manager.LoadDataFromFiles();
            bool menu1 = true;
            while (menu1)
            {
                Console.WriteLine("-------------------------UNIFLIX---------------------");
                Console.WriteLine("Usuario: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("senha: ");
                string senha = Console.ReadLine();
                Console.WriteLine("1 - Acessar");
                Console.WriteLine("2 - Criar Conta");
                Console.WriteLine("3 - Sair");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        manager.Acessar(usuario, senha);
                        break;
                    case "2":
                        manager.CriarNovoUsuario(usuario, senha);
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