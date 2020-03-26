using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula04
{
    class ProdutoSobrecarga
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public ProdutoSobrecarga(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public ProdutoSobrecarga(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
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
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
