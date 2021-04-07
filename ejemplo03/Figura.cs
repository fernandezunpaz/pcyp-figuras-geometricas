using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo03
{
    class Figura
    {
        public List<int> lados = new List<int>();
        public virtual void setLados(int lado)
        {
            for (int i = 0; i < 4; i++)
            {
                lados.Add(lado);
            }
        }
        public int perimetro()
        {
            int perimetro = 0;
            for (int i = 0; i < lados.Count; i++)
            {
                perimetro += lados[i];
            }
            return perimetro;
        }
        public virtual double area()
        {
            return lados[0] * lados[1];
        }
    }
}
