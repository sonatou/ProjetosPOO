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
        }
    }
}