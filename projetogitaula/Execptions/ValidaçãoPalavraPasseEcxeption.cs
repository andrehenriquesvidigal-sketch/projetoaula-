using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula.Execptions
{
    internal class ValidaçãoPalavraPasseEcxeption : System.Exception
    {
        internal ValidaçãoPalavraPasseEcxeption(string mensagem) : base(mensagem)
        {

        }
    }
}
