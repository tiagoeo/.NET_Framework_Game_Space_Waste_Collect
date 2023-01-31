using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Space_Waste_Collect
{
    public partial class frmGame : Form
    {
        
        String nomeGame = "Space Waste Collect";
        int velJogador = 2;
        int velItemColeta = 4;
        int pontuacao = 0;
        int mover = 0;
        Random rnd = new Random();

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
                    lblJogadorNome.Text = "LIVRE";
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

                    gbsModo.Visible = true;
                    gbsModo.Location = new Point(150, 80);
                    lblInfo.Text = "";
                    break;

                case "menu_2":

                    break;

                case "menu_3":

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
                    pontuacao -= 1;
                }
                else
                {
                    pontuacao += 1;
                }
                
                posItemColeta("itemColeta0");
            }
            else if (naveJogador.Bounds.IntersectsWith(itemColeta1.Bounds))
            {
                //salvarItemColetado();
                posItemColeta("itemColeta1");
                if (itemColeta1.AccessibleName == "item3")
                {
                    pontuacao -= 1;
                }
                else
                {
                    pontuacao += 1;
                }
            }
            else if (naveJogador.Bounds.IntersectsWith(itemColeta2.Bounds))
            {
                //salvarItemColetado();
                posItemColeta("itemColeta2");
                if (itemColeta2.AccessibleName == "item3")
                {
                    pontuacao -= 1;
                }
                else
                {
                    pontuacao += 1;
                }
            }
            dificuldade();
            lblJogadorPontos.Text = "PONTOS : " + pontuacao.ToString();
        }

        private void dificuldade()
        {
            int dif = 0;
            if (pontuacao <= 100)
            {
                velItemColeta *= 1;
                dif = 0;
            }

            else if (pontuacao > 100 && pontuacao <= 1000)
            {
                velItemColeta *= 2;
                dif = 1;
            }
            else if (pontuacao > 1000 && pontuacao <= 5000)
            {
                velItemColeta *= 3;
                dif = 2;
            }
            else if (pontuacao > 5000 && pontuacao <= 10000)
            {
                velItemColeta *= 4;
                dif = 3;
            }
            else if (pontuacao > 10000)
            {
                velItemColeta *= 5;
                dif = 4;
            }
            lblJogadorDificuldade.Text = "DIFICULDADE: " + dif.ToString();
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
    }
}
