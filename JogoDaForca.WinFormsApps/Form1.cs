namespace JogoDaForca.WinFormsApps
{
    public partial class Form1 : Form
    {
        Forca forca = new Forca();
        public Form1()
        {
            InitializeComponent();
            InicioJogo();
            btnInserir.Click += InseirLetra;
            btnA.Click += AtribuirLetra;
            btnB.Click += AtribuirLetra;
            btnC.Click += AtribuirLetra;
            btnD.Click += AtribuirLetra;
            btnE.Click += AtribuirLetra;
            btnF.Click += AtribuirLetra;
            btnG.Click += AtribuirLetra;
            btnH.Click += AtribuirLetra;
            btnI.Click += AtribuirLetra;
            btnJ.Click += AtribuirLetra;
            btnK.Click += AtribuirLetra;
            btnL.Click += AtribuirLetra;
            btnM.Click += AtribuirLetra;
            btnN.Click += AtribuirLetra;
            btnO.Click += AtribuirLetra;
            btnP.Click += AtribuirLetra;
            btnQ.Click += AtribuirLetra;
            btnR.Click += AtribuirLetra;
            btnS.Click += AtribuirLetra;
            btnT.Click += AtribuirLetra;
            btnU.Click += AtribuirLetra;
            btnV.Click += AtribuirLetra;
            btnW.Click += AtribuirLetra;
            btnX.Click += AtribuirLetra;
            btnY.Click += AtribuirLetra;
            btnZ.Click += AtribuirLetra;



        }

        private void InicioJogo()
        {
            lblPalavra.Text = forca.PalavraParcial;
            lblQtnsLetras.Text = forca.QuantidadeLetras.ToString() + " Letras";
        }
        private void AtribuirLetra(object? sender, EventArgs e)
        {

            Button botao = (Button)sender;
            textChute.Text = botao.Text;
        }

        private void InseirLetra(object? sender, EventArgs e)
        {

            Button botao = new Button();
            char palpite = textChute.Text[0];
            lblPalavra.Text = palpite.ToString();
            if (forca.JogadorAcertou(palpite) || forca.JogadorPerdeu())
            {
                tableLayoutPanel1.Enabled = false;
                toolStripStatusLabel1.Text = forca.mensagemFinal;
            }
            AtualizarPalavaraParcial();
            LimparJogo();
            AtualizarForca();
        }

        private void AtualizarForca()
        {
            switch (forca.Erros)
            {
                case 1: pictureBox1.Image = Properties.Resources._2; break;
                case 2: pictureBox1.Image = Properties.Resources._3; break;
                case 3: pictureBox1.Image = Properties.Resources._4; break;
                case 4: pictureBox1.Image = Properties.Resources._5; break;
                case 5: pictureBox1.Image = Properties.Resources._6; break;
                case 6: pictureBox1.Image = Properties.Resources._7; break;
                case 7: pictureBox1.Image = Properties.Resources._8; break;

            }
        }

        private void LimparJogo()
        {
            textChute.Text = "";

        }

        private void AtualizarPalavaraParcial()
        {
            lblPalavra.Text = forca.PalavraParcial;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

    }
}