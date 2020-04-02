using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] vect = new Estudante[10];



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
                Console.WriteLine("Quartos Vagos");
                for (int a = 0; a < 10; a++)
                  if (vect[a] == null)
                    {
                        Console.WriteLine(i + ": " + vect[i]);
                    }
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

        }
    }
}
