using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;
using SysPythonParaEstacionamentoJava.Contexto;
using SysPythonParaEstacionamentoJava.RegrasDeNegocio;

namespace SysPythonParaEstacionamentoJava.Formularios
{
    public partial class FormRegistrarEstacionamento : Form
    {
        public FormRegistrarEstacionamento()
        {
            InitializeComponent();

            BuscarDados();

            cbVaga.DataSource = bsVagas;
            cbVaga.DisplayMember = "Numero";

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";

            ResetarOperacao();
        }

        private Vaga Vaga => cbVaga.SelectedItem as Vaga;
        private Veiculo Veiculo => cbVeiculo.SelectedItem as Veiculo;

        private DateTime DataEntrada
        {
            get
            {
                return dtpDataDeEntradaDia.Value.Date + dtpDataDeEntradaTempo.Value.TimeOfDay;
            }
        }

        private DateTime? DataSaida {
            get {
                DateTime? ds = null;

                if (cbDataDeSaida.Checked)
                {
                    ds = dtpDataDeSaidaDia.Value.Date + dtpDataDeSaidaTempo.Value.TimeOfDay;
                }

                return ds;
            }
        }

        private double ValorMinuto
        {
            get
            {
                double result;
                
                bool valido = double.TryParse(edValorMinuto.Text, out result);
                
                if(!valido)
                {
                    result = -1;
                }

                return result;
            }
        }

        private void AlterarEstadoComponentes(bool liberado)
        {
            cbVeiculo.Enabled = liberado;
            cbVaga.Enabled = liberado;

            dtpDataDeEntradaDia.Enabled = liberado;
            dtpDataDeEntradaTempo.Enabled = liberado;

            cbDataDeSaida.Enabled = liberado;
            dtpDataDeSaidaDia.Enabled = liberado ? cbDataDeSaida.Checked : false;
            dtpDataDeSaidaTempo.Enabled = liberado ? cbDataDeSaida.Checked : false;

            edValorMinuto.Enabled = liberado;
        }

        private void BuscarDados()
        {
            var vagas = Dados.BuscarVagas();

            bsVagas.DataSource = vagas.Where(vaga => vaga.VeiculoId == null).ToList();
            
            bsVeiculos.DataSource = Dados.BuscarVeiculos().Where(veiculo =>
            {
                return vagas.Find((vaga) => vaga.VeiculoId == veiculo.Id) == null;
            }).ToList();
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
            cbVaga.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;

            dtpDataDeEntradaDia.Value = DateTime.Now;
            dtpDataDeEntradaTempo.Value = DateTime.Now;

            cbDataDeSaida.Checked = false;
            dtpDataDeSaidaDia.Value = DateTime.Now;
            dtpDataDeSaidaTempo.Value = DateTime.Now;

            edValorMinuto.Clear();
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
            var valorMinutoValido = ValorMinuto >= 0;
            var vagaValida = Vaga != null && Vaga.VeiculoId == null;


            if (!veiculoValido || !vagaValida || !valorMinutoValido)
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

            Estacionamento registro = new Estacionamento();


            registro.VeiculoId = Veiculo.Id;
            registro.VagaId = Vaga.Id;
            registro.DataEntrada = DataEntrada;
            registro.DataSaida = DataSaida;
            registro.ValorMinuto = ValorMinuto;
            Dados.SalvarEstacionamento(registro);

            if(registro.DataSaida == null)
            {
                var VagaAtualizada = this.Vaga;
                VagaAtualizada.VeiculoId = registro.VeiculoId;
                Dados.SalvarVaga(VagaAtualizada);
            }

            Mensagem.Informacao("Registro salvado com sucesso!", "SysPython");

            ResetarOperacao();
        }

        private void cbDataDeSaida_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataDeSaidaDia.Enabled = cbDataDeSaida.Checked;
            dtpDataDeSaidaTempo.Enabled = cbDataDeSaida.Checked;
        }
    }
}
