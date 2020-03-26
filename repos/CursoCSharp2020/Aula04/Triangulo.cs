using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        /* Este foi o metodo criado para melhorar o programa de calculo de triangulo, trazendo para o classe 
         * Triangulo a tarefa de calcular a área do(s) triangulo(s), sendo possivel assim o reaproveitamento de
         * codigos, que eh o maior ganho do orientação a objeto
         * Classe Area foi criada como public do tipo double sem receber nenhum atributo, pois está dentro da 
         * mesma classe
         */
          
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p + (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
