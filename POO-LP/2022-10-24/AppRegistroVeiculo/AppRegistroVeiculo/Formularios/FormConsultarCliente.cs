using AppRegistroVeiculo.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();

            BuscarDados();

            cbCliente.DataSource = bsClientes;
            cbCliente.DisplayMember = "CPF";
            cbCliente.SelectedIndex = -1;

            dtTabela.DataSource = bsResultados;
        }

        private Cliente ClienteSelecionado => cbCliente.SelectedItem as Cliente;

        private void BuscarDados()
        {
            bsClientes.DataSource = Dados.BuscarClientes();
            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            bsResultados.DataSource = Dados.BuscarClientes().Where(cliente =>
            {
                bool valido = true;

                if(ClienteSelecionado != null)
                {
                    valido = valido && ClienteSelecionado.Id == cliente.Id;
                }

                return valido;
            }).ToList();
        }

        private void btNovaConsulta_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedIndex = -1;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }
    }
}
