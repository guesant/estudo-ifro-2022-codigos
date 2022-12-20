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
    public partial class FormEstacionamento : Form
    {

        public double TempoSegundos { get; set; }

        public double ValorTotal {
            get {
                return Math.Floor(TempoSegundos / 3) * 10;
            }
        }


        public FormEstacionamento()
        {
            InitializeComponent();
        }

        private void SincronizarInterface()
        {
            edTempo.Text = $"{TempoSegundos}s";
            edValorTotal.Text = ValorTotal.ToString("C2");
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            TempoSegundos = 0;
            clock.Start();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            TempoSegundos++;
            SincronizarInterface();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }
    }
}
