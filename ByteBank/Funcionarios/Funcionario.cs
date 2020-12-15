using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {   
     
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        // os construtores das bases derivadas sempres chamam o construtor da classe base
        //é necessário preencher o argumento do construtor da classe base na classe derivada
        public Funcionario(double salario, string cpf) //construtor 
        {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        //adicionar o modificador virtual nas classes derivadas (override) que vão utilizar esse método.
        public abstract void AumentarSalario();
      
        public abstract double GetBonificacao(); // um método abstrato só pode ser declarado se a sua classe raiz for abtsrata.
       
    }
}
