using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula.Execptions
{
    internal class ConfirmaçãoNome : System.Exception
    {
        internal ConfirmaçãoNome(string mensagem) : base(mensagem)
        {

        }
    }
}
