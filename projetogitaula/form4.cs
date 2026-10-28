using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetogitaula
{
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void form4_Load(object sender, EventArgs e)
        {
            if(globais.utilizadorAtual == -1)
            {
                MessageBox.Show("Nenhum Utilizador com sessão iniciada");
                this.Close();
                return;
            }
            var utilizador = globais.listaUtilizadores[globais.utilizadorAtual];
            if (!string.IsNullOrEmpty(utilizador.caminhoimagem) && File.Exists(utilizador.caminhoimagem))
            {
                pictureboxredondo1.Image = Image.FromFile(utilizador.caminhoimagem);
            }
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox1.Text = utilizador.nome;
            textBox2.Text = utilizador.email;
            textBox3.Text = utilizador.senha;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolhe uma imagem de perfil";
            openFileDialog1.Filter = "Imagens|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFileDialog1.FileName;


                pictureboxredondo1.Image = Image.FromFile(caminho);
                globais.listaUtilizadores[globais.utilizadorAtual].caminhoimagem = caminho;
            }
        }
    }
}
