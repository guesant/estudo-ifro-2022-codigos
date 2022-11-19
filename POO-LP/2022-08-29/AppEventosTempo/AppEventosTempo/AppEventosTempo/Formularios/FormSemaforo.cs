using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEventosTempo.Formularios
{
    public partial class FormSemaforo : Form
    {
        public FormSemaforo()
        {
            InitializeComponent();

            btVerde.BackColor = Color.Green;
            btAmarelo.BackColor = Color.White;
            btVermelho.BackColor = Color.White;

            tempoLuzVerde.Interval = 5000;
            tempoLuzVerde.Start();
        }

        private void tempoLuzVerde_Tick(object sender, EventArgs e)
        {
            btVerde.BackColor = Color.White;
            btAmarelo.BackColor = Color.Yellow;
            btVermelho.BackColor = Color.White;

            tempoLuzVerde.Stop();
            
            tempoLuzAmarela.Interval = 5000;
            tempoLuzAmarela.Start();
        }

        private void tempoLuzAmarela_Tick(object sender, EventArgs e)
        {
            btVerde.BackColor = Color.White;
            btAmarelo.BackColor = Color.White;
            btVermelho.BackColor = Color.Red;

            tempoLuzAmarela.Stop();

            tempoLuzVermelha.Interval = 5000;
            tempoLuzVermelha.Start();
        }

        private void tempoLuzVermelha_Tick(object sender, EventArgs e)
        {
            btVerde.BackColor = Color.Green;
            btAmarelo.BackColor = Color.White;
            btVermelho.BackColor = Color.White;

            tempoLuzVermelha.Stop();

            tempoLuzVerde.Interval = 5000;
            tempoLuzVerde.Start();
        }
    }
}
