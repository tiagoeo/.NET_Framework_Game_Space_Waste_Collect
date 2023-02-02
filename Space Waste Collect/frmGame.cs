using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Entidades;
using Controller;

namespace Space_Waste_Collect
{
    public partial class frmGame : Form
    {

        string nomeGame = "Space Waste Collect", nomeJogador, senhaJogador, emailJogador, statusJogador, extrasJogador;
        int velJogador = 10, velItemColeta = 4, pontosJogador = 0, bonus = 1, mover = 0, uidJogador;
        bool gameRanqueado = false;
        Random rnd = new Random();
        ConexaoVO novoAsync = new ConexaoVO();


        public frmGame()
        {
            InitializeComponent();
            menu("menu_1");
        }

        public void game(string comando)
        {
            switch (comando)
            {
                case "modo_livre":
                    this.Text = nomeGame;
                    gameRanqueado = false;
                    lblJogadorNome.Text = "JOGADOR: LIVRE";
                    lblJogadorPontos.Text = "PONTOS : " + pontosJogador.ToString();
                    lblJogadorNome.Visible = true;
                    lblJogadorPontos.Visible = true;
                    lblJogadorDificuldade.Visible = true;

                    naveJogador.Visible = true;
                    naveJogador.Left = 250;

                    itemColeta0.Visible = true;
                    itemColeta1.Visible = true;
                    itemColeta2.Visible = true;

                    itemColeta0.Left = 50;
                    posItemColeta("itemColeta0");

                    itemColeta1.Left = 250;
                    posItemColeta("itemColeta1");

                    itemColeta2.Left = 450;
                    posItemColeta("itemColeta2");

                    dificuldade();

                    timerItemColeta.Enabled = true;

                    menu("menu_sair");

                    lblInfo.Text = "Botão \"A\" move a nave para a esquerda; Botão \"B\" move a nave para direita; \"ESC\" sai do jogo.";

                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                    break;
                case "modo_ranqueado":
                    gameRanqueado = true;
                    lblJogadorNome.Text = "JOGADOR: " + nomeJogador;
                    lblJogadorPontos.Text = "PONTOS : " + pontosJogador.ToString();
                    lblJogadorNome.Visible = true;
                    lblJogadorPontos.Visible = true;
                    lblJogadorDificuldade.Visible = true;

                    naveJogador.Visible = true;
                    naveJogador.Left = 250;

                    itemColeta0.Visible = true;
                    itemColeta1.Visible = true;
                    itemColeta2.Visible = true;

                    itemColeta0.Left = 50;
                    posItemColeta("itemColeta0");

                    itemColeta1.Left = 250;
                    posItemColeta("itemColeta1");

                    itemColeta2.Left = 450;
                    posItemColeta("itemColeta2");

                    dificuldade();

                    timerItemColeta.Enabled = true;

                    menu("menu_sair");

                    lblInfo.Text = "Botão \"A\" move a nave para a esquerda; Botão \"B\" move a nave para direita; \"ESC\" sai do jogo.";

                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                    break;
                case "sair":
                    this.Text = nomeGame;
                    nomeJogador = "";
                    emailJogador = "";
                    statusJogador = "";
                    extrasJogador = "";
                    pontosJogador = 0;
                    bonus = 0;
                    uidJogador = 0;

                    lblJogadorNome.Visible = false;
                    lblJogadorPontos.Visible = false;
                    lblJogadorDificuldade.Visible = false;

                    timerItemColeta.Enabled = false;

                    naveJogador.Visible = false;

                    itemColeta0.Visible = false;
                    itemColeta1.Visible = false;
                    itemColeta2.Visible = false;

                    menu("menu_1");
                    break;
            }
        }

