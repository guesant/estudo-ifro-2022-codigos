using AppHotel.Contexto;
using AppHotel.RegrasDeNegocio;
using ComponenteMensagens.INTERACAO;
using FerramentasBiblioteca.Formatacoes;
using FerramentasBiblioteca.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHotel.Formularios
{
    public partial class FormCadastrarCliente : Form
    {
        
        public FormCadastrarCliente()
        {
            InitializeComponent();

            FecharComponentes();
            BloquearBotaoSalvarCancelar();
        }

        private void FecharComponentes()
        {
            edCPF.Enabled = false;
            edEmail.Enabled = false;
            edNome.Enabled = false;
            edTelefone.Enabled = false;
        }

        private void LiberarComponentes()
        {
            edCPF.Enabled = true;
            edEmail.Enabled = true;
            edNome.Enabled = true;
            edTelefone.Enabled = true;
        }

        private void LimparComponentes()
        {
            edCPF.Clear();
            edEmail.Clear();
            edNome.Clear();
            edTelefone.Clear();
        }

        private void BloquearBotaoSalvarCancelar()
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            BloquearBotaoAdd();
            edCPF.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("Deseja realmente cancelar esta operação?", "App Hotel");

            if(resp == "sim")
            {
                LimparComponentes();
                FecharComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var cpf = Mascaras.LimparCPF(edCPF.Text);

            bool valido = ValidacoesSociais.ValidarCpf(cpf);

            if (valido)
            {
                var cliente = new Cliente();

                cliente.Cpf = cpf;
                cliente.Telefone = edTelefone.Text;
                cliente.Email = edEmail.Text;
                cliente.Nome = edNome.Text;

                Dados banco = new Dados();
                banco.AddCliente(cliente);

                Mensagem.Informacao("Cliente cadastrado com sucesso!", "App Hotel");

                LimparComponentes();
                FecharComponentes();
                BloquearBotaoSalvarCancelar();
            }
            else
            {
                Mensagem.Erro("Digite um CPF válido!", "App Hotel");
                edCPF.Select();
            }
        }
    }
}
