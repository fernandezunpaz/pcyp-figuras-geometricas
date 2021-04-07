using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo03
{
    class Triangulo : Figura
    {
        public override void setLados(int lado)
        {
            for (int i = 0; i < 3; i++)
            {
                lados.Add(lado);
            }
        }
        public override double area()
        {
            return (lados[0] * Math.Sqrt(this.perimetro()) / 2);
        }
    }
}
