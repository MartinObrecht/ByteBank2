using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel //diretor agora é filho da classe autenticavel
    {
        //o salario inicial do cardo diretor é de 5000, por isso já esta declarado como argumento.
        public Diretor(string cpf) : base(5000, cpf)
        { 
            
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao() // é um método herdado do método virtual, qe foi declarada na classe base.
        {
            return Salario *0.5; // usamos o GetBonificação da base, ou seja, do funcionário.
        }
    }
}
