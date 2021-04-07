using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo04
{
    class Triangulo
    {
        private int _base;
        private int altura;
        
        public Triangulo(int _base, int altura)
        {
            this._base = _base;
            this.altura = altura;
        }
        public double area()
        {
            return (this._base * this.altura) / 2;
        }
        public int perimetro()
        {
            return (this.altura * 2) + this._base;
        }
    }
}
