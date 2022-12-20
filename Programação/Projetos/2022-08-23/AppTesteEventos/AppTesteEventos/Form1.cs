using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTesteEventos.Formularios; 

namespace AppTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSomaDeValores_Click(object sender, EventArgs e)
        {
            FormSoma obj = new FormSoma();
            obj.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSemaforo form = new FormSemaforo();
            form.ShowDialog();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
