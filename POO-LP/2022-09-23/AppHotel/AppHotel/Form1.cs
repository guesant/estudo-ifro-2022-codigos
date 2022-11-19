using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHotel.Formularios;

namespace AppHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarQuartos_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarQuarto();
            form.ShowDialog();
        }

        private void btConsultarQuartos_Click(object sender, EventArgs e)
        {
            var form = new FormListarQuartos();
            form.ShowDialog();
        }

        private void btCadastrarClientes_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarCliente();
            form.ShowDialog();
        }

        private void btConsultarClientes_Click(object sender, EventArgs e)
        {
            var form = new FormListarClientes();
            form.ShowDialog();
        }

        private void btRegistrarHospedagem_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarHospedagem();
            form.ShowDialog();
        }

        private void btConsultarHospedagens_Click(object sender, EventArgs e)
        {
            var form = new FormConsultarHospedagens();
            form.ShowDialog();
        }
    }
}
