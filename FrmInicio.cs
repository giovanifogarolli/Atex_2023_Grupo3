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
    public partial class FrmInicio : MetroFramework.Forms.MetroForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void lblInicio_MouseHover(object sender, EventArgs e)
        {
            lblInicio.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblInicio_MouseLeave(object sender, EventArgs e)
        {
            lblInicio.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblJogos_MouseHover(object sender, EventArgs e)
        {
            lblJogos.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblJogos_MouseLeave(object sender, EventArgs e)
        {
            lblJogos.ForeColor= Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblRedeSocial_MouseHover(object sender, EventArgs e)
        {
            lblRedeSocial.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblRedeSocial_MouseLeave(object sender, EventArgs e)
        {
            lblRedeSocial.ForeColor= Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblSobre_MouseHover(object sender, EventArgs e)
        {
            lblSair.ForeColor = Color.BlueViolet;
            Cursor= Cursors.Hand;
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            lblSair.ForeColor= Color.Black;
            Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Program.ehMod == 1)
            {
                this.Hide();
                FrmCriaRede frmCriaRede = new FrmCriaRede();
                frmCriaRede.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                FrmRedeSocial frmRedeSocial = new FrmRedeSocial();
                frmRedeSocial.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(Program.ehMod == 1)
            {
                this.Hide();
                FrmCriaJogo frmCriaJogo = new FrmCriaJogo();
                frmCriaJogo.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                FrmJogos frmJogo = new FrmJogos();
                frmJogo.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogos_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogos_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
            this.Close();
        }
    }
}
