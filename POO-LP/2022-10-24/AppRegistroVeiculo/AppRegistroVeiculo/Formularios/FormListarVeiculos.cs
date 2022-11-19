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
    public partial class FormListarVeiculos : Form
    {
        public FormListarVeiculos()
        {
            InitializeComponent();

            BuscarDados();
            
            dgvVeiculos.DataSource = bsVeiculos;
        }

        private void BuscarDados()
        {
            bsVeiculos.DataSource = Dados.BuscarVeiculos();
        }
    }
}
