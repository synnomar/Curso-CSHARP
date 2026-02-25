using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Login : Form
    {
        //Usuario e senha fixos para teste
        private string usuarioCorreto = "sinomar.melo";
        private string senhaCorreta = "Spm@32215";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Btt01_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                MessageBox.Show("Login realizado com sucesso!","Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Abrir Form2
                Form2 tela = new Form2();
                tela.Show();

                // Ocultar Form1
                this.Hide();

            }
            else
            {
                MessageBox.Show("Erro de autenticação!, Usuario ou Senha incorretos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
           
        }
    }
}
