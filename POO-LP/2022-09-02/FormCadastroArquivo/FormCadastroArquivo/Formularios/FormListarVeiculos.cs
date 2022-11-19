using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCadastroArquivo.Contexto;

namespace FormCadastroArquivo.Formularios
{
    public partial class FormListarVeiculos : Form
    {
        public FormListarVeiculos()
        {
            InitializeComponent();

            Dados banco = new Dados();
            bsVeiculo.DataSource = banco.ListaDeVeiculos;
            
            dgvVeiculo.DataSource = bsVeiculo;
            
            cbModelo.DataSource = bsVeiculo;
            cbModelo.DisplayMember = "Modelo";
        }

        private void btCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastrarCarros form = new FormCadastrarCarros();
            form.ShowDialog();
        }

        private void btConsultarPorPlaca_Click(object sender, EventArgs e)
        {
            FormConsultarPorPlacaVeiculos form = new FormConsultarPorPlacaVeiculos();
            form.ShowDialog();
        }
    }
}
