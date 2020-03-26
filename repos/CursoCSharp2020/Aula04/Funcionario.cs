using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula04
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return (SalarioBruto - Imposto); 
        }

        /* Cria o metodo para calcualr o aumento de salario levando-se em consideração o valor percentual
         * passado pelo digitador. Este valor será passado pelo Main, e será passado como atributo para o
         * metodo, veja que um atributo é esperado pelo metodo: "(double porcentagem)
         * No Main foi criada uma linha de entrada via console.readline uma variavel percent, que é 
         * passada juntamente com a chamada do metodo AumentarSalario
         */

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        /*Cria o metodo ToString, para que se  possa escrever os dados na tela como string,
         * Basicamente eh: retornar o valor da variavel Nome, R$
         * chama o metodo SalarioLiquido(não há atributo aqui pois esta na mesma classe).TransformaEmString
         * ("Com 2 campos apos o ponto", tranforama a virgual em ".")
         */
        
        public override string ToString()
        {
            
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
