using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  System.Windows.Forms.MessageBox.Show("mensagem do Botão");
            //string texto = "Mensagem do botão";

            minhaBlioteca.minhaClasse minhaClasse = new minhaBlioteca.minhaClasse();

            MessageBox.Show(minhaClasse.texto);
        }
    }
}

namespace minhaBlioteca
{
    public class minhaClasse
    {
        public string texto = "mensagem do botão 2";
    }
}

