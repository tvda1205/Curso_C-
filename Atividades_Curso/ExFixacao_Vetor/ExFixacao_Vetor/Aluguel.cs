using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacao_Vetor
{
    class Aluguel
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumbQuarto { get; set; }

        public Aluguel (string nome, string email, int numbQuarto)
        {
            Nome = nome;
            Email = email;
            NumbQuarto = numbQuarto;
        }


        public override string  ToString ()
        {
            return NumbQuarto.ToString() + ": "
                + Nome + ", "
                + Email;
        }
        


    }
}
