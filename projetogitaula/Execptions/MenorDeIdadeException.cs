using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula.Execptions
{
    internal class MenorDeIdadeException : System.Exception
    {
        internal MenorDeIdadeException(string mensagem) : base(mensagem)
        {

        }
    }
}
