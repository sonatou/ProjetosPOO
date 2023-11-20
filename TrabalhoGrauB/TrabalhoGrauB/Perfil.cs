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
        public int idade;
        public List<Midia> favoritos;
        public List<Midia> ultimosAssistidos;

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
            //exibe uma mensagem que a mídia foi exibida e altera a lista de últimos
            //assistidos – caso este já exista, remove da lista e adiciona novamente no final
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

    }
}
