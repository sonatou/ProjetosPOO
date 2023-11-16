using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class Triangulo : FiguraGeometrica
    {
        public double Base;
        public double altura;

        public override double CalcularArea()
        {
            double area = 0.5 * Base * altura;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = Base + altura + Math.Sqrt(Base * Base + altura * altura);
            return perimetro;
        }
    }
}
