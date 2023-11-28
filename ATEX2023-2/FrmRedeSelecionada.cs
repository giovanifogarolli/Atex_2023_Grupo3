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
    public partial class FrmRedeSelecionada : MetroFramework.Forms.MetroForm
    {
        #region Backend
        string Id;
        string Caminho;
        string Nome;
        int op1, op2;
        DadosRede dredes = new DadosRede();
        public FrmRedeSelecionada(string caminho, string id, string nome)
        {
            InitializeComponent();
            Id = id;
            Caminho = caminho;
            Nome = nome;
        }
        private void FrmRedeSelecionada_Load(object sender, EventArgs e)
        {
            List<Control> Perguntas = new List<Control>()
            {
                gbPergunta1, lblPergunta1, lblPergunta2, lblPergunta3
            };
            List<RadioButton> Opcoes = new List<RadioButton>()
            {
                rdb1, rdb2, rdb3
            };

            lblNomeRede.Text = Nome;
            pictureBox3.ImageLocation = Caminho;
            dredes.IdAPP = int.Parse(Id);
            List<string> PerguntasD = new List<string>();
            List<string> OpcoesD = new List<string>();
            OpcoesD = dredes.loadOpcoes();
            PerguntasD = dredes.loadPerguntas();

            for (int i = 0; i < PerguntasD.Count; i++)
            {
                Perguntas[i].Text = PerguntasD[i].ToString();
            }
            for (int i = 0; i < OpcoesD.Count; i++)
            {
                Opcoes[i].Text = OpcoesD[i].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPergunta1.Text != string.Empty &&  txtPergunta2.Text != string.Empty && txtPergunta3.Text != string.Empty)
            {
                if (rdb1.Checked)
                {
                    op1 = 1;
                }
                if (rdb2.Checked)
                {
                    op1 = 2;
                }
                if (rdb3.Checked)
                {
                    op1 = 3;
                }

                List<string> dados = new List<string>()
                {
                    op1.ToString(),
                    txtPergunta1.Text,
                    txtPergunta2.Text,
                    txtPergunta3.Text,
                    Id
                };

                dredes.Conclui(dados);
                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmInicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

        }


        #endregion

        #region Frontend

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

        private void lblJogo_MouseHover(object sender, EventArgs e)
        {
            lblJogo.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblJogo_MouseLeave(object sender, EventArgs e)
        {
            lblJogo.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblRede_MouseHover(object sender, EventArgs e)
        {
            lblRede.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblRede_MouseLeave(object sender, EventArgs e)
        {
            lblRede.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void lblSobre_MouseHover(object sender, EventArgs e)
        {
            lblSobre.ForeColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            lblSobre.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmRedeSocial frmRedes = new FrmRedeSocial();
            this.Hide();
            frmRedes.ShowDialog();
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Cursor= Cursors.Default;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion
    }
}
