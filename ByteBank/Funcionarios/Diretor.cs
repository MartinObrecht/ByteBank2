using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario //herança
    {        
        public override double GetBonificacao() // é um método herdado do método virtual, qe foi declarada na classe base.
        {
            return Salario + base.GetBonificacao(); // usamos o GetBonificação da base, ou seja, do funcionário.
        }
    }
}
