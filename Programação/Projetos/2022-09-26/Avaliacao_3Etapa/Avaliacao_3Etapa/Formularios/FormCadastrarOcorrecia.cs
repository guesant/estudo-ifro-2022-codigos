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
    public partial class FormCadastrarOcorrecia : Form
    {
        public FormCadastrarOcorrecia()
        {
            InitializeComponent();

            Dados banco = new Dados();

            bsMultas.DataSource = banco.ListarInfracoes;
            cbMulta.DataSource = bsMultas;
            cbMulta.DisplayMember = "Tipo";
            cbMulta.SelectedIndex = -1;

            bsMoradores.DataSource = banco.ListarMoradores;
            cbMorador.DataSource = bsMoradores;
            cbMorador.DisplayMember = "Nome";
            cbMorador.SelectedIndex = -1;

            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoSalvarCancelar();

            btAdd.Focus();
        }

        private bool ValidarFormulario()
        {
            if (
                cbMulta.SelectedIndex == -1
                || cbMorador.SelectedIndex == -1
            )
            {
                Mensagem.Erro("Preencha todos os campos corretamente!", "Condomínio Delta");
                return false;
            }

            return true;
        }

        private void LimparComponentes()
        {
            cbMulta.SelectedIndex = -1;
            cbMorador.SelectedIndex = -1;
            dtpInicio.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
        }

        private void BloquearComponentes()
        {
            cbMulta.Enabled = false;
            cbMorador.Enabled = false;
            dtpInicio.Enabled = false;
            dtpFim.Enabled = false;
        }

        private void LiberarComponentes()
        {
            cbMulta.Enabled = true;
            cbMorador.Enabled = true;
            dtpInicio.Enabled = true;
            dtpFim.Enabled = true;
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
            cbMulta.Focus();
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
                var infracao = cbMulta.SelectedItem as Infracao;
                var morador = cbMorador.SelectedItem as Morador;                

                Ocorrencia ocorrencia = new Ocorrencia();
                ocorrencia.IdMorador = morador.Id;
                ocorrencia.IdInfracao = infracao.Id;
                ocorrencia.DataInicio = dtpInicio.Value;
                ocorrencia.DataFim = dtpFim.Value;                

                Dados banco = new Dados();
                banco.AddOcorrencia(ocorrencia);

                Mensagem.Informacao("Salvado com sucesso!", "Condomínio Delta");

                LimparComponentes();
                BloquearComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }

        private void cbMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            edTipo.Clear();

            var infracao = cbMulta.SelectedItem as Infracao;
            
            if(infracao != null)
            {
                edTipo.Text = infracao.Tipo;
            }
        }

        private void cbMorador_SelectedIndexChanged(object sender, EventArgs e)
        {
            edCpf.Clear();

            var morador = cbMorador.SelectedItem as Morador;

            if (morador != null)
            {
                edCpf.Text = morador.Cpf;
            }
        }
    }
}
