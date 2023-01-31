namespace Space_Waste_Collect
{
    partial class frmGame
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
            this.naveJogador = new System.Windows.Forms.PictureBox();
            this.itemColeta0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblJogadorPontos = new System.Windows.Forms.Label();
            this.lblJogadorDificuldade = new System.Windows.Forms.Label();
            this.btnJogoSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // naveJogador
            // 
            this.naveJogador.BackColor = System.Drawing.Color.Transparent;
            this.naveJogador.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.playerShip3_blue;
            this.naveJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.naveJogador.Location = new System.Drawing.Point(250, 462);
            this.naveJogador.Name = "naveJogador";
            this.naveJogador.Size = new System.Drawing.Size(100, 77);
            this.naveJogador.TabIndex = 0;
            this.naveJogador.TabStop = false;
            // 
            // itemColeta0
            // 
            this.itemColeta0.BackColor = System.Drawing.Color.Transparent;
            this.itemColeta0.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.meteorBrown_big2;
            this.itemColeta0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemColeta0.Location = new System.Drawing.Point(50, 23);
            this.itemColeta0.Name = "itemColeta0";
            this.itemColeta0.Size = new System.Drawing.Size(90, 90);
            this.itemColeta0.TabIndex = 1;
            this.itemColeta0.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.ufoBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.meteorBrown_med1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(450, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblJogadorNome
            // 
            this.lblJogadorNome.AutoSize = true;
            this.lblJogadorNome.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorNome.ForeColor = System.Drawing.Color.White;
            this.lblJogadorNome.Location = new System.Drawing.Point(593, 23);
            this.lblJogadorNome.Name = "lblJogadorNome";
            this.lblJogadorNome.Size = new System.Drawing.Size(60, 20);
            this.lblJogadorNome.TabIndex = 4;
            this.lblJogadorNome.Text = "NOME";
            // 
            // lblJogadorPontos
            // 
            this.lblJogadorPontos.AutoSize = true;
            this.lblJogadorPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorPontos.ForeColor = System.Drawing.Color.White;
            this.lblJogadorPontos.Location = new System.Drawing.Point(593, 58);
            this.lblJogadorPontos.Name = "lblJogadorPontos";
            this.lblJogadorPontos.Size = new System.Drawing.Size(100, 20);
            this.lblJogadorPontos.TabIndex = 5;
            this.lblJogadorPontos.Text = "PONTOS: 0";
            // 
            // lblJogadorDificuldade
            // 
            this.lblJogadorDificuldade.AutoSize = true;
            this.lblJogadorDificuldade.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadorDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorDificuldade.ForeColor = System.Drawing.Color.White;
            this.lblJogadorDificuldade.Location = new System.Drawing.Point(593, 93);
            this.lblJogadorDificuldade.Name = "lblJogadorDificuldade";
            this.lblJogadorDificuldade.Size = new System.Drawing.Size(150, 20);
            this.lblJogadorDificuldade.TabIndex = 6;
            this.lblJogadorDificuldade.Text = "DIFICULDADE: 0";
            // 
            // btnJogoSair
            // 
            this.btnJogoSair.BackColor = System.Drawing.Color.Red;
            this.btnJogoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogoSair.ForeColor = System.Drawing.Color.White;
            this.btnJogoSair.Location = new System.Drawing.Point(619, 490);
            this.btnJogoSair.Name = "btnJogoSair";
            this.btnJogoSair.Size = new System.Drawing.Size(108, 35);
            this.btnJogoSair.TabIndex = 7;
            this.btnJogoSair.Text = "SAIR";
            this.btnJogoSair.UseVisualStyleBackColor = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnJogoSair);
            this.Controls.Add(this.lblJogadorDificuldade);
            this.Controls.Add(this.lblJogadorPontos);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.itemColeta0);
            this.Controls.Add(this.naveJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGame";
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox naveJogador;
        private System.Windows.Forms.PictureBox itemColeta0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblJogadorPontos;
        private System.Windows.Forms.Label lblJogadorDificuldade;
        private System.Windows.Forms.Button btnJogoSair;
    }
}

