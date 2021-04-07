using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura rectangulo = new Rectangulo(5, 4);
            Console.WriteLine("Area del rectangulo: " + rectangulo.area());
            Console.WriteLine("Perimetro del rectangulo: " + rectangulo.perimetro());

            Figura cuadrado = new Cuadrado(4);
            Console.WriteLine("Area del cuadrado: " + cuadrado.area());
            Console.WriteLine("Perimetro del cuadrado: " + cuadrado.perimetro());

            Figura triangulo = new TrianguloRectangulo(4);
            Console.WriteLine("Area del triangulo: " + triangulo.area());
            Console.WriteLine("Perimetro del triangulo: " + triangulo.perimetro());
        }
    }
}
