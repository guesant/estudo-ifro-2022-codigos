using AppRegistroVeiculo.RegrasDeNegocio;
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
using FerramentasBiblioteca.Validacoes;
using FerramentasBiblioteca.Formatacoes;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();

            // 5. Bloquear os componentes
            BloquearComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private void BloquearComponentes()
        {
            edNome.Enabled = false;
            edCpf.Enabled = false;
        }

        private void LimparComponentes()
        {
            edNome.Clear();
            edCpf.Clear();
        }

        private void LiberarComponentes()
        {
            edNome.Enabled = true;
            edCpf.Enabled = true;
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

            if (edNome.Text == "" || edCpf.Text == "" || !ValidacoesSociais.ValidarCpf(edCpf.Text))
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
            edNome.Select();
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

            // 8. Salvar registro

            // 8.2. Instância que armazena os valores
            Cliente cliente = new Cliente();

            // 8.3. Atribuir dados
            // cliente.Id = ++id;
            cliente.Nome = edNome.Text;
            cliente.Cpf = Mascaras.LimparCPF(edCpf.Text);

            Dados.SalvarCliente(cliente);

            // 8.7. Limpar e bloquear os componentes
            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoCancelarSalvar();

            Mensagem.Informacao("Salvado com sucesso", "Cadastro");
        }
    }
}
