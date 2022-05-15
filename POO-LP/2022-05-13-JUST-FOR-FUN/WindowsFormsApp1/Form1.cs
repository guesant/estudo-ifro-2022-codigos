using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tabo /");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult resultado;

            do
            {
                resultado = MessageBox.Show("OPÇÃO INVÁLIDA!!!1", "BURRO", MessageBoxButtons.RetryCancel);
            } while (resultado == DialogResult.Retry);



        }
    }
}
