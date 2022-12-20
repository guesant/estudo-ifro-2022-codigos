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
using System.IO;
using FormExemplo1QuartaEtapa.RegrasDeNegocio;

namespace FormExemplo1QuartaEtapa.Formularios
{
    public partial class FormCadastroPessoa : Form
    {
        private int id = 0;

        public FormCadastroPessoa()
        {
            InitializeComponent();

            CarregarDados();

            FecharComponentes();
            BloquearBotaoCancelarSalvar();
            LimparComponentes();
        }

        private void CarregarDados()
        {
            var listaPessoas = Pessoa.CarregarLista();
            id = listaPessoas.Count > 0 ? listaPessoas.Last().Id : 0;
        }

        private void FecharComponentes()
        {
            edNome.Enabled = false;
            edCpf.Enabled = false;
            edEmail.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edNome.Enabled = true;
            edCpf.Enabled = true;
            edEmail.Enabled = true;
        }

        private void BloquearBotaoAdd()
        {
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void LimparComponentes()
        {
            edNome.Clear();
            edCpf.Clear();
            edEmail.Clear();
        }

        private void BloquearBotaoCancelarSalvar()
        {
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            LimparComponentes();
            BloquearBotaoAdd();
            edNome.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Deseja cancelar esta operação?", "App");

            if(resp == "sim")
            {
                LimparComponentes();
                FecharComponentes();
                BloquearBotaoCancelarSalvar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = ++id;
            pessoa.Nome = edNome.Text;
            pessoa.Cpf = edCpf.Text;
            pessoa.Email = edEmail.Text;

            //==================================
            //Classe StreamWriter => cria e grava registros

            StreamWriter sw = new StreamWriter("cadastroPessoa.csv", true);
            sw.WriteLine(pessoa.ToString());
            sw.Close();

            Mensagem.Informacao("Salvado com sucesso!", "App");

            LimparComponentes();
            FecharComponentes();
            BloquearBotaoCancelarSalvar();
            CarregarDados();
        }
    }
}
