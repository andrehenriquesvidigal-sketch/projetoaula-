using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetogitaula
{
    public partial class form2 : Form
    {
        public struct Utilizador
        {
            public string nome;
            public string email;
            public string senha;
            public DateTime dataNascimento;
        }
        public form2()
        {
            InitializeComponent();
        }

        private void keydown_confirmação(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                }
            }
        }

        
    }
}
