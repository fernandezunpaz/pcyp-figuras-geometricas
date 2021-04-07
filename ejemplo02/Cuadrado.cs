using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo02
{
    class Cuadrado : Rectangulo
    {
        public Cuadrado(int lado) : base(lado, lado)
        {
            this.ancho = lado;
            this.alto = lado;
        }
    }

}