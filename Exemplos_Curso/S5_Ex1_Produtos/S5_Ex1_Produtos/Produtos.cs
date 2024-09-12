using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace S5_Ex1_Produtos
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }



        public Produtos()
        {

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
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
            return Nome + " R$" + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades. Total de R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
