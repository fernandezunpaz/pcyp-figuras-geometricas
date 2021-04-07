using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.setAlto(5);
            rectangulo.setAncho(4);
            Console.WriteLine("Area del rectangulo: " + rectangulo.area());
            Console.WriteLine("Perimetro del rectangulo: " + rectangulo.perimetro());

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.setAlto(5);
            cuadrado.setAncho(4);
            Console.WriteLine("Area del cuadrado: " + cuadrado.area());
            Console.WriteLine("Perimetro del cuadrado: " + cuadrado.perimetro());

            TrianguloRectangulo triangulo = new TrianguloRectangulo();
            triangulo.setAlto(5);
            triangulo.setAncho(4);
            Console.WriteLine("Area del triangulo: " + triangulo.area());
            Console.WriteLine("Perimetro del triangulo: " + triangulo.perimetro());
        }
    }
}
