using projetogitaula.Execptions;
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
        public form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int posição = -1;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    throw new ValidaçãoCamposVaziosExecption("Preencha todos os campos");
                }
                if (!textBox2.Text.Contains("@") || !textBox2.Text.Contains("."))
                {
                    throw new ValidaçãoEmailException("O email tem de incluir um @ e um .");
                }
                for (int i = 0; i < globais.posicaoVazia; i++)
                {
                    if(globais.listaUtilizadores[i].nome == textBox1.Text)
                    {
                        posição = i;
                        break;
                    }
                }
                if (posição == -1)
                {
                    throw new ConfirmaçãoNome("Não existe tal nome com conta criada");
                }
                if (globais.listaUtilizadores[posição].email != textBox2.Text)
                {
                    throw new ValidaçãoEmailException("O email não corresponde a este nome");
                }
                if (globais.listaUtilizadores[posição].senha != textBox4.Text)
                {
                    throw new ValidaçãoPalavraPasseEcxeption("A palavra passe está errada, tenta de novo");
                }
                globais.utilizadorAtual = posição;
                MessageBox.Show("Sessão iniciada com sucesso", "inicio de sessão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form4 form4 = new form4();
                form4.Show();
            }
            catch (ValidaçãoCamposVaziosExecption ex)
            {
                MessageBox.Show(ex.Message, "Preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ConfirmaçãoNome ex)
            {
                MessageBox.Show(ex.Message, "confirmação do nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("ira ser redirecionado para criar uma conta", "Inicio de sessao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form3 form3 = new Form3();
                form3.Show();
            }
            catch(ValidaçãoEmailException ex)
            {
                MessageBox.Show(ex.Message, "confirmação do email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Criação de conta", "ira ser redirecionado para criar uma conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
            }
            catch(ValidaçãoPalavraPasseEcxeption ex)
            {
                MessageBox.Show(ex.Message, "palavra passe",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox4.Clear();
                textBox4.Focus();
            }
        }
    }
}
