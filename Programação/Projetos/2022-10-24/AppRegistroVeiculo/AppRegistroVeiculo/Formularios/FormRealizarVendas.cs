using MeusComponentes.Interacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroVeiculo.RegrasDeNegocio;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormRealizarVendas : Form
    {

        private Cliente ClienteSelecionado
        {
            get
            {
                Cliente cliente = cbPessoa.SelectedItem as Cliente;
                return cliente;
                
            }
        }

        private Veiculo VeiculoSelecionado
        {
            get
            {
                Veiculo veiculo = cbVeiculo.SelectedItem as Veiculo;
                return veiculo;
            }
        }

        public FormRealizarVendas()
        {
            InitializeComponent();

            BuscarDados();

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
          
            cbPessoa.DataSource = bsClientes;
            cbPessoa.DisplayMember = "Cpf";
            cbPessoa.SelectedIndex = -1;

            // 5. Bloquear os componentes
            BloquearComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private void BuscarDados()
        {
            bsClientes.DataSource = Dados.BuscarClientes();
            bsVeiculos.DataSource = Dados.BuscarVeiculos();
        }

        private void BloquearComponentes()
        {
            cbPessoa.Enabled = false;
            cbVeiculo.Enabled = false;
            dtpVendas.Enabled = false;
            edValorVenda.Enabled = false;
        }

        private void LimparComponentes()
        {
            cbPessoa.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;
            dtpVendas.Value = DateTime.Now;
            edValorVenda.Clear();
        }

        private void LiberarComponentes()
        {
            cbPessoa.Enabled = true;
            cbVeiculo.Enabled = true;
            dtpVendas.Enabled = true;
            edValorVenda.Enabled = true;
        }

        private void BloquearBotaoCancelarSalvar()
        {
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
        }

        private void BloquearBotaoAdd()
        {
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btAdd.Enabled = false;
        }

        private bool ValidarFormulario()
        {

            if (
                cbPessoa.SelectedIndex == -1 || 
                cbVeiculo.SelectedIndex == -1 ||
                dtpVendas.Value == null || 
                edValorVenda.Text == ""
                )
            {
                Mensagem.Erro("Informe corretamente os dados", "Cadastro");
                return false;
            }

            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            BloquearBotaoAdd();
            cbPessoa.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            // 7. Limpar campos e bloquear componentes

            string resp = Mensagem.Pergunta("Deseja realmente cancelar esta operação?", "2A INF");

            if (resp == "sim")
            {
                BloquearComponentes();
                LimparComponentes();
                BloquearBotaoCancelarSalvar();
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            var cliente = ClienteSelecionado;
            var veiculo = VeiculoSelecionado;

            // 8. Salvar registro

            // 8.2. Instância que armazena os valores
            Venda registro = new Venda();

            // 8.3. Atribuir dados
            registro.ClienteId = cliente.Id;
            registro.VeiculoId = veiculo.Id;
            registro.DataVenda = dtpVendas.Value;
            registro.ValorDaVenda = Convert.ToDouble(edValorVenda.Text);

            Dados.SalvarVenda(registro);

            // 8.7. Limpar e bloquear os componentes
            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoCancelarSalvar();

            Mensagem.Informacao("Salvado com sucesso", "Cadastro");
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            edNome.Clear();
            
            var cliente = ClienteSelecionado;

            if(cliente != null)
            {
                edNome.Text = cliente.Nome;
            }
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            edModelo.Clear();
            edValorVenda.Clear();

            var veiculo = VeiculoSelecionado;

            if (veiculo != null)
            {
                edModelo.Text = veiculo.Modelo;
                edValorVenda.Text = veiculo.Valor.ToString();
            }
        }
    }
}
