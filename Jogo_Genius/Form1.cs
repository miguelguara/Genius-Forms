using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        int aux = 0;

        //Cores em padrão hexadecimal para HTML
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
            //Inicializa e define as cores dos botões
            InitializeComponent();
            btVerde.BackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAmarelo.BackColor = ColorTranslator.FromHtml(corAmareloPadrao);
            btVermelho.BackColor = ColorTranslator.FromHtml(corVermelhoPadrao);
            btAzul.BackColor = ColorTranslator.FromHtml(corAzulPadrao);

            btVerde.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePadrao);
            btAmarelo.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml (corAmareloPadrao);
            btAzul.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPadrao);
            btVermelho.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPadrao);

            btVerde.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btAmarelo.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAmareloPiscando);
            btAzul.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAzulPiscando);
            btVermelho.FlatAppearance. MouseDownBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);


            btVerde.Cursor = Cursors.Hand;
            btAmarelo.Cursor = Cursors.Hand;
            btVermelho.Cursor = Cursors.Hand;
            btAzul.Cursor = Cursors.Hand;
           
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada = -1;
            Sequencia = new List<Button>();
            btIniciar.Enabled = false;
            nivel++;
            lbNivel.Text = nivel.ToString();
            GerarSequencia();
            piscar();
            AtivaDesativaBotao(true);
        }

        private void GerarSequencia()
        {
            int num = new Random().Next(0, 3);
            Button bt = null;

            switch (num) 
            {
                case 0:
                    bt = btAmarelo;
                    break;
                case 1:
                    bt = btVermelho;
                    break;
                case 2:
                    bt = btAzul;
                    break;
                case 3:
                    bt = btVerde;
                    break;
            }
            Sequencia.Add(bt);
        }

        private void piscar() 
        {
            aux = 0;

            for(int i = 0; i < Sequencia.Count; i++) 
            {
                sequenciaAtual = i;

                corPadrao = Sequencia[i].BackColor;

                //Atribui a cor piscando para a variável

                if (Sequencia[i] == btAzul) 
                {
                    corPiscando = ColorTranslator.FromHtml(corAzulPiscando);
                }
                else if(Sequencia[i] == btAmarelo) 
                {
                    corPiscando = ColorTranslator.FromHtml(corAmareloPiscando);
                }
                else if (Sequencia[i] == btVerde)
                {
                    corPiscando = ColorTranslator.FromHtml(corVerdePiscando);
                }
                else if (Sequencia[i] == btVermelho)
                {
                    corPiscando = ColorTranslator.FromHtml(corVermelhoPiscando);
                }

                //Inicia o timer aonde em cada tick ele pisca uma parte da sequencia
                timer1.Start();

                while(aux == i) 
                {
                    Application.DoEvents();
                }
            }
        }

        private void AtivaDesativaBotao(bool ativo) 
        {
            btVerde.Enabled = ativo;
            btAmarelo.Enabled = ativo;
            btVermelho.Enabled = ativo;
            btAzul.Enabled = ativo; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!piscando)
            {
                Sequencia[sequenciaAtual].BackColor = corPiscando;
                piscando = true;
            }
            else 
            {
                Sequencia[sequenciaAtual].BackColor = corPadrao;
                piscando = false;
                aux++;
                timer1.Stop();
            }
        }

        private void bt_Click(object sender, EventArgs e) 
        {
            sequenciaSelecionada ++;

            if (Sequencia[sequenciaSelecionada] == (Button)sender) 
            {
                if (Sequencia.Count - 1 == sequenciaSelecionada)
                {
                    nivel++;
                    lbNivel.Text = nivel.ToString();
                    sequenciaSelecionada = -1;
                    AtivaDesativaBotao(false);
                    GerarSequencia();
                    Thread.Sleep(500);
                    piscar();
                    AtivaDesativaBotao(true);
                }
            }
            else 
            {
                btIniciar.Enabled = true;
                AtivaDesativaBotao(false);
                lbNivel.Text = "";
                nivel = 0;
            }
        }
    }
}
