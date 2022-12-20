using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponenteMensagens.INTERACAO;
using FormCadastroArquivo.RegrasDeNegocio;
using FormCadastroArquivo.Contexto;

namespace FormCadastroArquivo.Formularios
{
    public partial class FormCadastrarCarros : Form
    {
        public FormCadastrarCarros()
        {
            InitializeComponent();

            // desabilitar componentes

            MudarEstadoHabilitadoCampos(false);
            btAdd.Enabled = true;
        }

        private void LimparCampos()
        {
            edModelo.Clear();
            edMarca.Clear();
            edPlaca.Clear();
            edAno.Clear();
            edValor.Clear();
        }

        private void MudarEstadoHabilitadoCampos(bool habilitado)
        {
            edModelo.Enabled = habilitado;
            edMarca.Enabled = habilitado;
            edPlaca.Enabled = habilitado;
            edAno.Enabled = habilitado;
            edValor.Enabled = habilitado;
            btAdd.Enabled = habilitado;
            btSalvar.Enabled = habilitado;
            btCancelar.Enabled = habilitado;
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            MudarEstadoHabilitadoCampos(true);
            btAdd.Enabled = false;
            edModelo.Select();
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
            Veiculos carro = new Veiculos();

            carro.Modelo = edModelo.Text;
            carro.Marca = edMarca.Text;
            carro.Placa = edPlaca.Text;
            carro.Ano = Convert.ToInt32(edAno.Text);
            carro.Valor = Convert.ToDouble(edValor.Text);

            Dados banco = new Dados();
            banco.AddVeiculo(carro);

            Mensagem.Informacao("SALVO COM SUCESSO", "2A INF");

            MudarEstadoHabilitadoCampos(false);
            LimparCampos();

            btAdd.Enabled = true;

        }
    }
}
