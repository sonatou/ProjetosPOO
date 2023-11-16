using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Caminhao : Veiculo
    {
        public string cargaMaxima;

        public void Carregar()
        {
            Console.WriteLine("Carregando o caminhão!");
        }

        public void Descarregar()
        {
            Console.WriteLine("Descarregando o caminhão!");
        }
    }
}
