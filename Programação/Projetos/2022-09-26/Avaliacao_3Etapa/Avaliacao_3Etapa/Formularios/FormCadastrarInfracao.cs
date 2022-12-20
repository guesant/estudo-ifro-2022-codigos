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
using Avaliacao_3Etapa.RegrasDeNegocio;
using Avaliacao_3Etapa.Contexto;

namespace Avaliacao_3Etapa.Formularios
{
    public partial class FormCadastrarInfracao : Form
    {
        public FormCadastrarInfracao()
        {
            InitializeComponent();

            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoSalvarCancelar();
            
            btAdd.Focus();
        }

        private bool ValidarFormulario()
        {
            if(edMulta.Text == "" || edTipo.Text == "")
            {
                Mensagem.Erro("Preencha todos os campos corretamente!", "Condomínio Delta");
                return false;
            }

            return true;
        }

        private void LimparComponentes()
        {
            edTipo.Clear();
            edMulta.Clear();
        }

        private void BloquearComponentes()
        {
            edTipo.Enabled = false;
            edMulta.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edTipo.Enabled = true;
            edMulta.Enabled = true;
        }

        private void BloquearBotaoAdd()
        {
            btAdd.Enabled = false;
            btSalvar.Enabled = true;
            btCancelar.Enabled = true;
        }

        private void BloquearBotaoSalvarCancelar()
        {
            btAdd.Enabled = true;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LimparComponentes();
            BloquearBotaoAdd();
            LiberarComponentes();
            edTipo.Focus();           
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja cancelar esta operação?", "Condomínio Delta");

            if(resp == "sim")
            {
                LimparComponentes();
                BloquearComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarFormulario())
            {
                Infracao infracao = new Infracao();
                infracao.ValorMulta = Convert.ToDouble(edMulta.Text);
                infracao.Tipo = edTipo.Text;

                Dados banco = new Dados();
                banco.AddMulta(infracao);

                Mensagem.Informacao("Salvado com sucesso!", "Condomínio Delta");

                LimparComponentes();
                BloquearComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }
    }
}
