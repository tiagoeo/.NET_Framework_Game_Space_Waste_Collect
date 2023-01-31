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
            this.components = new System.ComponentModel.Container();
            this.naveJogador = new System.Windows.Forms.PictureBox();
            this.itemColeta0 = new System.Windows.Forms.PictureBox();
            this.itemColeta1 = new System.Windows.Forms.PictureBox();
            this.itemColeta2 = new System.Windows.Forms.PictureBox();
            this.lblJogadorNome = new System.Windows.Forms.Label();
            this.lblJogadorPontos = new System.Windows.Forms.Label();
            this.lblJogadorDificuldade = new System.Windows.Forms.Label();
            this.timerItemColeta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta2)).BeginInit();
            this.SuspendLayout();
            // 
            // naveJogador
            // 
            this.naveJogador.BackColor = System.Drawing.Color.Transparent;
            this.naveJogador.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.playerShip3_blue;
            this.naveJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.naveJogador.Location = new System.Drawing.Point(250, 460);
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
            // itemColeta1
            // 
            this.itemColeta1.BackColor = System.Drawing.Color.Transparent;
            this.itemColeta1.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.ufoBlue;
            this.itemColeta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemColeta1.Location = new System.Drawing.Point(250, 23);
            this.itemColeta1.Name = "itemColeta1";
            this.itemColeta1.Size = new System.Drawing.Size(90, 90);
            this.itemColeta1.TabIndex = 2;
            this.itemColeta1.TabStop = false;
            // 
            // itemColeta2
            // 
            this.itemColeta2.BackColor = System.Drawing.Color.Transparent;
            this.itemColeta2.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.meteorBrown_med1;
            this.itemColeta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemColeta2.Location = new System.Drawing.Point(450, 23);
            this.itemColeta2.Name = "itemColeta2";
            this.itemColeta2.Size = new System.Drawing.Size(90, 90);
            this.itemColeta2.TabIndex = 3;
            this.itemColeta2.TabStop = false;
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
            // timerItemColeta
            // 
            this.timerItemColeta.Interval = 1;
            this.timerItemColeta.Tick += new System.EventHandler(this.timerItemColeta_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblJogadorDificuldade);
            this.Controls.Add(this.lblJogadorPontos);
            this.Controls.Add(this.lblJogadorNome);
            this.Controls.Add(this.itemColeta2);
            this.Controls.Add(this.itemColeta1);
            this.Controls.Add(this.itemColeta0);
            this.Controls.Add(this.naveJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox naveJogador;
        private System.Windows.Forms.PictureBox itemColeta0;
        private System.Windows.Forms.PictureBox itemColeta1;
        private System.Windows.Forms.PictureBox itemColeta2;
        private System.Windows.Forms.Label lblJogadorNome;
        private System.Windows.Forms.Label lblJogadorPontos;
        private System.Windows.Forms.Timer timerItemColeta;
        private System.Windows.Forms.Label lblJogadorDificuldade;
    }
}

