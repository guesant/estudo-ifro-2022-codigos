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
    public partial class FormRegistrarSaida : Form
{
        public FormRegistrarSaida()
{
            InitializeComponent();
            BuscarDados();

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";

            ResetarOperacao();
        }

        private Veiculo Veiculo => cbVeiculo.SelectedItem as Veiculo;
        
        private DateTime DataSaida => dtpDataDeSaidaDia.Value.Date + dtpDataDeSaidaTempo.Value.TimeOfDay;

        private Estacionamento Estacionamento
        {
            get
            {
                Estacionamento estacionamento = null;
                
                if(Veiculo != null)
                {
                    estacionamento = Dados.BuscarEstacionamentos().Find(est => est.VeiculoId == Veiculo.Id && est.DataSaida == null);
                }
                
                return estacionamento;
            }
        }

        private void AlterarEstadoComponentes(bool liberado)
        {
            cbVeiculo.Enabled = liberado;
            dtpDataDeSaidaDia.Enabled = liberado;
            dtpDataDeSaidaTempo.Enabled = liberado;
        }

        private void BuscarDados()
        {
            var estacionamentosPendentes = Dados.BuscarEstacionamentos().Where(est => est.DataSaida == null).ToList();
            var veiculosEstacionados = Dados.BuscarVeiculos().Where(vei => estacionamentosPendentes.Find(est => est.VeiculoId == vei.Id) != null).ToList();
            bsVeiculos.DataSource = veiculosEstacionados;
        }

        private void FecharComponentes()
        {
            AlterarEstadoComponentes(false);
        }

        private void LiberarComponentes()
{
            AlterarEstadoComponentes(true);
        }

        private void LimparComponentes()
        {
            cbVeiculo.SelectedIndex = -1;

            dtpDataDeSaidaDia.Value = DateTime.Now;
            dtpDataDeSaidaTempo.Value = DateTime.Now;
        }
        private void BloquearBotaoAdd()
        {
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }
        private void BloquearBotaoCancelarSalvar()
        {
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void ResetarOperacao()
        {
            BuscarDados();
            LimparComponentes();
            FecharComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private bool ValidarOperacao()
        {
            var veiculoValido = Veiculo != null;
            
            if (!veiculoValido)
            {
                Mensagem.Erro("Preencha corretamente todos os dados!", "SysPython");
                return false;
            }

            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            cbVeiculo.Focus();
            BloquearBotaoAdd();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja realmente cancelar esta operação?", "SysPython");

            if (resp == "sim")
            {
                ResetarOperacao();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarOperacao())
            {
                return;
            }

            var registro = Estacionamento;
            registro.DataSaida = DataSaida;
            Dados.SalvarEstacionamento(registro);

            var vaga = Dados.BuscarVaga(registro.VagaId);
            vaga.VeiculoId = null;
            Dados.SalvarVaga(vaga);

            Mensagem.Informacao("Registro salvado com sucesso!", "SysPython");

            ResetarOperacao();
        }
    }
}
