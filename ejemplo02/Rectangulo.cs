using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    class Rectangulo : Figura
    {
        public Rectangulo(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public override double area() {
            return this.ancho * this.alto;
        }
        public override int perimetro() {
            return (this.ancho * 2) + (this.alto * 2);
        }

    }

}