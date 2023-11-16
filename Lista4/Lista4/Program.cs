namespace Lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo { Base = 5, altura = 3 };
            Triangulo triangulo = new Triangulo { Base = 4, altura = 6 };
            Circulo circulo = new Circulo { raio = 2.5 };

            Console.WriteLine($"Area e perimetro do retangulo com base {retangulo.Base} e altura {retangulo.altura}");
            Console.WriteLine($"Area: {retangulo.CalcularArea():F2}");
            Console.WriteLine($"Perimetro: {retangulo.CalcularPerimetro():F2}\n");

            Console.WriteLine($"Area e perimetro do triangulo com base {triangulo.Base} e altura {triangulo.altura}");
            Console.WriteLine($"area: {triangulo.CalcularArea():F2}");
            Console.WriteLine($"Perimetro: {triangulo.CalcularPerimetro():F2}\n");

            Console.WriteLine($"Area e perimetro do circulo com raio {circulo.raio}");
            Console.WriteLine($"Area: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perimetro: {circulo.CalcularPerimetro():F2}");

            Console.WriteLine("------------------------------------------------------------Exercicio 2---------------------------------------------------");

            Carro meuCarro = new Carro
            {
                marca = "Toyota",
                modelo = "Corolla",
                ano = 2022,
                cor = "Azul"
            };

            meuCarro.Acelerar();
            meuCarro.LigarRadio();

            Moto minhaMoto = new Moto
            {
                marca = "Honda",
                modelo = "CBR",
                ano = 2021,
                cilindrada = "600cc"
            };

            minhaMoto.Frear();
            minhaMoto.Empinar();

            Caminhao meuCaminhao = new Caminhao
            {
                marca = "Volvo",
                modelo = "FH16",
                ano = 2020,
                cargaMaxima = "40 toneladas"
            };

            meuCaminhao.Carregar();
            meuCaminhao.Descarregar();


            Console.WriteLine("------------------------------------------------------------Exercicio 3---------------------------------------------------");


            CifraCesar cifraCesar = new CifraCesar(3);
            string textoOriginal = "Allan";
            string textoCifradoCesar = cifraCesar.Cifrar(textoOriginal);
            string textoDecifradoCesar = cifraCesar.Decifrar(textoCifradoCesar);

            Console.WriteLine($"Texto Original (César): {textoOriginal}");
            Console.WriteLine($"Texto Cifrado (César): {textoCifradoCesar}");
            Console.WriteLine($"Texto Decifrado (César): {textoDecifradoCesar}");

            CifraXor cifraXor = new CifraXor("segredo");
            string textoCifradoXor = cifraXor.Cifrar(textoOriginal);
            string textoDecifradoXor = cifraXor.Decifrar(textoCifradoXor);

            Console.WriteLine($"\nTexto Original (XOR): {textoOriginal}");
            Console.WriteLine($"Texto Cifrado (XOR): {textoCifradoXor}");
            Console.WriteLine($"Texto Decifrado (XOR): {textoDecifradoXor}");
        }
    }
}