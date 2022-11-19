using MeusComponentes.Interacoes;
using Microsoft.Win32;
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
    public partial class FormCadastrarVeiculo : Form
    {
        public FormCadastrarVeiculo()
        {
            InitializeComponent();

            ResetarOperacao();
        }

        private string modelo { get { return edModelo.Text.Trim(); } }
        private string placa { get { return edPlaca.Text.Trim(); } }
        private string marca { get { return edMarca.Text.Trim(); } }
        private string cor { get { return edCor.Text.Trim(); } }

        private void FecharComponentes()
        {
            edModelo.Enabled = false;
            edPlaca.Enabled = false;
            edMarca.Enabled = false;
            edCor.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edModelo.Enabled = true;
            edPlaca.Enabled = true;
            edMarca.Enabled = true;
            edCor.Enabled = true;
        }

        private void LimparComponentes()
        {
            edModelo.Clear();
            edPlaca.Clear();
            edMarca.Clear();
            edCor.Clear();
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
            FecharComponentes();
            LimparComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private bool ValidarOperacao()
        {
            if(modelo.Length == 0 || marca.Length == 0 || placa.Length == 0)
            {
                Mensagem.Erro("Preencha corretamente todos os dados!", "SysPython");
                return false;
            }

            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            edModelo.Focus();
            BloquearBotaoAdd();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja realmente cancelar esta operação?", "SysPython");

            if(resp == "sim")
            {
                ResetarOperacao();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidarOperacao())
            {
                return;
            }

            Veiculo registro = new Veiculo();

            registro.Modelo = modelo;
            registro.Marca = marca;
            registro.Placa = placa;
            registro.Cor = cor;

            Dados.SalvarVeiculo(registro);

            Mensagem.Informacao("Registro salvado com sucesso!", "SysPython");

            ResetarOperacao();
        }
    }
}
