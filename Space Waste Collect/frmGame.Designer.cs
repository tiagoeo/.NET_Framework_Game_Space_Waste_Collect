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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbsModo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModoLivre = new System.Windows.Forms.Button();
            this.btnModoRanqueado = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta2)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.gbsModo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.gbsModo);
            this.gbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(783, 543);
            this.gbMenu.TabIndex = 7;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // gbsModo
            // 
            this.gbsModo.Controls.Add(this.btnModoRanqueado);
            this.gbsModo.Controls.Add(this.btnModoLivre);
            this.gbsModo.Controls.Add(this.pictureBox1);
            this.gbsModo.Location = new System.Drawing.Point(127, 73);
            this.gbsModo.Name = "gbsModo";
            this.gbsModo.Size = new System.Drawing.Size(500, 400);
            this.gbsModo.TabIndex = 5;
            this.gbsModo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.playerShip3_blue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(138, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 199);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnModoLivre
            // 
            this.btnModoLivre.BackColor = System.Drawing.Color.Transparent;
            this.btnModoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModoLivre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModoLivre.Location = new System.Drawing.Point(65, 335);
            this.btnModoLivre.Margin = new System.Windows.Forms.Padding(5);
            this.btnModoLivre.Name = "btnModoLivre";
            this.btnModoLivre.Size = new System.Drawing.Size(150, 50);
            this.btnModoLivre.TabIndex = 7;
            this.btnModoLivre.Text = "Modo Livre";
            this.btnModoLivre.UseVisualStyleBackColor = false;
            this.btnModoLivre.Click += new System.EventHandler(this.btnModoLivre_Click_1);
            // 
            // btnModoRanqueado
            // 
            this.btnModoRanqueado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModoRanqueado.Location = new System.Drawing.Point(282, 335);
            this.btnModoRanqueado.Name = "btnModoRanqueado";
            this.btnModoRanqueado.Size = new System.Drawing.Size(150, 50);
            this.btnModoRanqueado.TabIndex = 8;
            this.btnModoRanqueado.Text = "Modo Ranqueado";
            this.btnModoRanqueado.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfo.Location = new System.Drawing.Point(148, 546);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(468, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Botão \"A\" move a nave para a esquerda; Botão \"B\" move a nave para direita; \"ESC\" " +
    "sai do jogo.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbMenu);
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
            this.gbMenu.ResumeLayout(false);
            this.gbsModo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.GroupBox gbsModo;
        private System.Windows.Forms.Button btnModoRanqueado;
        private System.Windows.Forms.Button btnModoLivre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
    }
}

