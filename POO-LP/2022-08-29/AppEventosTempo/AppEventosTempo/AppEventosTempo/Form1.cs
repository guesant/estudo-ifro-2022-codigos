using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEventosTempo.Formularios; 

namespace AppEventosTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSemaforo_Click(object sender, EventArgs e)
        {
            FormSemaforo form = new FormSemaforo();
            form.ShowDialog();
        }

        private void btEstacionamento_Click(object sender, EventArgs e)
        {
            FormEstacionamento form = new FormEstacionamento();
            form.ShowDialog();
        }
    }
}
