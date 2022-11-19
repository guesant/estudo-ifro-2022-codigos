using ComponenteMensagens.INTERACAO;
using FormCadastroArquivo.Contexto;
using FormCadastroArquivo.RegrasDeNegocio;
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

namespace FormCadastroArquivo.Formularios
{
    public partial class FormCadastrarPessoas2 : Form
    {
        public FormCadastrarPessoas2()
        {
            InitializeComponent();
            BloquearBotaoCancelarSalvar();
            BloquearComponentes();
        }

        private void BloquearComponentes()
        {
            edCPF.Enabled = false;
            edNome.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edCPF.Enabled = true;
            edNome.Enabled = true;
        }

        private void LimparCampos()
        {
            edCPF.Clear();
            edNome.Clear();
        }

        private void BloquearBotaoCancelarSalvar()
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("Deseja realmente cancelar a operação", "2A INF");

            if (resp == "sim")
            {
                LimparCampos();
                BloquearComponentes();
                BloquearBotaoCancelarSalvar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string cpf = Mascaras.ColocarMascaraCPF(edCPF.Text);

            bool valido = ValidacoesSociais.ValidarCpf(cpf);

            if (valido)
            {
                 // cpf válido
            } else
            {
                // cpf inválido
            }
            
            if(!ValidacoesSociais.ValidarCpf(cpf))
            {
                Mensagem.Erro("O CPF fornecido é inválido!", "2A INF");
                edCPF.Select();
                return;
            }

            Pessoa pessoa = new Pessoa();

            pessoa.Cpf = cpf;
            pessoa.Nome = edNome.Text;

            Dados banco = new Dados();
            banco.AddPessoa(pessoa);

            Mensagem.Informacao("SALVO COM SUCESSO", "2A INF");

            BloquearComponentes();
            LimparCampos();

            BloquearBotaoCancelarSalvar();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            BloquearBotaoAdd();
            edCPF.Select();
        }
    }
}
