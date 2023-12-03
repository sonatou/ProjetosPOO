using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauB
{
    public class Perfil
    {
        public string nome;
        public string idade;
        public List<Midia> favoritos = new List<Midia>();
        public List<Midia> ultimosAssistidos = new List<Midia>();

        public Perfil(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public void AdicionaFavorito(Midia favorito)
        {

        }

        public void RemoveFavorito(Midia favorito)
        {

        }

        public void AdicionarUltimoAssistido(Midia recente)
        {

        }

        public void ListarMidiasApropriadas(string tipo, List<Midia> midias) 
        {
            //recebe determinada lista do catálogo e retorna
            //uma lista com as mídias do tipo informado apropriadas para a idade(18 + não precisa
            //verificar idade).Dica: para chamar este método, a aplicação pode chamar o método
            //obterLista(tipo) da classe Catálogo, que retorna a lista completa do tipo de mídia, e
            //então filtrá - la neste método
        }

        public void Assistir(Midia midia)
        {
            ultimosAssistidos.Add(midia);
            Console.WriteLine($"Assistindo {midia.titulo}");
            Console.Read();
        }

        public void Favoritar(Midia midia, bool fav)
        {
            //que se for verdadeiro adiciona na lista de favoritos(se não estiver
            //lá), se for falso e remove da lista de favoritos(se estiver lá).
        }

        public void BuscarPorTipo(string tipo, Catalogo catalogo)
        {
            //Dica: pode-se chamar o método listarMidiasApropriadas de cada tipo e fazer as buscas nas listas das diferentes mídias até encontrar o título ou percorrer todas. Retorna a mídia encontrada ou None, caso não encontre
        }

        public void EditarPerfil()
        {
            Console.WriteLine("Digite o novo nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nova idade: ");
            idade = Console.ReadLine();
            this.nome = nome;
            this.idade = idade;
        }

    }
}
