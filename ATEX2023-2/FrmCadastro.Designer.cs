namespace ATEX2023_2
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblPreencha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.rdbTerceiro = new System.Windows.Forms.RadioButton();
            this.rdbSegundo = new System.Windows.Forms.RadioButton();
            this.rdbPrimeiro = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblCadastro.Location = new System.Drawing.Point(871, 44);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(176, 33);
            this.lblCadastro.TabIndex = 1;
            this.lblCadastro.Text = "CADASTRO";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPreencha
            // 
            this.lblPreencha.AutoSize = true;
            this.lblPreencha.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPreencha.Location = new System.Drawing.Point(843, 83);
            this.lblPreencha.Name = "lblPreencha";
            this.lblPreencha.Size = new System.Drawing.Size(230, 16);
            this.lblPreencha.TabIndex = 2;
            this.lblPreencha.Text = "PREENCHA PARA SE CADASTRAR";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "______________________________________";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(843, 155);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "DIGITE SEU NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(846, 178);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(846, 393);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(201, 22);
            this.txtEscola.TabIndex = 11;
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscola.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEscola.Location = new System.Drawing.Point(843, 370);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(54, 15);
            this.lblEscola.TabIndex = 10;
            this.lblEscola.Text = "ESCOLA";
            // 
            // rdbTerceiro
            // 
            this.rdbTerceiro.AutoSize = true;
            this.rdbTerceiro.Location = new System.Drawing.Point(10, 80);
            this.rdbTerceiro.Name = "rdbTerceiro";
            this.rdbTerceiro.Size = new System.Drawing.Size(137, 20);
            this.rdbTerceiro.TabIndex = 15;
            this.rdbTerceiro.Text = "Terceiro ou acima";
            this.rdbTerceiro.UseVisualStyleBackColor = true;
            this.rdbTerceiro.MouseLeave += new System.EventHandler(this.rdbTerceiro_MouseLeave);
            this.rdbTerceiro.MouseHover += new System.EventHandler(this.rdbTerceiro_MouseHover);
            // 
            // rdbSegundo
            // 
            this.rdbSegundo.AutoSize = true;
            this.rdbSegundo.Location = new System.Drawing.Point(10, 54);
            this.rdbSegundo.Name = "rdbSegundo";
            this.rdbSegundo.Size = new System.Drawing.Size(83, 20);
            this.rdbSegundo.TabIndex = 14;
            this.rdbSegundo.Text = "Segundo";
            this.rdbSegundo.UseVisualStyleBackColor = true;
            this.rdbSegundo.MouseLeave += new System.EventHandler(this.rdbSegundo_MouseLeave);
            this.rdbSegundo.MouseHover += new System.EventHandler(this.rdbSegundo_MouseHover);
            // 
            // rdbPrimeiro
            // 
            this.rdbPrimeiro.AutoSize = true;
            this.rdbPrimeiro.Checked = true;
            this.rdbPrimeiro.Location = new System.Drawing.Point(10, 28);
            this.rdbPrimeiro.Name = "rdbPrimeiro";
            this.rdbPrimeiro.Size = new System.Drawing.Size(78, 20);
            this.rdbPrimeiro.TabIndex = 13;
            this.rdbPrimeiro.TabStop = true;
            this.rdbPrimeiro.Text = "Primeiro";
            this.rdbPrimeiro.UseVisualStyleBackColor = true;
            this.rdbPrimeiro.MouseLeave += new System.EventHandler(this.rdbPrimeiro_MouseLeave);
            this.rdbPrimeiro.MouseHover += new System.EventHandler(this.rdbPrimeiro_MouseHover);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnRegistrar.Location = new System.Drawing.Point(854, 577);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 41);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            this.btnRegistrar.MouseHover += new System.EventHandler(this.btnRegistrar_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(898, 622);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 16);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sou Moderador";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkLabel1.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::ATEX2023_2.Properties.Resources.inicial;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPrimeiro);
            this.groupBox1.Controls.Add(this.rdbSegundo);
            this.groupBox1.Controls.Add(this.rdbTerceiro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(846, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 122);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb9);
            this.groupBox2.Controls.Add(this.rdb8);
            this.groupBox2.Controls.Add(this.rdb7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(846, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 112);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IDADE";
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Location = new System.Drawing.Point(11, 80);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(118, 20);
            this.rdb9.TabIndex = 24;
            this.rdb9.Text = "9 anos ou mais";
            this.rdb9.UseVisualStyleBackColor = true;
            this.rdb9.MouseLeave += new System.EventHandler(this.rdb9_MouseLeave);
            this.rdb9.MouseHover += new System.EventHandler(this.rdb9_MouseHover);
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Location = new System.Drawing.Point(11, 54);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(68, 20);
            this.rdb8.TabIndex = 23;
            this.rdb8.Text = "8 anos";
            this.rdb8.UseVisualStyleBackColor = true;
            this.rdb8.MouseLeave += new System.EventHandler(this.rdb8_MouseLeave);
            this.rdb8.MouseHover += new System.EventHandler(this.rdb8_MouseHover);
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Checked = true;
            this.rdb7.Location = new System.Drawing.Point(11, 28);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(68, 20);
            this.rdb7.TabIndex = 22;
            this.rdb7.TabStop = true;
            this.rdb7.Text = "7 anos";
            this.rdb7.UseVisualStyleBackColor = true;
            this.rdb7.MouseLeave += new System.EventHandler(this.rdb7_MouseLeave);
            this.rdb7.MouseHover += new System.EventHandler(this.rdb7_MouseHover);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreencha);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblPreencha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.RadioButton rdbTerceiro;
        private System.Windows.Forms.RadioButton rdbSegundo;
        private System.Windows.Forms.RadioButton rdbPrimeiro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb9;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb7;
    }
}

