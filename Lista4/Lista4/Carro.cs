using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Carro : Veiculo
    {
        public string cor;

        public void LigarRadio()
        {
            Console.WriteLine("Ligando o rádio do carro!");
        }

        public void AbrirPorta()
        {
            Console.WriteLine("Abrindo a porta do carro!");
        }
    }
}
