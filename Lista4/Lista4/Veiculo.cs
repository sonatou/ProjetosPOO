using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;

        public void Acelerar()
        {
            Console.WriteLine("Acelerando o veículo!");
        }

        public void Frear()
        {
            Console.WriteLine("Freando o veículo!");
        }
    }
}
