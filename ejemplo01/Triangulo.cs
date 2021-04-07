using System;

namespace ejemplo01
{
    class TrianguloRectangulo : Figura
    {
        public override double area() {
            return this.ancho * (Math.Sqrt(this.perimetro()) / 2);
        }
        public override int perimetro() {
            return (this.ancho * 3);
        }

    }

}