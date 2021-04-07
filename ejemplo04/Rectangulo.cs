using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo04
{
    class Rectangulo
    {
        private int alto;
        private int ancho;

        public Rectangulo(int alto, int ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        public double area()
        {
            return this.alto * this.ancho;
        }
        public int perimetro()
        {
            return (this.alto * 2) + (this.ancho * 2);
        }
    }
}
