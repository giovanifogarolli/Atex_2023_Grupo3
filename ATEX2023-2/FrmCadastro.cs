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
    public partial class FrmCadastro : MetroFramework.Forms.MetroForm
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmModerador frmModerador = new FrmModerador();
            this.Hide();
            frmModerador.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtEscola.Text == string.Empty || txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para continuar!");
            }
            else
            {
                user user = new user();
                user.Nome = txtNome.Text;
                user.Escola = txtEscola.Text;
                user.AnoEscolar = rdbSegundo.Checked?2:rdbTerceiro.Checked?3:1;
                user.Idade = rdb8.Checked?8:rdb9.Checked?9:7;
                user.incluirDados();
                MessageBox.Show($"Bem vindo, {txtNome.Text}!");
                this.Hide();
                new FrmInicio().ShowDialog();
                this.Close();
            }
            
        }
        #region frontEnd
        private void btnRegistrar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            Cursor= Cursors.Default;
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdb7_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdb7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdb8_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdb8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdb9_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdb9_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdbPrimeiro_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdbPrimeiro_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdbSegundo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdbSegundo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void rdbTerceiro_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void rdbTerceiro_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion
    }
}
