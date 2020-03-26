using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada de Dados 
            /*
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            //Outra meaneira de fazer

            string[] vet1 = Console.ReadLine().Split(' ');

            string p4 = vet1[0];
            string p5 = vet1[1];
            string p6 = vet1[2];

            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);
                         
             */

            //Conversão

            /* int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3]);
            
            Console.WriteLine("Voce digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------");
            Console.WriteLine("Voce digitou");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*Exercio Fixação:
             * Fazer um programa para executar a seguinte interação com o usuario, 
             * lendo os valores destacados, e depois mostrar os dados na tela.
             * - Entre com seu nome completo:
             *   Alex Green
             * - Quantos quartos tem na sua casa?
             *   3
             * - Entre com o preço de um produto:
             *   500.50
             * - Entre com seu último nome, idade e altura (mesma linha):
             *   Green 21 1.73
             *   
             *   A saida esperada (Mumeros reais com duas casa decimas):
             *   Alex Green
             *   3
             *   500.50
             *   Green
             *   21
             *   1.73
             * 
            

            Console.WriteLine("Entre com seu nome completo;");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura:");
            string[] vet2 = Console.ReadLine().Split(' ');
            string ultimoNome = vet2[0];
            int idade = int.Parse(vet2[1]);
            double altura = double.Parse(vet2[2]);
            

            Console.WriteLine("----saida dos dados -----");

            Console.WriteLine("O nome e: " + nome);
            Console.WriteLine("A casa tem: " + quartos + " quartos");
            Console.WriteLine("O preço eh " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("---Nome, idade e altura---");
            Console.WriteLine("Seu ultimo nome e: " + ultimoNome);
            Console.WriteLine("Sua idade e: " + idade);
            Console.WriteLine("Sua altura e: " + altura.ToString("F2", CultureInfo.InvariantCulture));

            */

            /*Operadores comparativos

            int a = 10;

            bool c1 = a < 10;
            bool c2 = a < 20;
            
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            bool c3 = 4 != 5; //true
            bool c4 = 4 == 5; //false
            bool c5 = 4 >= 5 || 4 < 5; //true
            bool c6 = !(2 > 3) && 4 != 5; //true

            bool c7 = 10 < 5; // false
            bool c8 = c1 || c2 && c3; // true

            Console.WriteLine(c3); // false
            Console.WriteLine(c4); // 
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            */

            //Estrutura condicional

            /*int x = 10;

            Console.WriteLine("Bom dia!");

            if ( x > 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");
            

            Console.WriteLine("Entre com o numero inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

            
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if ( hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if( hora < 18) {
                Console.WriteLine("Boa tarde");
            }

            else 
            {
                Console.WriteLine("Boa noite");
            }

            */

            /* Exercicio 6

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) { 
            
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            
             */
            /*
           Console.WriteLine("Digite as coodernadas X e Y");
           string[] coordenadas = Console.ReadLine().Split(' ');

           double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
           double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);


           if ( x > 0 && y > 0)
           {
               Console.WriteLine("Q1");
           }
           else if ( x < 0 && y > 0)
           {
               Console.WriteLine("Q2");
           }
           else if ( x < 0  && y < 0 )
           {
               Console.WriteLine("Q3");
           }
           else if ( x > 0 && y < 0)
           {
               Console.WriteLine("Q4");
           }
           else if ( x == 0 )
           {
               Console.WriteLine("Eixo Y");
           }
           else if ( y == 0 )
           {
               Console.WriteLine("Eixo X");
           }
           else
           {
               Console.WriteLine("Origem");
           }
           */

            //funcoes basicas

            /* Sem criar uma função
            Console.WriteLine("Digite 3 numeros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 & n1 > n3)
            {
                Console.WriteLine("Maio = " + n1);
            }
            else if ( n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior =" + n3);
            }

            */

            /* Criando uma função para verificar qual numero é o maior

            Console.WriteLine("Digite 3 numeros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            
            Console.WriteLine("Maior = " + resultado);
            */

            /* While

            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine( "Numero Negativo!");

            */


            // FOR for ( inicio; condição; incremento)

            /*Digitar um numero N e depois N valores inteiros. Mostrar a soma dos N vlaores digitados.

            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int nvezes = int.Parse(Console.ReadLine());

            int soma = 0; 
            for ( int i = 1; i <= nvezes; i++)
            {
                Console.Write("Valor : #{0}: " , i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("A soma é: " + soma);

            */





            //-------Final ate aqui
        }

        /*
        //Criação da funcao "Maior" exercio funcao

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c )
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }


    */

            //Final aqui tambem


    }
}
