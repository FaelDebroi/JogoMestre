using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre
{
    public partial class Form1 : Form
    {

        int[] cores;
        int atual = 0;
        int ultima = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void picAzul_Click(object sender, EventArgs e)
        {
            

            
        }

        private void picAzul_MouseDown(object sender, MouseEventArgs e)
        {
            picAzul.Image = Properties.Resources.azul_aceso;
        }

        private void picAzul_MouseUp(object sender, MouseEventArgs e)
        {
            picAzul.Image = Properties.Resources.azul;
            novaResposta(2);
        }

        private void picAmarelo_MouseDown(object sender, MouseEventArgs e)
        {
            picAmarelo.Image = Properties.Resources.amarelo_aceso;
        }

        private void picAmarelo_MouseUp(object sender, MouseEventArgs e)
        {
            picAmarelo.Image = Properties.Resources.amarelo;
            novaResposta(1);
        }

        private void picVerde_MouseDown(object sender, MouseEventArgs e)
        {
            picVerde.Image = Properties.Resources.verde_aceso;
        }

        private void picVerde_MouseUp(object sender, MouseEventArgs e)
        {
            picVerde.Image = Properties.Resources.verde;
            novaResposta(3);
        }

        private void picVermelho_MouseDown(object sender, MouseEventArgs e)
        {
            picVermelho.Image = Properties.Resources.vermelho_aceso;
        }

        private void picVermelho_MouseUp(object sender, MouseEventArgs e)
        {
            picVermelho.Image = Properties.Resources.vermelho;
            novaResposta(4);
        }

        private void finalizarJogo()
        {
            habilitarBotoes(false);
            btnInicio.Enabled = true;
            ultima = 0;
        }

        private void habilitarBotoes(bool estado)
        {
            picAmarelo.Enabled = estado;
            picAzul.Enabled = estado;
            picVerde.Enabled = estado;
            picVermelho.Enabled = estado;
        }

        private void novaResposta(int corClicada)
        {
            //se ele errou, terminar o jogo
            if(corClicada != cores[atual])
            {
                MessageBox.Show("Você PERDEU! Tente novamente do inicio!");
                //terminar o jogo
                finalizarJogo();
            }
            else //acertei a cor
            {
                if(atual < ultima) //acertei parcialmente
                {
                    atual++;
                }
                else //acertei tudo
                {
                    ultima++;
                    if (ultima >= cores.Length)//acertei até a ultima cor do tamanho do array
                    {
                        MessageBox.Show("VOCÊ GANHOU!! UHUUUL!");
                        finalizarJogo();
                    }
                    else
                    {
                        habilitarBotoes(false);
                        piscarNova();
                    }
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnInicio.Enabled = false;

            if (rdFacil.Checked)
                cores = new int[4];
            else
                cores = new int[8];

            iniciarJogo();
        }

        private void iniciarJogo()
        {
            //sortear as cores
            Random rand = new Random();

            //colocar a primeira cor
            cores[0] = rand.Next(1, 5);
            //gerando as outras cores da sequencia!
            for (int pos = 1; pos < cores.Length; pos++)
            {
                int temp = rand.Next(1, 5); //{1- amar. | 2 - azul | 3 - verde | 4 - verm.} 
                //se for igual, não uso!
                //Se for diferente da anterior, eu uso
                if(temp != cores[pos-1])
                {
                    cores[pos] = temp;
                }
                else
                {
                    pos--;
                }
            }
            //piscar as cores
            piscarNova();
        }

        private void piscarNova()
        {
            atual = 0;
            tmrPassarCores.Enabled = true;
        }

        private void tmrPassarCores_Tick(object sender, EventArgs e)
        {
            //apaga a cor
            picAmarelo.Image = Properties.Resources.amarelo;
            picAzul.Image = Properties.Resources.azul;
            picVerde.Image = Properties.Resources.verde;
            picVermelho.Image = Properties.Resources.vermelho;

            //acende a próxima cor
            if (atual <= ultima)
            {
                switch (cores[atual])
                {
                    case 1:
                        picAmarelo.Image = Properties.Resources.amarelo_aceso;
                        break;
                    case 2:
                        picAzul.Image = Properties.Resources.azul_aceso;
                        break;
                    case 3:
                        picVerde.Image = Properties.Resources.verde_aceso;
                        break;
                    case 4:
                        picVermelho.Image = Properties.Resources.vermelho_aceso;
                        break;
                }
                atual++;
            }
            else //vez do usuário repetir
            {
                atual = 0;
                tmrPassarCores.Enabled = false;
                habilitarBotoes(true);
            }
        }

        private void picVerde_Click(object sender, EventArgs e)
        {

        }
    }
}
