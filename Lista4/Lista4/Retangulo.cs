using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Retangulo : FiguraGeometrica
    {
        public double Base;
        public double altura;

        public override double CalcularArea()
        {
            double area = Base * altura;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * (Base + altura);
            return perimetro;
        }
    }
}
