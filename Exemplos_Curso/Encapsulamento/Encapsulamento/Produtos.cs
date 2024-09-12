using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Produtos
    {
        /*private string _nome;
        private double _preco;
        private int _quantidade;
        */

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produtos(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }



        public Produtos()
        {

        }

        public string Nome { 
            
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        
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
