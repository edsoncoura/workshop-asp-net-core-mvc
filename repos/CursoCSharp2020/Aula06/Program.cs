using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {

            /* vetores parte1

            Estudante[] vect = new Estudante[10];

           // Console.WriteLine(vect[]);
            
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("===================================================");
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine("");
            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < 10; i++) 
                if (vect[i] != null)
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
       
              
             */ //Fim Vetores parte 1


            //Inicio exercicio Veteroes Parte 2

           int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i <  n; i++ )
            {
                string nome = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = nome, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++ )
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE= " + avg.ToString("F2", CultureInfo.InvariantCulture));
            
        }
       

        
    }
}
