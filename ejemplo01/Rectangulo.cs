using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    class Rectangulo : Figura
    {
        public override void setAncho(int ancho) {
            this.ancho = ancho;
        }
        public override int getAncho(int alto) {
            return this.alto;
        }
        public override void setAlto(int alto) {
            this.alto = alto;
        }
        public override int getAlto(int alto) {
            return this.alto;
        }
        public override double area() {
            return this.ancho * this.alto;
        }
        public override int perimetro() {
            return (this.ancho * 2) + (this.alto * 2);
        }

    }

}