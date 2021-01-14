using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Modelos
{
    public abstract class ParceiroComercial : IAutenticavel
    {
        private AutenticadorHelper _autenticadorHelper = new AutenticadorHelper();

        public string Senha { get; set; }
                
        public bool Autenticar(string senha)
        {
            return _autenticadorHelper.CompararSenhas(Senha, senha);
        }
    }
}