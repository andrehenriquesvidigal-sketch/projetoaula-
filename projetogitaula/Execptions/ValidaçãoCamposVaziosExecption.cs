using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula.Execptions
{
    internal class ValidaçãoCamposVaziosExecption : System.Exception
    {
        internal ValidaçãoCamposVaziosExecption(string mensagem) : base(mensagem) 
        {

        }
    }
}
