using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula.Execptions
{
    internal class ValidaçãoEmailException : System.Exception
    {
        internal ValidaçãoEmailException(string mensagem) : base(mensagem)
        {

        }
    }
}
