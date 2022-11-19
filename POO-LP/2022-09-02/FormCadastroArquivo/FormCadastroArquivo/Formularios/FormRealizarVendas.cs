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
using FormCadastroArquivo.RegrasDeNegocio;
using ComponenteMensagens.INTERACAO;

namespace FormCadastroArquivo.Formularios
{
    public partial class FormRealizarVendas : Form
    {
        Dados banco;

        public FormRealizarVendas()
        {
            InitializeComponent();

            banco = new Dados();
            
            bsPessoa.DataSource = banco.ListaDePessoas;
            cbPessoa.DataSource = bsPessoa;
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.SelectedIndex = -1;

            bsVeiculo.DataSource = banco.ListaDeVeiculos;
            cbVeiculo.DataSource = bsVeiculo;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;

            BloquearComponentes();
            BloquarBotaoCancelarSalvar();
        }

        private Pessoa pessoaSelecionada
        {
            get
            {
                return (Pessoa)cbPessoa.SelectedItem;
            }
        }

        private Veiculos veiculoSelecionado
        {
            get
            {
                return (Veiculos)cbVeiculo.SelectedItem;
            }
        }

        private void EstadoHabilitadoCampos(bool habilitado)
        {
            cbPessoa.Enabled = habilitado;
            cbVeiculo.Enabled = habilitado;
            dtDataVenda.Enabled = habilitado;

            edCpf.Enabled = habilitado;
            edModelo.Enabled = habilitado;
            edValor.Enabled = habilitado;
        }

        private void BloquearComponentes()
        {
            EstadoHabilitadoCampos(false);
        }

        private void LiberarComponentes()
        {
            EstadoHabilitadoCampos(true);
        }

        private void LimparCampos()
        {
            cbPessoa.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;
            dtDataVenda.Value = DateTime.Now;
        }

        private void BloquarBotaoCancelarSalvar()
        {
            btAdd.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void BloquearBotaoAdd()
        {
            btAdd.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            edCpf.Text = "";
            
            if(pessoaSelecionada != null)
            {
                edCpf.Text = pessoaSelecionada.Cpf;
            }         
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            edModelo.Text = "";
            edValor.Text = "";
            
            if (veiculoSelecionado != null)
            {
                edModelo.Text = veiculoSelecionado.Modelo;
                edValor.Text = veiculoSelecionado.Valor.ToString("C2");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            BloquearComponentes();

            BloquarBotaoCancelarSalvar();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LiberarComponentes();

            cbPessoa.Focus();
            BloquearBotaoAdd();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // processamento de salvar dados

            if(pessoaSelecionada == null || veiculoSelecionado == null)
            {
                Mensagem.Erro("Preencha os dados corretamente!", "2A INF");
            }
            else
            {
                Venda venda = new Venda();
                venda.PessoaId = pessoaSelecionada.Id;
                venda.VeiculoId = veiculoSelecionado.Id;
                venda.DataVenda = dtDataVenda.Value;
                banco.AddVendas(venda);

                Mensagem.Informacao("Venda registrada com sucesso!", "2A INF");

                // fechamento
                BloquarBotaoCancelarSalvar();
                LimparCampos();
                BloquearComponentes();
            }
        }
    }
}
