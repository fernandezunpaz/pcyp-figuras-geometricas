using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    class Cuadrado : Rectangulo
    {
        public override void setAncho(int ancho) {
            this.ancho = ancho;
            this.alto = ancho;
        }
        public override void setAlto(int alto) {
            this.ancho = alto;
            this.alto = alto;
        }

    }

}