using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
           return (Largura * 2) + (Altura * 2);
        }
           
        public double Diagonal()
        {
            double diag = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return diag;

        }

 

    }
}
