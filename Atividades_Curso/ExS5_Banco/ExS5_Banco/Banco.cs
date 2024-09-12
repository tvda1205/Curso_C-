using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExS5_Banco
{
     class Banco
    {
        public int NumbConta { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }
        

        public Banco(int numbConta, string titular, double saldo)
        {
            NumbConta = numbConta;
            _titular = titular;
            Saldo = saldo; 
        }
       


        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public double Saque(double saque)
        {

            Saldo = Saldo - saque - 5;

            return Saldo ;
        }

        public override string ToString()
        {
            return "Conta " + NumbConta + " , Titular:" + _titular
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
