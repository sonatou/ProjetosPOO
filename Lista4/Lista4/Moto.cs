using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Moto : Veiculo
    {
        public string cilindrada;

        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }

        public void Buzinar()
        {
            Console.WriteLine("Buzinando a moto!");
        }
    }
}
