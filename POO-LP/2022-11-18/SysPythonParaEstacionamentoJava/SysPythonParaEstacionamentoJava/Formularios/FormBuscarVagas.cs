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
    public partial class FormBuscarVagas : Form
    {
        public FormBuscarVagas()
        {
            InitializeComponent();

            BuscarDados();

            dgvVagas.DataSource = bsVagas;
            cbSituacao.DataSource = bsSituacoes;
            cbSituacao.SelectedIndex = -1;
        }

        private string SituacaoSelecionada
        {
            get
            {
                return cbSituacao.SelectedItem as string;
            }
        }

        private void BuscarDados()
        {
            bsSituacoes.DataSource = Situacao.SITUACOES;
            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            bsVagas.DataSource = Dados.BuscarVagas().Where(vaga =>
            {
                if(SituacaoSelecionada != null)
                {
                    return SituacaoSelecionada == Situacao.LIVRE ? vaga.VeiculoId == null : vaga.VeiculoId != null;
                }

                return true;
            }).ToList();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            cbSituacao.SelectedIndex = -1;
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }
    }
}
