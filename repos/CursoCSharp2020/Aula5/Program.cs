using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {

        /*    Inicio dobre sobrecarga recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porem
         * com diferentes listas de parametros.
         * --- Proposta de melhoria no exercicio do Produto:
         * - Criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste 
         *   novo produto, por padrão, deverá então seer iniciada com o valor 5.
         *   ->> Nota:
         *            é possivel tambem incluir um construtor padrão (sem parametro)
         *            */

            //Produto p = new Produto(nome, preco, quantidade); /estanciamento ser depois da tela de entrada

             
          Console.WriteLine("Entre os dados do produto:");
          Console.Write("Nome: ");
          string nome = Console.ReadLine();
          Console.Write("Preço: ");
          double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Comentado pois será utilziado o construtor com o parametro com quantidade zerado
            // Console.Write("Quantidade no estoque: ");
            // p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             

           Produto p = new Produto(nome, preco); //estaciamento do novo produto com o construtor de 2 argumentos

            Console.WriteLine("Dados do produto: " +  p);

          Console.WriteLine();//Linha em branco para melhor visualização na tela

          Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
          int qtdade = int.Parse(Console.ReadLine()); //este valor sera passado como atributo pra
                                                      //o metodo AdicionarProduto(quantidade)
          p.AdicionarProdutos(qtdade);//chamada da classe Produto estanciada como "p", passando o atributo
                                      //esperado pelo metodo AdicionarProdutos
          Console.WriteLine("Dados atualziados: " + p);

          Console.WriteLine();

          Console.Write("Digite o número de produtos a ser removido do estoque: ");
          qtdade = int.Parse(Console.ReadLine());
          p.RemoverProdutos(qtdade);
          Console.WriteLine("Dados atualziados: " +p);
           //final do exercicio



            //termina aqui o MAIN
        }

        //termina aqui a class Program
    }
//termina aqui o namespace Aula5
}
