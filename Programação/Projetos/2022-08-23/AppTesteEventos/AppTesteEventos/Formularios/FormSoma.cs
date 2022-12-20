using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;
using AppTesteEventos.RegraDeNegocio;

namespace AppTesteEventos.Formularios
{
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SomaDeValores obj = new SomaDeValores();
            obj.Valor1 = Convert.ToDouble(edValor1.Text); 
            obj.Valor2 = Convert.ToDouble(edValor2.Text);
            obj.Calcular(); 
            edTotal.Text = obj.Total.ToString();
        }

        private void edValor1_TextChanged(object sender, EventArgs e)
        {
            if (!edValor1.Text.All(char.IsDigit))
            {
                Mensagem.Alerta("Digite apenas números", "2A INF");
                edValor1.Clear();
                edValor1.Select();
            }
        }

        private void edValor2_KeyUp(object sender, KeyEventArgs e)
        {
            if(!edValor2.Text.All(char.IsDigit))
            {
                Mensagem.Alerta("Digite apenas números", "2A INF");
                edValor2.Clear();
                edValor2.Select();
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10 * 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            timer2.Interval = 5 * 1000;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            btIniciar.BackColor = Color.Red;
        }

        private void FormSoma_Load(object sender, EventArgs e)
        {

        }
    }
}
