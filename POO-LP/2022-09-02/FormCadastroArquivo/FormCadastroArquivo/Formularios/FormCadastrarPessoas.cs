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

namespace FormCadastroArquivo.Formularios
{
    public partial class FormCadastrarPessoas : Form
    {
        public FormCadastrarPessoas()
        {
            InitializeComponent();

            MudarEstadoHabilitadoCampos(false);
            btAdd.Enabled = true;
        }

        private void LimparCampos()
        {
            edCPF.Clear();
            edNome.Clear();
        }

        private void MudarEstadoHabilitadoCampos(bool habilitado)
        {
            edCPF.Enabled = habilitado;
            edNome.Enabled = habilitado;
            btAdd.Enabled = habilitado;
            btSalvar.Enabled = habilitado;
            btCancelar.Enabled = habilitado;
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            MudarEstadoHabilitadoCampos(true);
            btAdd.Enabled = false;
            edCPF.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("Deseja realmente cancelar a operação", "2A INF");

            if (resp == "sim")
            {
                LimparCampos();
                MudarEstadoHabilitadoCampos(false);
                btAdd.Enabled = true;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Cpf = edCPF.Text;
            pessoa.Nome = edNome.Text;

            Dados banco = new Dados();
            banco.AddPessoa(pessoa);

            Mensagem.Informacao("SALVO COM SUCESSO", "2A INF");

            MudarEstadoHabilitadoCampos(false);
            LimparCampos();

            btAdd.Enabled = true;
        }

        private void FormCadastrarPessoas_Load(object sender, EventArgs e)
        {

        }
    }
}
