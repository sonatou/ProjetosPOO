namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DadoVirtual dado6Faces = new DadoVirtual(6);
            DadoVirtual dado8Faces = new DadoVirtual(8);
            DadoVirtual dado12Faces = new DadoVirtual(12);

            Console.WriteLine("Jogando o dado de 6 faces:");
            for (int i = 0; i < 3; i++)
            {
                int resultado = dado6Faces.Rolar();
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("\nJogando o dado de 8 faces:");
            for (int i = 0; i < 3; i++)
            {
                int resultado = dado8Faces.Rolar();
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("\nJogando o dado de 12 faces:");
            for (int i = 0; i < 3; i++)
            {
                int resultado = dado12Faces.Rolar();
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.WriteLine("\n -------------------Cadastro-----------------------");
            Console.WriteLine("\n Insira seu nome: ");
            string u_nome = Console.ReadLine();

            Console.WriteLine("\n Insira seu sobrenome: ");
            string u_sobrenome = Console.ReadLine();

            Console.WriteLine("\n Insira sua data de nascimento: ");
            string u_nascimento = Console.ReadLine();

            Console.WriteLine("\n Insira seu email: ");
            string u_email = Console.ReadLine();

            Console.WriteLine("\n Insira seu cpf: ");
            string u_cpf = Console.ReadLine();

            Console.WriteLine("\n Insira a senha que deseja: ");
            string u_senha = Console.ReadLine();

            Console.WriteLine("\n aperte enter para finalizar");
            Console.ReadLine();

            CadastroCliente cliente = new CadastroCliente(u_nome, u_sobrenome, u_nascimento, u_email, u_cpf, u_senha);


            Console.WriteLine("Faça login para consultar seus dados:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                if (cliente.Logar(email, senha))
                {
                    cliente.ConsultarDados();
                    break;
                }
                else if (i < 2)
                {
                    Console.WriteLine($"Tentativa {i + 1} de 3 falhou. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Você excedeu o número máximo de tentativas. Sua conta foi bloqueada.");
                }
            }

            Console.WriteLine("------------------------------------Corrida Maluca--------------------------");
            List<Competidor> competidores = new List<Competidor>
        {
            new Competidor("Penelope"),
            new Competidor("Dick vigarista"),
            new Competidor("Mutley"),
            new Competidor("Irmãos Rocha"),
            new Competidor("Dupla Sinistra")
        };

            bool corridaEmAndamento = true;
            while (corridaEmAndamento)
            {
                foreach (var competidor in competidores)
                {
                    competidor.Atualizar();
                }

                foreach (var competidor in competidores)
                {
                    Console.WriteLine($" \n {competidor.nome} esta na posicao {competidor.GetPos()}");
                    if (competidores.Any(c => c.GetPos() >= 20))
                    {
                        corridaEmAndamento = false;
                        var vencedor = competidores.First(c => c.GetPos() >= 20);
                        Console.WriteLine($" \n o vencedor é {vencedor.nome}!");
                        break;
                    }
                }

            }
        }
    }
}