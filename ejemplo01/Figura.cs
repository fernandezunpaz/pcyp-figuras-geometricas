using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    abstract class Figura
    {
        protected int ancho;
        protected int alto;

        public virtual void setAncho(int ancho) {
            this.ancho = ancho;
        }
        public virtual int getAncho(int alto) {
            return this.alto;
        }
        public virtual void setAlto(int alto) {
            this.alto = alto;
        }
        public virtual int getAlto(int alto) {
            return this.alto;
        }
        public virtual double area() {
            return this.ancho * this.alto;
        }
        public virtual int perimetro() {
            return (this.ancho * 2) + (this.alto * 2);
        }
    }
}