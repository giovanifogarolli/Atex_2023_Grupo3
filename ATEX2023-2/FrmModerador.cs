using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATEX2023_2
{
    public partial class FrmModerador : MetroFramework.Forms.MetroForm
    {
        public FrmModerador()
        {
            InitializeComponent();
        }
        moderador mod = new moderador();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para continuar");
            }
            else if (!mod.vereficaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido!");
            }
            else
            {
                
                mod.Nome = txtNome.Text;
                mod.Email = txtEmail.Text;
                mod.Senha = txtSenha.Text;
                mod.incluirDados();
                MessageBox.Show("Moderador cadastrado com sucesso!");
                txtEmail.Text = txtSenha.Text = txtNome.Text = "";
                this.Hide();
                new FrmLoginModerador().ShowDialog();
                this.Close();
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLoginModerador().ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCadastro().ShowDialog();
            this.Close();
        }
    }
}
