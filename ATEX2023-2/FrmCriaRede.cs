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
    public partial class FrmCriaRede : MetroFramework.Forms.MetroForm
    {
        public FrmCriaRede()
        {
            InitializeComponent();
        }

        #region BackEnd

        DadosRede dredes = new DadosRede();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            List<string> dados = new List<string>
            {
                txtNomeJogo.Text,
                pctImagem.ImageLocation.ToString(),
                txtPgtFechada1.Text,
                txtPgtAberta1.Text,
                txtPgtAberta2.Text,
                txtPgtAberta3.Text,
                txtPgtFch1Resp1.Text,
                txtPgtFch1Resp2.Text,
                txtPgtFch1Resp3.Text,
            };
            dredes.CriaRede(dados);
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
    }
}
