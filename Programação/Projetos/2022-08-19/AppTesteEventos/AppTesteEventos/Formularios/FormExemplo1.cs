using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponenteMensagens.INTERACAO;
using AppTesteEventos.RegrasDeNegocio;

namespace AppTesteEventos.Formularios
{
    public partial class FormExemplo1 : Form
    {
        public FormExemplo1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            bool impedimento = false;
            
            if(edValor1.Text == "")
            {
                impedimento = true;
            }

            if(edValor2.Text == "")
            {
                impedimento = true;
            }

            if(!impedimento)
            {
                SomaDeValores obj = new SomaDeValores();

                obj.Valor1 = Convert.ToDouble(edValor1.Text);
                obj.Valor2 = Convert.ToDouble(edValor2.Text);

                obj.Calcular();

                edValorTotal.Text = obj.Total.ToString();
            } else
            {
                Mensagem.Alerta("Você não informou todos os valores!", "2A INF");

                edValor1.Clear();
                edValor2.Clear();
                edValorTotal.Clear();

                edValor1.Focus();
            }
        }

        private void edValor1_KeyUp(object sender, KeyEventArgs e)
        {
            if(!edValor1.Text.All(char.IsDigit))
            {
                Mensagem.Alerta("Digite apenas números.", "2A INF");
                edValor1.Clear();
                edValor1.Select();
            }
        }

        private void edValor2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!edValor2.Text.All(char.IsDigit))
            {
                Mensagem.Alerta("Digite apenas números.", "2A INF");
                edValor2.Clear();
                edValor2.Select();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTempo_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();
        }
    }
}
