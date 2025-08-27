using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace jogo_da_forca
{
    public partial class MainForm : Form
    {
        // Variáveis globais do jogo
        
        public static string[] palavras = {"abobora","banana"};  // tudo minúsculo para facilitar
        private static Random random = new Random();
        private int tentativas = 0;
        private static string palavra = palavras[random.Next(palavras.Length)];
        private List<string> letrasErradas = new List<string>();
        private List<string> letrasDescobertas = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            ReiniciarJogo();
        }

        // Reinicia o jogo
        private void ReiniciarJogo()
        {
            palavra = "abobora"; // pode futuramente sortear palavras
            tentativas = 0;
            letrasErradas.Clear();
            letrasDescobertas.Clear();
            pictureBox1.BackgroundImage = Image.FromFile("..\\..\\..\\beginning.png");
            AtualizarInterface();
        }

        // --- Esse era o seu antigo método de verificar letra via TextBox ---
        void Button27Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(entrada) || entrada.Length != 1)
            {
                MessageBox.Show("Digite apenas uma letra.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            string letra = entrada;

            if (letrasDescobertas.Contains(letra))
            {
                MessageBox.Show("Você já tentou essa letra.", "Letra repetida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                return;
            }

            bool acertou = false;

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i].ToString() == letra)
                {
                    letrasDescobertas.Add(letra);
                    acertou = true;
                }
            }

            if (!acertou)
            {
                pictureBox1.BackgroundImage = Image.FromFile("..\\..\\..\\phase" + (tentativas + 1) + ".PNG");
                letrasErradas.Add(letra);
                letrasDescobertas.Add(letra);
                tentativas++;
            }

            AtualizarInterface();
            textBox1.Clear();
        }

        void AtualizarInterface()
        {
            // Exibe letras descobertas na palavra
            string exibicao = "";
            foreach (char c in palavra)
            {
                exibicao += letrasDescobertas.Contains(c.ToString()) ? c + " " : "_ ";
            }

            label1.Text = exibicao.Trim();

            // Verifica vitória ou derrota
            if (!label1.Text.Contains("_"))
            {
                MessageBox.Show("Parabéns! Você ganhou!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReiniciarJogo();
            }
            else if (tentativas >= 6)
            {
                MessageBox.Show("Você perdeu! A palavra era: "+palavra, ", Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReiniciarJogo();
            }
        }

        // --- Agora cada botão de letra chama o mesmo código que estava no Button1Click ---
        void Button1Click(object sender, System.EventArgs e){ textBox1.Text = "a"; Button27Click(sender, e); }
        void Button2Click(object sender, System.EventArgs e){ textBox1.Text = "b"; Button27Click(sender, e); }
    
	
		void Button7Click(object sender, EventArgs e)
		{
			textBox1.Text = "g"; Button27Click(sender, e); 
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			textBox1.Text = "h"; Button27Click(sender, e); 
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			textBox1.Text = "i"; Button27Click(sender, e); 
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			textBox1.Text = "j"; Button27Click(sender, e); 
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			textBox1.Text = "k"; Button27Click(sender, e); 
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			textBox1.Text = "l"; Button27Click(sender, e); 
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			textBox1.Text = "m"; Button27Click(sender, e); 
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			textBox1.Text = "n"; Button27Click(sender, e); 
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			textBox1.Text = "o"; Button27Click(sender, e); 
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			textBox1.Text = "p"; Button27Click(sender, e); 
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			textBox1.Text = "q"; Button27Click(sender, e); 
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			textBox1.Text = "r"; Button27Click(sender, e); 
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			textBox1.Text = "s"; Button27Click(sender, e); 
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			textBox1.Text = "t"; Button27Click(sender, e); 
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			textBox1.Text = "u"; Button27Click(sender, e); 
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			textBox1.Text = "v"; Button27Click(sender, e); 
		}
		
		void Button23Click(object sender, EventArgs e)
		{
			textBox1.Text = "w"; Button27Click(sender, e); 
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			textBox1.Text = "x"; Button27Click(sender, e); 
		}
		
		void Button25Click(object sender, EventArgs e)
		{
			textBox1.Text = "y"; Button27Click(sender, e); 
		}
		
		void Button26Click(object sender, EventArgs e)
		{
			textBox1.Text = "z"; Button27Click(sender, e); 
		}
		
		void Button28Click(object sender, EventArgs e)
		{
			ReiniciarJogo();
		}
    }
}
