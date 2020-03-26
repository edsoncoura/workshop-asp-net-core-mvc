using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula05
{
    class Produto
    {

        //definicao das variaveis para a properties, tudo private.
        //private string _nome;
        //private double _preco;
        //private int _quantidade;
        //Final aqui das variaveis para a properties, com tudo private

        //definicao das variaveis para o auto-properties.
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Final aqui das variaveis para auto-properties


        //Construtor padra

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome; //nome nao pode ser feito pois ele tem uma logica 
            Preco = preco;
            Quantidade = quantidade;

        }

        /* metodo GET 
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if ( nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else
            {
                Console.WriteLine("Nao permitido");
            }
            
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }
        */

        //Criar o encapsulamento via Proprieties 
        //comeca aqui
        /*
        public string Nome
        {
            get { return _nome; }

            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Nao permitido");
                }
            }

        }

       
        public double Preco
        {
           get { return _preco; }
        }

        
        public int Quantidade
        {
            get { return _quantidade; }
        }
          *///Final Properties 

        //Inicio Auto Properties
        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Nao permitido");
                }
            }
        }



            //Final Auto Properties

            /* Novo construtor proposto no capitulo sobrecarga, onde o paramentro quantidade
             * será iniciado com o valor 5
             * */

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }




        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;

        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
