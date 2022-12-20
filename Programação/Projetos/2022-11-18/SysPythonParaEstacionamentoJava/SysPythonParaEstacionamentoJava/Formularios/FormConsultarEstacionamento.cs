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
    public partial class FormConsultarEstacionamento : Form
    {
        private int estacionamentoId;

        private Estacionamento estacionamento;

        public FormConsultarEstacionamento(int estacionamentoId)
        {
            InitializeComponent();

            this.estacionamentoId = estacionamentoId;

            BuscarDados();

            cbVaga.DataSource = bsVagas;
            cbVaga.DisplayMember = "Numero";

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";

            ResetarOperacao();
        }

        private DateTime DataEntrada
        {
            get
            {
                return dtpDataDeEntradaDia.Value.Date + dtpDataDeEntradaTempo.Value.TimeOfDay;
            }
            set
            {
                dtpDataDeEntradaDia.Value = value;
                dtpDataDeEntradaTempo.Value = value;
            }
        }
        
        private DateTime? DataSaida
        {
            get
            {
                DateTime? ds = null;

                if (cbDataDeSaida.Checked)
                {
                    ds = dtpDataDeSaidaDia.Value.Date + dtpDataDeSaidaTempo.Value.TimeOfDay;
                }

                return ds;
            }

            set
            {
                cbDataDeSaida.Checked = value != null;

                DateTime newValue = value != null ? (DateTime)value : DateTime.Now;

                if(newValue < DataEntrada)
                {
                    newValue = DateTime.Now;
                }

                dtpDataDeSaidaDia.Value = newValue;
                dtpDataDeSaidaTempo.Value = newValue;
            }
        }

        private double ValorMinuto
        {
            get
            {
                double result;

                bool valido = double.TryParse(edValorMinuto.Text, out result);

                if (!valido)
                {
                    result = -1;
                }

                return result;
            }
        }

        private int TotalMinutos
        {
            get
            {
                DateTime saida = estacionamento.DataSaida != null ? (DateTime)estacionamento.DataSaida : DateTime.Now;

                var timeSpan = saida - estacionamento.DataEntrada;
                return Convert.ToInt32(timeSpan.TotalMinutes);
            }
        }

        private double ValorTotal
        {
            get
            {
                return TotalMinutos * estacionamento.ValorMinuto;
            }
        }

        private void BuscarDados()
        {
            estacionamento = Dados.BuscarEstacionamento(estacionamentoId);

            bsVagas.DataSource = Dados.BuscarVagas();
            bsVeiculos.DataSource = Dados.BuscarVeiculos();
        }

        private void AlterarEstadoComponentes(bool liberado)
        {
            cbVeiculo.Enabled = false;
            cbVaga.Enabled = false;

            dtpDataDeEntradaDia.Enabled = liberado;
            dtpDataDeEntradaTempo.Enabled = liberado;

            cbDataDeSaida.Enabled = liberado;
            dtpDataDeSaidaDia.Enabled = liberado ? cbDataDeSaida.Checked : false;
            dtpDataDeSaidaTempo.Enabled = liberado ? cbDataDeSaida.Checked : false;

            edValorMinuto.Enabled = liberado;
        }

        private void FecharComponentes()
        {
            AlterarEstadoComponentes(false);
        }

        private void LiberarComponentes()
        {
            AlterarEstadoComponentes(true);
        }

        private void RestaurarComponentes()
        {
            cbVaga.SelectedItem = Dados.BuscarVaga(estacionamento.VagaId);
            cbVeiculo.SelectedItem = Dados.BuscarVeiculo(estacionamento.VeiculoId);

            DataEntrada = estacionamento.DataEntrada;
            DataSaida = estacionamento.DataSaida;

            edValorMinuto.Text = estacionamento.ValorMinuto.ToString();

            edTotalMinutos.Text = TotalMinutos.ToString();
            edValorTotal.Text = ValorTotal.ToString("C2");
        }
        private void BloquearBotaoEditar()
        {
            btDeletar.Enabled = true;
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }
        private void BloquearBotaoCancelarSalvar()
        {
            btDeletar.Enabled = false;
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void ResetarOperacao()
        {
            BuscarDados();
            RestaurarComponentes();
            FecharComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private bool ValidarOperacao()
        {
            bool valorMinutoValido = ValorMinuto >= 0;

            bool valido = valorMinutoValido;

            if (!valido)
            {
                Mensagem.Erro("Preencha corretamente todos os dados!", "SysPython");
                return false;
            }

            return true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            cbVeiculo.Focus();
            BloquearBotaoEditar();
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
            
            estacionamento.DataEntrada = DataEntrada;
            estacionamento.DataSaida = DataSaida;
            estacionamento.ValorMinuto = ValorMinuto;
            Dados.SalvarEstacionamento(estacionamento);

            var vaga = Dados.BuscarVaga(estacionamento.VagaId);

            if(estacionamento.DataSaida != null && vaga.VeiculoId == estacionamento.VeiculoId)
            {
                vaga.VeiculoId = null;
            }

            if (estacionamento.DataSaida == null && vaga.VeiculoId == null)
            {
                vaga.VeiculoId = estacionamento.VeiculoId;
            }

            Dados.SalvarVaga(vaga);

            Mensagem.Informacao("Registro salvado com sucesso!", "SysPython");

            ResetarOperacao();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja realmente deletar este registro?", "SysPython");

            if (resp == "sim")
            {
                var vaga = Dados.BuscarVaga(estacionamento.VagaId);
              
                if (estacionamento.DataSaida == null && vaga.VeiculoId == estacionamento.VeiculoId)
                {
                    vaga.VeiculoId = null;
                    Dados.SalvarVaga(vaga);
                }

                Dados.ApagarEstacionamento(estacionamento.Id);

                this.Close();
                
                BloquearBotaoCancelarSalvar();
            }
        }

        private void cbDataDeSaida_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataDeSaidaDia.Enabled = cbDataDeSaida.Checked;
            dtpDataDeSaidaTempo.Enabled = cbDataDeSaida.Checked;
        }
    }
}
