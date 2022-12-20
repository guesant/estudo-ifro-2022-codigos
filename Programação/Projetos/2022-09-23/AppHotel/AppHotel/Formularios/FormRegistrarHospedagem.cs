using AppHotel.Contexto;
using AppHotel.RegrasDeNegocio;
using ComponenteMensagens.INTERACAO;
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
    public partial class FormRegistrarHospedagem : Form
    {
        Dados banco;

        public FormRegistrarHospedagem()
        {
            InitializeComponent();

            FecharComponentes();
            BloquearBotaoSalvarCancelar();

            banco = new Dados();

            bsClientes.DataSource = banco.ListarClientes;
            bsQuartos.DataSource = banco.ListarQuartos;

            cbCliente.DataSource = bsClientes;
            cbCliente.DisplayMember = "Nome";
            cbCliente.SelectedIndex = -1;

            cbQuarto.DataSource = bsQuartos;
            cbQuarto.DisplayMember = "Tipo";
            cbQuarto.SelectedIndex = -1;
        }

        private void FecharComponentes()
        {
            dtEntrada.Enabled = false;
            dtSaida.Enabled = false;
            cbCliente.Enabled = false;
            cbQuarto.Enabled = false;
        }

        private void LiberarComponentes()
        {
            dtEntrada.Enabled = true;
            dtSaida.Enabled = true;
            cbCliente.Enabled = true;
            cbQuarto.Enabled = true;
        }

        private void LimparComponentes()
        {
            dtEntrada.Value = DateTime.Now;
            dtSaida.Value = DateTime.Now;

            cbCliente.SelectedIndex = -1;
            cbQuarto.SelectedIndex = -1;
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
            BloquearBotaoAdd();
            LiberarComponentes();
            dtEntrada.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("Deseja realmente cancelar a operação?", "App Hotel");

            if(resp == "sim")
            {
                BloquearBotaoSalvarCancelar();
                LimparComponentes();
                FecharComponentes();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var cliente = cbCliente.SelectedItem as Cliente;
            var quarto = cbQuarto.SelectedItem as Quarto;

            if(cliente == null)
            {
                Mensagem.Alerta("Selecione um cliente!", "App Hotel");
                cbCliente.Focus();
            }
            else if(quarto == null)
            {
                Mensagem.Alerta("Selecione um quarto!", "App Hotel");
                cbQuarto.Focus();
            }
            else
            {
                var hospedagem = new Hospedagem();

                hospedagem.DataEntrada = dtEntrada.Value;
                hospedagem.DataSaida = dtSaida.Value;
                hospedagem.IdCliente = cliente.Id;
                hospedagem.IdQuarto = quarto.Id;

                banco.AddHospedagem(hospedagem);
                Mensagem.Informacao("Hospedagem registrada com sucesso!", "App Hotel");

                BloquearBotaoSalvarCancelar();
                LimparComponentes();
                FecharComponentes();
            }
        }
    }
}
