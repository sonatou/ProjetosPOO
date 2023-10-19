using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoGrauA
{
    public class Pagina
    {
        public List<Figurinha> figurinhas = new List<Figurinha>();
        public string titulo;
        public int numeroPagina;
        public int minNro, maxNro;

        public void MostrarPagina()
        {
            foreach(Figurinha figurinha in figurinhas)
            {
                if(figurinha.status == 1)
                {
                    Console.WriteLine(figurinha.numero);
                    Console.WriteLine(figurinha.nome);
                    Console.WriteLine(figurinha.conteudo);
                } 
                else if(figurinha.status == 0)
                {
                    Console.WriteLine("COLAR");
                }
                else
                {
                    Console.WriteLine("X");
                }
            }
        }
    }
}
