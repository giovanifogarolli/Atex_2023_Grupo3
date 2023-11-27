namespace ATEX2023_2
{
    partial class FrmRelatorio
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPreencha = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnRegistrar.Location = new System.Drawing.Point(845, 570);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(227, 43);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "CRIAR RELATÓRIO";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(845, 178);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 22);
            this.txtNome.TabIndex = 26;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(842, 155);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(159, 15);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "NOME DO JOGO OU REDE";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "______________________________________";
            // 
            // lblPreencha
            // 
            this.lblPreencha.AutoSize = true;
            this.lblPreencha.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblPreencha.Location = new System.Drawing.Point(818, 80);
            this.lblPreencha.Name = "lblPreencha";
            this.lblPreencha.Size = new System.Drawing.Size(270, 16);
            this.lblPreencha.TabIndex = 23;
            this.lblPreencha.Text = "PREENCHA PARA CRIAR UM RELATÓRIO";
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblCadastro.Location = new System.Drawing.Point(870, 44);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(176, 33);
            this.lblCadastro.TabIndex = 22;
            this.lblCadastro.Text = "CADASTRO";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::ATEX2023_2.Properties.Resources.inicial;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(845, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreencha);
            this.Controls.Add(this.lblCadastro);
            this.Name = "FrmRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPreencha;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Button button1;
    }
}
