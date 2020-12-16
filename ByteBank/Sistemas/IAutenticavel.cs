using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel// autenticavel é uma interface
    {
        bool Autenticar(string senha);
    }
}
