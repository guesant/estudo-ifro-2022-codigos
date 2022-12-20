using MeusComponentes.Interacoes;
using SysPythonParaEstacionamentoJava.Contexto;
using SysPythonParaEstacionamentoJava.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPythonParaEstacionamentoJava.Formularios
{
    public partial class FormBuscarEstacionamentos : Form
    {
        private Veiculo Veiculo
        {
            get
            {
                return cbVeiculo.SelectedItem as Veiculo;
            }
        }

        private Vaga Vaga
        {
            get
            {
                return cbVaga.SelectedItem as Vaga;
            }
        }

        public FormBuscarEstacionamentos()
        {
            InitializeComponent();

            dgvEstacionamentos.DataSource = bsEstacionamentos;

            BuscarDados();

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";
            
            cbVaga.DataSource = bsVagas;
            cbVaga.DisplayMember = "Numero";
            
            ResetarOperacao();
        }

        private void BuscarDados()
        {
            bsVagas.DataSource = Dados.BuscarVagas();
            bsVeiculos.DataSource = Dados.BuscarVeiculos();
            bsSituacao.DataSource = Situacao.SITUACOES;
        }

        private void AtualizarResultados()
        {

            var resultados = Dados.BuscarEstacionamentos().Where((estacionamento) =>
            {
                bool valido = true;

                if (Veiculo != null)
                {
                    valido = valido && estacionamento.VeiculoId == Veiculo.Id;
                }

                if (Vaga != null)
                {
                    valido = valido && estacionamento.VagaId == Vaga.Id;
                }

                return valido;
            });

            bsEstacionamentos.DataSource = resultados.Count() > 0 ? resultados : null;
        }

        private void ResetarOperacao()
        {
            cbVaga.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ResetarOperacao();
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }

        private void cbVaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }

        private void BuscarDadosMantendoEstado()
        {
            var vaga = cbVaga.SelectedItem;
            var veiculo = cbVeiculo.SelectedItem;
            
            BuscarDados();

            cbVaga.SelectedItem = vaga;
            cbVeiculo.SelectedItem = veiculo;

            AtualizarResultados();
        }

        private void dgvEstacionamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) { 
                var row = dgvEstacionamentos.Rows[e.RowIndex];
                var estacionamentoId = Convert.ToInt32(row.Cells[0].Value);

                var form = new FormConsultarEstacionamento(estacionamentoId);
                form.ShowDialog();

                BuscarDadosMantendoEstado();
            }
        }
    }
}
