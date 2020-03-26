using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aula sobre encapsulamento
             * 
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";


            Console.WriteLine("O nome eh: " + p.Nome);
            Console.WriteLine("O preco eh: " + p.Preco);
            Console.WriteLine("A quantidade eh: " + p.Quantidade);
           
          /*      
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
          */       //final do exercicio

            //Termina aqui aula sobre encapsulamento

            /*Exercicio de fixacao
             * - Criar um cadastro de conta bancaria, informando numero conta, nome titula, valor deposito inicial
             * - O deposito inical deverá ser opcionale, ou seja, a conta podera ser aberta sem deposito incial
             * - neste caso a conta será aberta com o saldo zero.
             * - Aberta a conta o numero da conta não poderá ser alterado.
             * - O nome do titular poderá ser mudado
             * - O saldo da conta não pode ser alterado livremente, é necessário um mecanismo para proteger.
             * - O saldo só será aumntado por meio de deposistos
             * - O saldo só será diminuido por meio de saques
             * - Para cada saque será cobrado uma taxa de $5.00, a conta pode ficar com slado negativo
             * - caso não tenha saldo suficiente
             * - fazer um programa que realize o cadastro conforme acima, dando a opção para que seja ou 
             *   informado o valor de deposito inical. Em seguida, realziar um deposito e depois um sque, sempre mostrando
             *   os dados da conta após cada operação.
             *   -------------------------------------
             *   - Numero: Interger
             *   - Titula: String
             *   - saldo: Double
             *   =====================================
             *   + deposito(quantia: double): void
             *   + Saque(quantia: double): void
             *   -------------------------------------
             */


            
            Console.Write("Entre o numero da conta: ");
            int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta:" );
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito incial (s/n)? ");
            char depResp = char.Parse(Console.ReadLine());
            if ( depResp == 's' || depResp == 'S' )
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Saldo incial eh: " + depInicial);
            }






            //termina aqui o MAIN
        }

        //termina aqui a class Program
    }
//termina aqui o namespace Aula5
}
