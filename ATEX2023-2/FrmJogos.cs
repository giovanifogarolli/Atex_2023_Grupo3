using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ATEX2023_2
{
    public partial class FrmJogos : MetroFramework.Forms.MetroForm
    {
        public FrmJogos()
        {
            InitializeComponent();
        }

        #region BackEnd
        DadosJogos djogos = new DadosJogos();
        List<string> caminhos = null;
        List<string> nomes = null;
        List<int> ids = null;

        private void FrmJogos_Load(object sender, EventArgs e)
        {
            var dados = djogos.load();
            caminhos = dados.Item1;
            nomes = dados.Item2;
            ids = dados.Item3;

            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctJogo1,
                pctJogo2,
                pctJogo3,
                pctJogo4,
                pctJogo5,
                pctJogo6,
                pctJogo7,
                pctJogo8,
                pctJogo9,
                pctJogo10
            };


            for (int i = 0; i < caminhos.Count; i++)
            {
                pictureBoxes[i].Load(caminhos[i]);
                pictureBoxes[i].Tag = ids[i];
            }


            byte[] image1Bytes;
            using (var mstream = new MemoryStream())
            {
                Properties.Resources.imagem.Save(mstream, Properties.Resources.imagem.RawFormat);
                image1Bytes = mstream.ToArray();
            }
            var image164 = Convert.ToBase64String(image1Bytes);
            foreach (PictureBox pb in this.Controls)
            {
                byte[] image2Bytes;
                if (pb.Image != null)
                {
                    using (var mstream = new MemoryStream())
                    {
                        pb.Image.Save(mstream, pb.Image.RawFormat);
                        image2Bytes = mstream.ToArray();
                    }

                    var image264 = Convert.ToBase64String(image2Bytes);

                    if (string.Equals(image164, image264))
                    {
                        pb.Hide();
                        pb.Tag = "Default";
                    }
                }
            }
            byte[] image;
            using (var mstream = new MemoryStream())
            {
                pctJogo6.Image.Save(mstream, pctJogo6.Image.RawFormat);
                image = mstream.ToArray();
            }
            var imageconvertida = Convert.ToBase64String(image);

            if (string.Equals(image164, imageconvertida)) {
                pctSeta.Hide();
            }
            else
            {
                pctSeta.Show();
                pctJogo6.Hide();
                pctJogo7.Hide();
                pctJogo8.Hide();
                pctJogo9.Hide();
                pctJogo10.Hide();
            }
        }
        #endregion

        #region ClickIMG
        private void ClickImagem(PictureBox pic, int id)
        {
            var confirma = MessageBox.Show($"Deseja acessar o formúlario de {nomes[id]}?", "Continuar", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Hide();
                FrmJogoSelecionado formulario = new FrmJogoSelecionado(pic.ImageLocation, pic.Tag.ToString(), nomes[id]);
                formulario.ShowDialog();
            }
        }
        private void pctJogo1_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo1, 0);
        }

        private void pctJogo2_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo2, 1);
        }

        private void pctJogo3_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo3, 2);
        }

        private void pctJogo4_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo4, 3);
        }

        private void pctJogo5_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo5, 4);
        }

        private void pctJogo6_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo6, 5);
        }

        private void pctJogo7_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo7, 6);
        }

        private void pctJogo8_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo8, 7);
        }

        private void pctJogo9_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo9, 8);
        }

        private void pctJogo10_Click(object sender, EventArgs e)
        {
            ClickImagem(pctJogo10, 9);
        }
        #endregion

        #region Setas
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            this.Hide();
            frmInicio.ShowDialog();
            this.Close();
        }
        private void pctSeta_Click_1(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctJogo6,
                pctJogo7,
                pctJogo8,
                pctJogo9,
                pctJogo10
            };
            foreach (PictureBox pb in pictureBoxes)
            {
                if(pb.Tag != null && pb.Tag.ToString() != "Default")
                {
                    pb.Show();
                }
                pctSeta.Hide();
                pctSeta2.Show();
                pctJogo1.Hide();
                pctJogo2.Hide();
                pctJogo3.Hide();
                pctJogo4.Hide();
                pctJogo5.Hide();
            }
        }

        private void pctSeta2_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctJogo1,
                pctJogo2,
                pctJogo3,
                pctJogo4,
                pctJogo5,
            };
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Show();
                pctSeta.Show();
                pctSeta2.Hide();
                pctJogo6.Hide();
                pctJogo7.Hide();
                pctJogo8.Hide();
                pctJogo9.Hide();
                pctJogo10.Hide();
            }
        }
        #endregion

        #region FrontEnd
        private void pctJogo1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        private void pctJogo2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo4_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo5_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo6_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo7_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo8_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo9_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo9_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctJogo10_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctJogo10_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctSeta_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctSeta_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctVoltar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pctVoltar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pctSeta_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}