using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo03
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.setLados(5, 4);
            Console.WriteLine("Area del rectangulo: " + rectangulo.area());
            Console.WriteLine("Perimetro del rectangulo: " + rectangulo.perimetro());

            Rectangulo cuadrado = new Rectangulo();
            cuadrado.setLados(4);
            Console.WriteLine("Area del cuadrado: " + cuadrado.area());
            Console.WriteLine("Perimetro del cuadrado: " + cuadrado.perimetro());

            Triangulo triangulo = new Triangulo();
            triangulo.setLados(4);
            Console.WriteLine("Area del triangulo: " + triangulo.area());
            Console.WriteLine("Perimetro del triangulo: " + triangulo.perimetro());

        }
    }
}
