using AppRegistroVeiculo.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormListarClientes : Form
    {
        public FormListarClientes()
        {
            InitializeComponent();

            BuscarDados();

            dgvClientes.DataSource = bsClientes;
        }

        private void BuscarDados()
        {
            bsClientes.DataSource = Dados.BuscarClientes();
        }
    }
}
