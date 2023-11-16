using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Circulo : FiguraGeometrica
    {
        public double raio;

        public override double CalcularArea()
        {
            double area = Math.PI * raio * raio;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }
}
