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
            public string caminhoimagem;
            public DateTime dataNascimento;
        }
        public static Utilizador[] listaUtilizadores = new Utilizador[50];
        public static int posicaoVazia = 0;
        public static int utilizadorAtual = -1;
        
    }
}
