using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Listas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome{ get; set; }

        public double Salario { get; set; }


        public Funcionario(int id, string nome, double salario) { 
        
            Id = id;    
            Nome = nome;
            Salario = salario;

        }





        public override string ToString()
        {
            return Id + " ," + Nome + ", " + Salario;
        }
    }
}
