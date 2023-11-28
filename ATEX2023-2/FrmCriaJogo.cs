using ATEX2023_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATEX2023_2
{
    public partial class FrmCriaJogo : MetroFramework.Forms.MetroForm
    {
        public FrmCriaJogo()
        {
            InitializeComponent();
        }

        #region Back End

        DadosJogos djogos = new DadosJogos();
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<string> dados = new List<string>
            {
                txtNomeJogo.Text,
                pctImagem.ImageLocation.ToString(),
                txtPgtFechada1.Text,
                txtPgtFechada2.Text,
                txtPgtAberta1.Text,
                txtPgtAberta2.Text,
                txtPgtFch1Resp1.Text,
                txtPgtFch1Resp2.Text,
                txtPgtFch1Resp3.Text,
                txtPgtFch2Resp1.Text,
                txtPgtFch2Resp2.Text,
                txtPgtFch2Resp3.Text,
            };
            djogos.CriaJogo(dados);
        }

        private void btnAdcArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Escolha uma imagem";
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctImagem.ImageLocation = ofd.FileName;
            }
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.ShowDialog();
            this.Close();
        }

        #endregion

        #region Front end
        private void lblInicio_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lblInicio.ForeColor = Color.BlueViolet;
        }

        private void lblInicio_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lblInicio.ForeColor = Color.Black;
        }

        private void lblJogos_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lblInicio.ForeColor = Color.BlueViolet;
        }

        private void lblJogos_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lblInicio.ForeColor = Color.Black;
        }

        private void lblRedeSocial_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lblInicio.ForeColor = Color.BlueViolet;
        }

        private void lblRedeSocial_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lblInicio.ForeColor = Color.Black;
        }

        private void lblSobre_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lblInicio.ForeColor = Color.BlueViolet;
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lblInicio.ForeColor = Color.Black;
        }

        #endregion
    }
}
