using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            /* sem orientação a objeto

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Mario area Y");
            }
            */

            /* Com orientação objeto, foi criada a classe Triangulo e la colocado os
             * lados do Triangulo
             * Apos isso no main inserido os dois triangulos do exercicios
             * Triangulo x, y, z;
             * instanciados os dois triangulos:
             *  x = new Triangulo();
             *  y = new Triangulo();
             *  z = new Triangulo();
             * os comandos demais são os mesmos do anterior
             
            ------Triangulo Inicia aqui ---

            Triangulo x, y, z;

            x = new Triangulo();
            y = new Triangulo();
            z = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo X:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo z:");
            z.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            p = (z.A + z.B + z.C) / 2.0;
            double areaZ = Math.Sqrt(p * (p - z.A) * (p - z.B) * (p - z.C));


            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Z =" + areaZ.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if ( areaY > areaZ)
            {
                Console.WriteLine("Mario area Y");
            }
            else
            {
                Console.WriteLine("Mario area Z");
            }

            --- Triangulo termina aqui */

            //Exercicios 
            /* --- Incio Exercicio 1 Pessoas
             * (Fazer um programa para ler os dados de 2 pessoas, depois mostrar o nome
             * da pessoa mais velha
             * - Para este exercicio, foi criada a class Pessoa, com os atributos (dados/campos) Nome e Idade
             * 
             * 
            Pessoa p1 = new Pessoa(); //instanciada a primeira pessoa como P1
            Pessoa p2 = new Pessoa(); //instanciada a segunda pessoal como P2

            Console.WriteLine("Digite os dados conforme abaixo:");
            Console.WriteLine("==================================");
            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Inisira o Nome:");
            p1.Nome = Console.ReadLine(); //a instancia p1 classe Pessoa receberá o dado Nome da console
            Console.WriteLine("Inisira a Idade:");
            p1.Idade = int.Parse(Console.ReadLine()); //a instancia p1 classe Pessoa receberá o dado Idade da console 
            Console.WriteLine("==================================");
            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Inisira o Nome:");
            p2.Nome = Console.ReadLine();//a instancia p2 classe Pessoa receberá o dado do objeto Nome da console
            Console.WriteLine("Inisira a Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }

            --- Fim do Exercicio 1 - Pessoas */

            /* --- Incio do exercio 2 -
             * Fazere um programa para ler nome e salario de 2 funcionarios.
             * Depois mostrar o salário médio dos funcionairos
             * - Criada a class Funcionários com os dois atributos(dados) Nome e salario
             

            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            double mediaSal;

            Console.WriteLine("Digite os dados conforme abaixo:");
            Console.WriteLine("==================================");
            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Inisira o Nome:");
            f1.Nome = (Console.ReadLine());
            Console.Write("Inisira o Salario:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("==================================");
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Inisira o Nome:");
            f2.Nome = (Console.ReadLine());
            Console.Write("Inisira o Salario:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaSal = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("O salario medio é:" + (mediaSal.ToString("F2", CultureInfo.InvariantCulture)));

             --- Final do exercicio 2 */


            /*Melhora o projeto de triangulo
             * Como melhora o calculo do triangulo será feito por um metodo na classe Triangulo
             * Este metodo tem o nome Area, onde não recebera nenhum atributo pois ele faz parte 
             * da mesma classe, caso fosse de outra classe teria que receber os atributos A, B, C
             * da classe Triangulo
             * - Apos a criação dessa classe, o metodo será chamado diretamente no Main, conforme abaixo:
             * double areaX = x.Area(); 
             * double areaY = y.Area(); e assim por diante.


            /*
            Triangulo x, y, z;

            x = new Triangulo();
            y = new Triangulo();
            z = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo X:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo z:");
            z.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areaX = x.Area();

            double areaY = y.Area();

            double areaZ = z.Area();

            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Z =" + areaZ.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaY > areaZ)
            {
                Console.WriteLine("Mario area Y");
            }
            else
            {
                Console.WriteLine("Mario area Z");
            }

            */ //---Final da melhora do Triangulo aqui

            /* Resolvendo Problema aula 4
             * Fazer um programa para ler dos dados de um produto em estoque (nome, preço e quantidade no estoque)
             * - Mostrar os dados do produto (noem, preço, quantidae no estoque, vlr total no estoque)
             * - realizar uma entrada no estoque e mostrar novamente os dados do produto
             * - realizar uma saida no estoque e mostrar novamente os dados do produto
             * UML
             * --------------------------------------------
             * Produto                                      //classe criada
             * --------------------------------------------
             * - Nome: string
             * - Preco: double
             * - quantidade: int
             * --------------------------------------------
             * + ValorTotalEmEstoque(): double
             * + AdicionarProdutos(quantidade: int) void
             * + RemoverProdutos(quantidade: int) void
             * --------------------------------------------
             * 
             */
            /*
           Produto p = new Produto();

           Console.WriteLine("Entre os dados do produto:");
           Console.Write("Nome: ");
           p.Nome = Console.ReadLine();
           Console.Write("Preço: ");
           p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.Write("Quantidade no estoque: ");
           p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


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
           */ //final do exercicio

            /* Exercico 1 final da aula 4
             * Fazer um programa para ler os valroes da larqgura e altura de um retangulo.
             * Em seguida, mostrar na tela o valor de sua area, perimetro e diagonal.
             * Usar uma classe como mostrado no projeto ao lado.
             * UML
             * ---------------------------
             *  Retangulo
             * ---------------------------
             * - Largura: double
             * - Altura: double
             * ---------------------------
             * + Area(): double
             * + Perimetro(): double
             * + Diagonal(): double
             * ---------------------------
             */

            /* -- Inicia aqui
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = "  + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            //chama o metod Area() e transforma ele em string com 2 casa decimais, com isso não é
            //necessário fazer o metodo overwriter para tostring

            Console.WriteLine("Perimetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            */ // final aqui

            /* Exercicio 2 final aula 4
             * Fazer um programa para ler os dadso de um funcionario (nome, salario bruto e imposto).
             * Em seguida, mostrar os dados do funcionario (nome e salario liquido). Em seguida,
             * aumentar o salario do funcionario com base em uma porcentagem dada (somente o salario
             * bruto e afetado pela porcentagem) e mostrar os dados do funcionario. Use a classe
             * projetada abaixo
             * UML
             * ---------------------------------------------
             * Funcionario
             * ---------------------------------------------
             * - Nome: string
             * - SalarioBruto: double
             * - Imposto: double
             * ---------------------------------------------
             * + SalarioLiquido(): double
             * + AumentarSalario(porcentagem: double) void
             * ---------------------------------------------
             * 
             * 
             */

            /* - Exercio 2 inicia aqui
             * 
            Funcionario func = new Funcionario();

            Console.Write("Nome: "); 
            func.Nome = Console.ReadLine(); //Carrega o atributo Nome na classe instaciada como func
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //carrega o atributo 
                                                                                                //SalarioBruto na classe
                                                                                                //isntanciada como func
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //carrega o atributo
                                                                                           // Imposto na classe
                                                                                           //instanciada como func
            Console.WriteLine("Funcionario: " + func);


            Console.Write("Digite a % para aumentar o salario: ");
            //Na linha abaixo é criada a variavel porcent, que conterá o valor que será passado para o metodo
            //AumentarSalario(porcentagem), que foi criado na classe Funcionario
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            func.AumentarSalario(porcent); //chama o metodo AumentarSalario, com o valor do variavel porcent, que foi
                                           // criada na linha acima

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

            */ //Exervcio 2 - termina aqui


            /*Inicio do exercicio 3

            Aluno aluno = new Aluno();
            
            
            Console.WriteLine("Nome do Aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno:");

            aluno.Nota1  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            Console.WriteLine();

            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));



            if (aluno.ResultadoFinal())

            {

                Console.WriteLine("APROVADO");

            }

            else

            {

                Console.WriteLine("REPROVADO");

                Console.WriteLine("FALTARAM "

                             + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)

                              + " PONTOS");

            }

            *///===============Termina aqui Main do Exercio Fização 3 aula 4 ======


            /* Inicio dobre sobrecarga recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porem
             * com diferentes listas de parametros.
             * --- Proposta de melhoria no exercicio do Produto:
             * - Criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste 
             *   novo produto, por padrão, deverá então seer iniciada com o valor 5.
             *   ->> Nota:
             *            é possivel tambem incluir um construtor padrão (sem parametro)
             *            */

            //Produto p = new Produto(nome, preco, quantidade); /estanciamento ser depois da tela de entrada

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
           *///final do exercicio

             




        }  //final aqui





    } //final aqui
} //final aqui