        private void menu(string modo)
        {
            switch (modo)
            {
                case "menu_1":
                    gbMenu.Visible = true;
                    gbMenu.Location = new Point(0,0);

                    gbsLogin.Visible = false;
                    gbsVinculo.Visible = false;

                    gbsModo.Visible = true;
                    gbsModo.Location = new Point(150, 80);
                    lblInfo.Text = "";
                    break;

                case "menu_2":
                    gbMenu.Visible = true;
                    gbMenu.Location = new Point(0, 0);

                    gbsModo.Visible = false;
                    gbsVinculo.Visible = false;

                    gbsLogin.Visible = true;
                    gbsLogin.Location = new Point(150, 80);
                    lblInfo.Text = "";

                    txtNome.Enabled = true;
                    txtSenha.Enabled = true;
                    btnLogin.Enabled = true;
                    btnSair1.Enabled = true;
                    break;

                case "menu_3":
                    gbMenu.Visible = true;
                    gbMenu.Location = new Point(0, 0);

                    gbsModo.Visible = false;
                    gbsLogin.Visible = false;

                    gbsVinculo.Visible = true;
                    gbsVinculo.Location = new Point(150, 80);
                    lblInfo.Text = "Login realizado, contudo falta vinculo com o game, clique no botão 'Vincular Game' para corrigir.";

                    btnVinculo.Enabled = true;
                    btnSair2.Enabled = true;
                    break;

                case "menu_sair":
                    gbMenu.Visible = false;
                    break;

            }
        }

        private void posItemColeta(String itemColeta)
        {
            int ranT;
            int ranL;
            int ranItem;

            Image[] itens = new Image[4];
            itens[0] = Properties.Resources.ufoBlue;
            itens[1] = Properties.Resources.ufoGreen;
            itens[2] = Properties.Resources.ufoRed;
            itens[3] = Properties.Resources.meteorBrown_big2;

            switch (itemColeta)
            {
                case "itemColeta0":
                    ranT = rnd.Next(-200, -20);
                    ranL = rnd.Next(2, 50);
                    ranItem = rnd.Next(0, 4);

                    itemColeta0.Top = ranT;
                    itemColeta0.Left = ranL;

                    itemColeta0.BackgroundImage = itens[ranItem];

                    itemColeta0.AccessibleName = "item" + ranItem.ToString();
                    break;

                case "itemColeta1":
                    ranT = rnd.Next(-200, -20);
                    ranL = rnd.Next(150, 250);
                    ranItem = rnd.Next(0, 4);

                    itemColeta1.Top = ranT;
                    itemColeta1.Left = ranL;


                    itemColeta1.BackgroundImage = itens[ranItem];

                    itemColeta1.AccessibleName = "item" + ranItem.ToString();
                    break;

                case "itemColeta2":
                    ranT = rnd.Next(-200, -20);
                    ranL = rnd.Next(350, 450);
                    ranItem = rnd.Next(0, 4);

                    itemColeta2.Top = ranT;
                    itemColeta2.Left = ranL;

                    itemColeta2.BackgroundImage = itens[ranItem];

                    itemColeta2.AccessibleName = "item" + ranItem.ToString();
                    break;

                default:
                    break;
            }
        }

        private void colisao()
        {
            if (naveJogador.Bounds.IntersectsWith(itemColeta0.Bounds))
            {
                //salvarItemColetado();
                if (itemColeta0.AccessibleName == "item3")
                {
                    pontuacao(-1);
                }
                else
                {
                    pontuacao(1);
                }
                
                posItemColeta("itemColeta0");
            }
            else if (naveJogador.Bounds.IntersectsWith(itemColeta1.Bounds))
            {
                //salvarItemColetado();
                posItemColeta("itemColeta1");
                if (itemColeta1.AccessibleName == "item3")
                {
                    pontuacao(-1);
                }
                else
                {
                    pontuacao(1);
                }
            }
            else if (naveJogador.Bounds.IntersectsWith(itemColeta2.Bounds))
            {
                //salvarItemColetado();
                posItemColeta("itemColeta2");
                if (itemColeta2.AccessibleName == "item3")
                {
                    pontuacao(-1);
                }
                else
                {
                    pontuacao(1);
                }
            }
 
        }

