using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    abstract class Figura
    {
        protected int ancho;
        protected int alto;

        public virtual double area() {
            return this.ancho * this.alto;
        }
        public virtual int perimetro() {
            return (this.ancho * 2) + (this.alto * 2);
        }
    }
}