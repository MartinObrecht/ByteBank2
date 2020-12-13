using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {   
     
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
             
        public virtual double GetBonificacao() //é um método virtual e pode ser utilizado para as classes derivadas do funcionário
        {
            return Salario * 0.10;
        }
    }
}
