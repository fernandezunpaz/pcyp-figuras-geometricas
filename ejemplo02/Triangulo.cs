using System;

namespace ejemplo02
{
    class TrianguloRectangulo : Figura
    {
        public TrianguloRectangulo(int lado)
        {
            this.ancho = lado;
            this.alto = lado;
        }
        public override double area() {
            return this.ancho * (Math.Sqrt(this.perimetro()) / 2);
        }
        public override int perimetro() {
            return (this.ancho * 3);
        }

    }

}