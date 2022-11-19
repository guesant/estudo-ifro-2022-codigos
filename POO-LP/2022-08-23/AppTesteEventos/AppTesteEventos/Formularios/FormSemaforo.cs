using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesteEventos.Formularios
{
    public partial class FormSemaforo : Form
    {
        const int TEMPO_VERDE = 3;
        const int TEMPO_AMARELO = 2;
        const int TEMPO_VERMELHO = 5;
        
        const int TEMPO_1 = TEMPO_VERDE;
        const int TEMPO_2 = TEMPO_VERDE + TEMPO_AMARELO;
        const int TEMPO_3 = TEMPO_VERDE + TEMPO_AMARELO + TEMPO_VERMELHO;

        public int Segundos { get; set; }

        public FormSemaforo()
        {
            InitializeComponent();
            //btVerde.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Segundos++;

            if (Segundos >= TEMPO_3)
            {
                Segundos = 0;
            }

            btVerde.BackColor = Color.Gray;
            btAmarelo.BackColor = Color.Gray;
            btVermelho.BackColor = Color.Gray;

            if (Segundos < TEMPO_1)
            {
                btVerde.BackColor = Color.Green;
            }
            else if (Segundos < TEMPO_2)
            {
                btAmarelo.BackColor = Color.Yellow;
            }
            else if (Segundos < TEMPO_3)
            {
                btVermelho.BackColor = Color.Red;
            }

            lblSegundos.Text = $"Segundos: {Segundos}";
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
