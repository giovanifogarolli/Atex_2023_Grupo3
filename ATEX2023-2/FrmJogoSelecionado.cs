using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace ATEX2023_2
{
    #region Backend
    public partial class FrmJogoSelecionado : MetroFramework.Forms.MetroForm
    {
        string Id;
        string Caminho;
        string Nome;
        int op1, op2;
        DadosJogos djogos = new DadosJogos();

        public FrmJogoSelecionado(string caminho, string id, string nome)
        {
            InitializeComponent();
            Id = id;
            Caminho = caminho;
            Nome = nome;
        }

        private void FrmJogoSelecionado_Load(object sender, EventArgs e)
        {
            List<Control> Perguntas = new List<Control>()
            {
                gbPergunta1, gbPergunta2, lblPgtAberta1, lblPgtAberta2
            };
            List<RadioButton> Opcoes = new List<RadioButton>()
            {
                rdb1, rdb2, rdb3, rdb4, rdb5, rdb6
            };

            lblTitulo.Text = Nome;
            pictureBox1.ImageLocation = Caminho;
            djogos.IdAPP = int.Parse(Id);
            List<string> PerguntasD = new List<string>();
            List<string> OpcoesD = new List<string>();
            OpcoesD = djogos.loadOpcoes();
            PerguntasD = djogos.loadPerguntas();

            for (int i = 0; i < PerguntasD.Count; i++)
            {
                Perguntas[i].Text = PerguntasD[i].ToString();
            }
            for (int i = 0; i < OpcoesD.Count; i++)
            {
                Opcoes[i].Text = OpcoesD[i].ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int rdbtrue = 0;
            List<RadioButton> rdbs = new List<RadioButton>()
            {
                 rdb4, rdb5, rdb6
            };
            for(int i = 0; i<rdbs.Count; i++)
            {
                if (rdbs[i].Checked)
                {
                    rdbtrue = 1;
                }
                else
                {
                    rdbtrue = 0;
                }
            }
            if (txtPergunta1.Text != string.Empty && txtPergunta2.Text != string.Empty && rdbtrue == 1)
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
                if (rdb4.Checked)
                {
                    op2 = 4;
                }
                if (rdb5.Checked)
                {
                    op2 = 5;
                }
                if (rdb6.Checked)
                {
                    op2 = 6;
                }
                List<string> dados = new List<string>()
                {
                    op1.ToString(),
                    op2.ToString(),
                    txtPergunta1.Text,
                    txtPergunta2.Text,
                    Id
                };

                djogos.Conclui(dados);
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

    private void lblJogos_MouseHover(object sender, EventArgs e)
    {
        lblJogos.ForeColor = Color.BlueViolet;
        Cursor = Cursors.Hand;
    }

    private void lblJogos_MouseLeave(object sender, EventArgs e)
    {
        lblJogos.ForeColor = Color.Black;
        Cursor = Cursors.Default;
    }

    private void lblRedeSocial_MouseHover(object sender, EventArgs e)
    {
        lblRedeSocial.ForeColor = Color.BlueViolet;
        Cursor = Cursors.Hand;
    }

    private void lblRedeSocial_MouseLeave(object sender, EventArgs e)
    {
        lblRedeSocial.ForeColor = Color.Black;
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

    private void pctVoltar_MouseHover(object sender, EventArgs e)
    {
        Cursor = Cursors.Hand;
    }

    private void pctVoltar_MouseLeave(object sender, EventArgs e)
    {
        Cursor = Cursors.Default;
    }

    private void btnRegistrar_MouseHover(object sender, EventArgs e)
    {
        Cursor = Cursors.Hand;
    }

    private void btnRegistrar_MouseLeave(object sender, EventArgs e)
    {
        Cursor = Cursors.Default;
    }
    private void pctVoltar_Click(object sender, EventArgs e)
    {
        FrmJogos frmJogos = new FrmJogos();
        this.Hide();
        frmJogos.ShowDialog();
        this.Close();
    }
        #endregion
    }
}
