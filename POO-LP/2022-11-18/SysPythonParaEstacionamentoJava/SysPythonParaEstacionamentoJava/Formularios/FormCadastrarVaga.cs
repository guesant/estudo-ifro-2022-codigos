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
    public partial class FormCadastrarVaga : Form
    {
        private int Numero { get { return Convert.ToInt32(edNumero.Text); } }
        
        public FormCadastrarVaga()
        {
            InitializeComponent();

            ResetarOperacao();
        }


        private void FecharComponentes()
        {
            edNumero.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edNumero.Enabled = true;
        }

        private void LimparComponentes()
        {
            edNumero.Clear();
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
            bool valido = Numero > 0;
            
            if (!valido)
            {
                Mensagem.Erro("Preencha corretamente todos os dados!", "SysPython");
                return false;
            }

            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            
            edNumero.Focus();
            
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

            Vaga registro = new Vaga();

            registro.Numero = Numero;

            Dados.SalvarVaga(registro);

            Mensagem.Informacao("Registro salvado com sucesso!", "SysPython");

            ResetarOperacao();
        }
    }
}
