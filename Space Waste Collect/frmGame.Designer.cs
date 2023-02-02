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
            this.gbsVinculo = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnVinculo = new System.Windows.Forms.Button();
            this.gbsLogin = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblLoginNome = new System.Windows.Forms.Label();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbsModo = new System.Windows.Forms.GroupBox();
            this.btnModoRanqueado = new System.Windows.Forms.Button();
            this.btnModoLivre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.naveJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemColeta2)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.gbsVinculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbsLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbsModo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.gbMenu.Controls.Add(this.gbsVinculo);
            this.gbMenu.Controls.Add(this.gbsLogin);
            this.gbMenu.Controls.Add(this.gbsModo);
            this.gbMenu.Controls.Add(this.panel1);
            this.gbMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbMenu.Location = new System.Drawing.Point(10, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(783, 543);
            this.gbMenu.TabIndex = 7;
            this.gbMenu.TabStop = false;
            // 
            // gbsVinculo
            // 
            this.gbsVinculo.Controls.Add(this.pictureBox4);
            this.gbsVinculo.Controls.Add(this.pictureBox3);
            this.gbsVinculo.Controls.Add(this.btnSair2);
            this.gbsVinculo.Controls.Add(this.btnVinculo);
            this.gbsVinculo.Location = new System.Drawing.Point(561, 19);
            this.gbsVinculo.Name = "gbsVinculo";
            this.gbsVinculo.Size = new System.Drawing.Size(500, 400);
            this.gbsVinculo.TabIndex = 7;
            this.gbsVinculo.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.playerShip3_orange;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(252, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(151, 105);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.ufoRed;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(69, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 147);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnSair2
            // 
            this.btnSair2.ForeColor = System.Drawing.Color.Black;
            this.btnSair2.Location = new System.Drawing.Point(280, 334);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(150, 50);
            this.btnSair2.TabIndex = 1;
            this.btnSair2.Text = "Sair";
            this.btnSair2.UseVisualStyleBackColor = true;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // btnVinculo
            // 
            this.btnVinculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVinculo.Location = new System.Drawing.Point(69, 334);
            this.btnVinculo.Name = "btnVinculo";
            this.btnVinculo.Size = new System.Drawing.Size(150, 50);
            this.btnVinculo.TabIndex = 0;
            this.btnVinculo.Text = "Vincular Game";
            this.btnVinculo.UseVisualStyleBackColor = true;
            this.btnVinculo.Click += new System.EventHandler(this.btnVinculo_Click);
            // 
            // gbsLogin
            // 
            this.gbsLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbsLogin.Controls.Add(this.txtSenha);
            this.gbsLogin.Controls.Add(this.txtNome);
            this.gbsLogin.Controls.Add(this.lblLoginSenha);
            this.gbsLogin.Controls.Add(this.lblLoginNome);
            this.gbsLogin.Controls.Add(this.btnSair1);
            this.gbsLogin.Controls.Add(this.btnLogin);
            this.gbsLogin.Controls.Add(this.pictureBox2);
            this.gbsLogin.Location = new System.Drawing.Point(152, 46);
            this.gbsLogin.Name = "gbsLogin";
            this.gbsLogin.Size = new System.Drawing.Size(500, 400);
            this.gbsLogin.TabIndex = 6;
            this.gbsLogin.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(164, 221);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(165, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginSenha.ForeColor = System.Drawing.Color.White;
            this.lblLoginSenha.Location = new System.Drawing.Point(164, 205);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(38, 13);
            this.lblLoginSenha.TabIndex = 3;
            this.lblLoginSenha.Text = "Senha";
            // 
            // lblLoginNome
            // 
            this.lblLoginNome.AutoSize = true;
            this.lblLoginNome.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginNome.ForeColor = System.Drawing.Color.White;
            this.lblLoginNome.Location = new System.Drawing.Point(164, 136);
            this.lblLoginNome.Name = "lblLoginNome";
            this.lblLoginNome.Size = new System.Drawing.Size(35, 13);
            this.lblLoginNome.TabIndex = 2;
            this.lblLoginNome.Text = "Nome";
            // 
            // btnSair1
            // 
            this.btnSair1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair1.Location = new System.Drawing.Point(282, 335);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(150, 50);
            this.btnSair1.TabIndex = 1;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(69, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.meteorBrown_big2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(117, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 249);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // gbsModo
            // 
            this.gbsModo.Controls.Add(this.btnModoRanqueado);
            this.gbsModo.Controls.Add(this.btnModoLivre);
            this.gbsModo.Controls.Add(this.pictureBox1);
            this.gbsModo.Location = new System.Drawing.Point(150, 80);
            this.gbsModo.Name = "gbsModo";
            this.gbsModo.Size = new System.Drawing.Size(500, 400);
            this.gbsModo.TabIndex = 5;
            this.gbsModo.TabStop = false;
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
            this.btnModoRanqueado.Click += new System.EventHandler(this.btnModoRanqueado_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(98, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 400);
            this.panel1.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInfo.Location = new System.Drawing.Point(150, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(468, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Botão \"A\" move a nave para a esquerda; Botão \"B\" move a nave para direita; \"ESC\" " +
    "sai do jogo.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Location = new System.Drawing.Point(-4, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 9;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Space_Waste_Collect.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
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
            this.gbsVinculo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbsLogin.ResumeLayout(false);
            this.gbsLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbsModo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbsLogin;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginNome;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbsVinculo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnVinculo;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

