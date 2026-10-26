using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogitaula
{
    internal class globais
    {
        public struct Utilizador
        {
            public string nome;
            public string email;
            public string senha;
            public DateTime dataNascimento;
        }
        Utilizador[] listautilizadores = new Utilizador[50];
    }
}
