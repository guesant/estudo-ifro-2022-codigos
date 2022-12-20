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
    public partial class FormConsultarVeiculo : Form
    {
        public FormConsultarVeiculo()
        {
            InitializeComponent();
            
            BuscarDados();
            
            cbVeiculo.DataSource = bsVeiculo;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;

            dtTabela.DataSource = bsResultados;
        }

        private Veiculo VeiculoSelecionado => cbVeiculo.SelectedItem as Veiculo;

        private void BuscarDados()
        {
            bsVeiculo.DataSource = Dados.BuscarVeiculos();
            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            bsResultados.DataSource = Dados.BuscarVeiculos().Where(veiculo =>
            {
                bool valido = true;

                if (VeiculoSelecionado != null)
                {
                    valido = valido && VeiculoSelecionado.Id == veiculo.Id;
                }

                return valido;
            }).ToList();
        }

        private void btNovaConsulta_Click(object sender, EventArgs e)
        {
            cbVeiculo.SelectedIndex = -1;
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }
    }
}
