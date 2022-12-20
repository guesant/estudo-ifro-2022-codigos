using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroVeiculo.Formularios;

namespace AppRegistroVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            var form = new FormCadastroVeiculo();
            form.ShowDialog();
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            var form = new FormCadastroCliente();
            form.ShowDialog();
        }

        private void btRealizarVenda_Click(object sender, EventArgs e)
        {
            var form = new FormRealizarVendas();
            form.ShowDialog();
        }

        private void btConsultarVeiculos_Click(object sender, EventArgs e)
        {
            var form = new FormConsultarVeiculo();
            form.ShowDialog();
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            var form = new FormConsultarCliente();
            form.ShowDialog();
        }

        private void btConsultarVendas_Click(object sender, EventArgs e)
        {
            var form = new FormConsultarVendas();
            form.ShowDialog();
        }

        private void btListarVeiculos_Click(object sender, EventArgs e)
        {
            var form = new FormListarVeiculos();
            form.ShowDialog();
        }

        private void btListarClientes_Click(object sender, EventArgs e)
        {
            var form = new FormListarClientes();
            form.ShowDialog();
        }

        private void btListarVendas_Click(object sender, EventArgs e)
        {
            var form = new FormListarVendas();
            form.ShowDialog();
        }
    }
}
