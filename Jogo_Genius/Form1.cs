using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Genius
{
    public partial class Form1 : Form
    {
        int sequenciaSelecionada = 1;
        int sequenciaAtual = 0;
        List<Button> Sequencia;
        Color corPadrao;
        Color corPiscando;
        bool piscando = false;
        int nivel = 0;

        string corVerdePadrao = "#004700";
        string corAmareloPadrao = "#F0B200";
        string corVermelhoPadrao = "#A80A00";
        string corAzulPadrao = "#06006B";

        string corVerdePiscando = "#008A00";
        string corAmareloPiscando = "#FFD047";
        string corVermelhoPiscando = "#F50E00";
        string corAzulPiscando = "#0C00D6";


        public Form1()
        {
            InitializeComponent();
            btVerde.BackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAmarelo.BackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVermelho.BackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAzul.BackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btVerde.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btAmarelo.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml (corAmareloPiscando);
            btAzul.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPiscando);
            btVermelho.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);
           
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {

        }

    }
}
