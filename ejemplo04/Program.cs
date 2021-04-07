using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(5, 4);
            Console.WriteLine("Area del rectangulo: " + rectangulo.area());
            Console.WriteLine("Perimetro del rectangulo: " + rectangulo.perimetro());

            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine("Area del cuadrado: " + cuadrado.area());
            Console.WriteLine("Perimetro del cuadrado: " + cuadrado.perimetro());

            Triangulo triangulo = new Triangulo(5, 4);
            Console.WriteLine("Area del triangulo: " + triangulo.area());
            Console.WriteLine("Perimetro del triangulo: " + triangulo.perimetro());
        }
    }
}
