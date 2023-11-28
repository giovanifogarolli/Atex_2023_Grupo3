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
    public partial class FrmLoginModerador : MetroFramework.Forms.MetroForm
    {
        public FrmLoginModerador()
        {
            InitializeComponent();
        }

        private void FrmLoginModerador_Load(object sender, EventArgs e)
        {

        }
        moderador mod = new moderador();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para continuar!");
            }
            else if (!mod.vereficaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email inválido!");
            }
            else
            {
                
                mod.Email = txtEmail.Text;
                mod.Senha = txtSenha.Text;
                if (!mod.vereficaSenha())
                    MessageBox.Show("Email ou Senha incorretos!");
                else
                {
                    Program.ehMod = 1;
                    MessageBox.Show("Bem vindo(a)!");
                    this.Hide();
                    new FrmJogos().ShowDialog();
                    this.Close();
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmModerador().ShowDialog();
            this.Close();
        }
    }
}
