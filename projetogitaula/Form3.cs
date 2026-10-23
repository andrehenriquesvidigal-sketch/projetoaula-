using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetogitaula
{
    public partial class Form3 : Form
    {
        public struct Utilizador
        {
            public string nome;
            public string email;
            public string senha;
            public DateTime dataNascimento;
        }
        public Form3()
        {
            InitializeComponent();
        }
        Utilizador[] utilizadores = new Utilizador[6];
        bool temNumero = false;
        private void keydown_textbox_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                foreach(char c in textBox1.Text)
                {
                    if (char.IsDigit(c))
                    {
                        temNumero = true;
                        break;
                    }
                }
            }
            if (temNumero)
            {
                MessageBox.Show("O texto não pode conter numeros","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.SelectAll();
            }
            else
            {
                
            }
        }
    }
}
