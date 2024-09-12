using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace S4_Ex2_Produtos
{
    class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        

        public double ValorTotalEmEstoque ()
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
