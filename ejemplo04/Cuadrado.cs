using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo04
{
    class Cuadrado
    {
        private int lado;
        
        public Cuadrado(int lado)
        {
            this.lado = lado;
        }
        public double area()
        {
            return this.lado * this.lado;
        }
        public int perimetro()
        {
            return this.lado * 4;
        }
    }
}
