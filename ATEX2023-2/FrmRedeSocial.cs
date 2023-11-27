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

namespace ATEX2023_2
{
    public partial class FrmRedeSocial : MetroFramework.Forms.MetroForm
    {
        public FrmRedeSocial()
        {
            InitializeComponent();
        }

        #region Backend
        DadosRede dredes = new DadosRede();
        List<string> caminhos = null;
        List<string> nomes = null;
        List<int> ids = null;
        private void FrmRedeSocial_Load(object sender, EventArgs e)
        {
            var dados = dredes.load();
            caminhos = dados.Item1;
            nomes = dados.Item2;
            ids = dados.Item3;
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctRede1,
                pctRede2,
                pctRede3,
                pctRede4,
                pctRede5,
                pctRede6,
                pctRede7,
                pctRede8,
                pctRede9,
                pctRede10,
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
                pctRede6.Image.Save(mstream, pctRede6.Image.RawFormat);
                image = mstream.ToArray();
            }
            var imageconvertida = Convert.ToBase64String(image);

            if (string.Equals(image164, imageconvertida))
            {
                pctSeta.Hide();
            }
            else
            {
                pctSeta.Show();
                pctRede6.Hide();
                pctRede7.Hide();
                pctRede8.Hide();
                pctRede9.Hide();
                pctRede10.Hide();
            }
        }
        #endregion

        #region Images
        private void ClickImagem(PictureBox pic, int id)
        {
            var confirma = MessageBox.Show($"Deseja acessar o formúlario de {nomes[id]}?", "Continuar", MessageBoxButtons.YesNo);
            if (confirma == DialogResult.Yes)
            {
                this.Hide();
                FrmRedeSelecionada formulario = new FrmRedeSelecionada(pic.ImageLocation, pic.Tag.ToString(), nomes[id]);
                formulario.ShowDialog();
            }
        }

        private void pctRede1_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede1, 0);
        }

        private void pctRede2_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede2, 1);
        }

        private void pctRede3_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede3, 2);
        }

        private void pctRede4_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede4, 3);
        }

        private void pctRede5_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede5, 4);
        }

        private void pctRede6_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede6 , 5);
        }

        private void pctRede7_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede7, 6);
        }

        private void pctRede8_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede8, 7);
        }

        private void pctRede9_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede9,8);
        }

        private void pctRede10_Click(object sender, EventArgs e)
        {
            ClickImagem(pctRede10,9);
        }
        #endregion

        #region Setas
        private void pctVoltar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            this.Hide();
            frmInicio.ShowDialog();
            this.Close();
        }
        

        private void pctSeta_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctRede6,
                pctRede7,
                pctRede8,
                pctRede9,
                pctRede10
            };
            foreach (PictureBox pb in pictureBoxes)
            {
                if (pb.Tag != null && pb.Tag.ToString() != "Default")
                {
                    pb.Show();
                }
                pctSeta.Hide();
                pctRede2.Show();
                pctRede1.Hide();
                pctRede2.Hide();
                pctRede3.Hide();
                pctRede4.Hide();
                pctRede5.Hide();
            }
        }

        private void pctSeta2_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>
            {
                pctRede1,
                pctRede2,
                pctRede3,
                pctRede4,
                pctRede5,
            };
            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Show();
                pctSeta.Show();
                pctSeta2.Hide();
                pctRede6.Hide();
                pctRede7.Hide();
                pctRede8.Hide();
                pctRede9.Hide();
                pctRede10.Hide();
            }
        }
        #endregion
    }
}
