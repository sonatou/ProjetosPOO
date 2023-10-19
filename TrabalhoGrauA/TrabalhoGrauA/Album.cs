using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    public class Album
    {
        public List<Pagina> paginas = new List<Pagina>();
        public List<Figurinha> figurinhas = new List<Figurinha>();
        public List<Troca> requisicoesTrocas = new List<Troca>();

        public void MostrarAlbum()
        {
            for(int i = 0; i < paginas.Count;)
            {
                Console.WriteLine(paginas[i].titulo);
                paginas[i].MostrarPagina();
                Console.WriteLine("-----------------Album----------------");
                Console.WriteLine("1. Avançar página");
                Console.WriteLine("2. Recuar página");
                Console.WriteLine("3. Voltar ao menu anterior");

                string opcao = Console.ReadLine();

                if (opcao == "1" && i < paginas.Count)
                {
                    i++;
                }
                else if (opcao == "2" && i > 1)
                {
                    i--;
                }
                else if (opcao == "3")
                {
                    break;
                }

            }
        }
    }
}
