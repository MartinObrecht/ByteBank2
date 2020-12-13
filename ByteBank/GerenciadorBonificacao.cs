using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao; // propriedade privada

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();// método utilizado para acessar a propriedade privada.
        }
      
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