        private void pontuacao(int valor)
        {
            if (valor > 0)
            {
                pontosJogador += valor * bonus;
            }
            else if(pontosJogador >0)
            {
                pontosJogador += valor;
            }

            if (gameRanqueado)
            {

            }

            dificuldade();
            lblJogadorPontos.Text = "PONTOS : " + pontosJogador.ToString();
        }

        private void dificuldade()
        {
            int dif = 0;
            if (pontosJogador <= 10)
            {
                velItemColeta = 4;
                dif = 0;
            }

            else if (pontosJogador > 10 && pontosJogador <= 30)
            {
                velItemColeta = 6;
                dif = 1;
            }
            else if (pontosJogador > 30 && pontosJogador <= 50)
            {
                velItemColeta = 8;
                dif = 2;
            }
            else if (pontosJogador > 50 && pontosJogador <= 75)
            {
                velItemColeta = 10;
                dif = 3;
            }
            else if (pontosJogador > 75)
            {
                velItemColeta = 12;
                dif = 4;
            }
            lblJogadorDificuldade.Text = "DIFICULDADE: " + dif.ToString();
        }


        private async void login(){
            nomeJogador = txtNome.Text;
            senhaJogador = txtSenha.Text;

            if (nomeJogador.Count() <= 3)
            {
                lblInfo.Text = "Campo 'nome' não pode ser inferior a 3 (três) caracteres";
                return;
            }

            if (senhaJogador.Count() <= 4)
            {
                lblInfo.Text = "Campo 'senha' não pode ser inferior a 4 (quatro) caracteres";
                return;
            }

            var data = new Dictionary<string, string>
            {
                {"usuarioAppLogin", nomeJogador},
                {"senhaAppLogin", senhaJogador}
            };

            lblInfo.Text = "Acessando servidor...";
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnLogin.Enabled = false;
            btnSair1.Enabled = false;

            var valueJSON = await novoAsync.Login(data);

            if (valueJSON != null)
            {
                if (valueJSON.loginapp == "true")
                {
                    if (valueJSON.Pontuacoes == "true")
                    {
                        this.Text = valueJSON.GameNome;

                        nomeJogador = valueJSON.nome;
                        emailJogador = valueJSON.email;
                        statusJogador = valueJSON.status;
                        extrasJogador = valueJSON.GameExtras;
                        pontosJogador = Int32.Parse(valueJSON.GamePontos);
                        bonus = Int32.Parse(valueJSON.GameBonus);
                        uidJogador = Int32.Parse(valueJSON.uid);

                        lblInfo.Text = "Login realizado com sucesso - seja bem vindo : " + nomeJogador;

                        game("modo_ranqueado");
                    }
                    else
                    {
                        nomeJogador = valueJSON.nome;
                        emailJogador = valueJSON.email;
                        statusJogador = valueJSON.status;
                        uidJogador = Int32.Parse(valueJSON.uid);

                        menu("menu_3");
                    }
                }
                else
                {
                    lblInfo.Text = "LOGIN: Usuário ou senha incorretos";
                }
            }
            else
            {
                if (valueJSON == null)
                {
                    lblInfo.Text = "Erro no servidor.";
                }
                else if (valueJSON.Excecoes != null)
                {
                    lblInfo.Text = "Erro no servidor: " + valueJSON.Excecoes;
                }
            }
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            btnLogin.Enabled = true;
            btnSair1.Enabled = true;
        }

