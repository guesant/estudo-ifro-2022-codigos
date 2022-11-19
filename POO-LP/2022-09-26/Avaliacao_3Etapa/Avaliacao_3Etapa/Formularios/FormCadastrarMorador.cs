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
    public partial class FormCadastrarMorador : Form
    {
        public FormCadastrarMorador()
        {
            InitializeComponent();

            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoSalvarCancelar();
            
            btAdd.Focus();
        }

        private bool ValidarFormulario()
        {
            if (edNome.Text == "" || edCpf.Text == "" || edTelefone.Text == "" || edRua.Text == "" || edNumeroCasa.Text == "")
            {
                Mensagem.Erro("Preencha todos os campos corretamente!", "Condomínio Delta");
                return false;
            }

            return true;
        }

        private void LimparComponentes()
        {
            edNome.Clear();
            edCpf.Clear();
            edTelefone.Clear();
            edRua.Clear();
            edNumeroCasa.Clear();
        }

        private void BloquearComponentes()
        {
            edNome.Enabled = false;
            edCpf.Enabled = false;
            edTelefone.Enabled = false;
            edRua.Enabled = false;
            edNumeroCasa.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edNome.Enabled = true;
            edCpf.Enabled = true;
            edTelefone.Enabled = true;
            edRua.Enabled = true;
            edNumeroCasa.Enabled = true;
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
            edNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja cancelar esta operação?", "Condomínio Delta");

            if (resp == "sim")
            {
                LimparComponentes();
                BloquearComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Morador morador = new Morador();
                morador.Nome = edNome.Text;
                morador.Cpf = edCpf.Text;
                morador.Telefone = edTelefone.Text;
                morador.Rua = edRua.Text;
                morador.NumeroCasa = Convert.ToInt32(edNumeroCasa.Text);

                Dados banco = new Dados();
                banco.AddMorador(morador);

                Mensagem.Informacao("Salvado com sucesso!", "Condomínio Delta");

                LimparComponentes();
                BloquearComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }
    }
}