        private async void vinculo(){
            var data = new Dictionary<string, string>
            {
                {"uidusuariovincular", uidJogador.ToString()},
                {"buscausuariovincular", emailJogador}
            };

            lblInfo.Text = "Acessando servidor...";
            btnVinculo.Enabled = false;
            btnSair2.Enabled = false;

            var valueJSON = await novoAsync.Vinculo(data);

            if (valueJSON != null)
            {
                if (valueJSON.Vinculo == "true")
                {
                    lblInfo.Text = "Game vinculado á conta com sucesso!";
                    var data2 = new Dictionary<string, string>
                    {
                        {"buscaPontos", emailJogador}
                    };
                    var valueJSON2 = await novoAsync.BuscaPontos(data2);

                    if (valueJSON2 != null)
                    {
                        if (valueJSON2.Excecoes == null && valueJSON2.Pontuacoes == "true")
                        {

                            this.Text = valueJSON2.GameNome;

                            nomeJogador = valueJSON2.nome;
                            emailJogador = valueJSON2.email;
                            statusJogador = valueJSON2.status;
                            extrasJogador = valueJSON2.GameExtras;
                            pontosJogador = Int32.Parse(valueJSON2.GamePontos);
                            bonus = Int32.Parse(valueJSON2.GameBonus);
                            uidJogador = Int32.Parse(valueJSON2.uid);

                            game("modo_ranqueado");
                        }
                        else
                        {
                            lblInfo.Text = valueJSON2.Excecoes;
                        }

                    }
                    else
                    {
                        game("sair");
                    }
                }
                else if (valueJSON.Vinculo == "existe")
                {
                    lblInfo.Text = "O Game já está vinculado a conta.";
                }
                else if (valueJSON.Vinculo == "null")
                {
                    lblInfo.Text = "Game não registrado";
                }
                else
                {
                    lblInfo.Text = "Não foi possível realizar o vinculo com o game.";
                }
            }
            else
            {
                if (valueJSON == null)
                {
                    lblInfo.Text = "Erro no servidor.";
                }
                else if (valueJSON.Excecoes != null)
                {
                    lblInfo.Text = "Erro no servidor: " + valueJSON.Excecoes;
                }
                
            }
            btnVinculo.Enabled = true;
            btnSair2.Enabled = true;
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                if (naveJogador.Location.X <= 5)
                {
                    mover = 0;
                }
                else
                {
                    mover = -velJogador;
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (naveJogador.Location.X >= 450)
                {
                    mover = 0;
                }
                else
                {
                    mover = velJogador;
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                game("sair");
            }
        }

        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                mover = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                mover = 0;
            }
        }

        private void timerItemColeta_Tick(object sender, EventArgs e)
        {
            naveJogador.Left += mover;

            if (itemColeta0.Top >= 360 && (naveJogador.Left > 0 && naveJogador.Left < 104)){
                itemColeta0.Top += velItemColeta;
                colisao();
            }
            else { 
                itemColeta0.Top += velItemColeta;
                if (itemColeta0.Top >= 600)
                {
                    posItemColeta("itemColeta0");
                }
            }

            if (itemColeta1.Top >= 360 && (naveJogador.Left > 104 && naveJogador.Left < 264))
            {
                itemColeta1.Top += velItemColeta;
                colisao();
            }
            else
            {
                itemColeta1.Top += velItemColeta;
                if (itemColeta1.Top >= 600)
                {
                    posItemColeta("itemColeta1");
                }
            }

            if (itemColeta2.Top >= 360 && (naveJogador.Left > 264 && naveJogador.Left < 450))
            {
                itemColeta2.Top += velItemColeta;
                colisao();
            }
            else
            {
                itemColeta2.Top += velItemColeta;
                if (itemColeta2.Top >= 600)
                {
                    posItemColeta("itemColeta2");
                }
            }
        }

        private void btnModoLivre_Click_1(object sender, EventArgs e)
        {
            game("modo_livre");
        }

        private void btnModoRanqueado_Click(object sender, EventArgs e)
        {
            menu("menu_2");
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            menu("menu_1");
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            menu("menu_1");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnVinculo_Click(object sender, EventArgs e)
        {
            vinculo();
        }
    }
}
