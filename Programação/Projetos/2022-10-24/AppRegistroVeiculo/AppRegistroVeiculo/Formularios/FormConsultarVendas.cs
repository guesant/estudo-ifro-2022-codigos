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

    public partial class FormConsultarVendas : Form
    {
        [Flags]
        enum ModoConsulta
        {
            CLIENTE = 1,
            VEICULO = 2,
        }

        public FormConsultarVendas()
        {
            InitializeComponent();

            BuscarDados();

            cbCliente.DataSource = bsClientes;
            cbCliente.DisplayMember = "CPF";
            cbCliente.SelectedIndex = -1;

            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;

            dtTabela.DataSource = bsResultados;
        }

        private Cliente ClienteSelecionado => cbCliente.SelectedItem as Cliente;
        private Veiculo VeiculoSelecionado => cbVeiculo.SelectedItem as Veiculo;

        private void BuscarDados()
        {
            bsClientes.DataSource = Dados.BuscarClientes();
            bsVeiculos.DataSource = Dados.BuscarVeiculos();

            AtualizarResultados(null);
        }

        private void AtualizarResultados(ModoConsulta? modo)
        {
            bsResultados.DataSource = Dados.BuscarVendas().Where(venda =>
            {
                bool valido = true;

                if(modo != null)
                {
                    if((modo & ModoConsulta.CLIENTE) == ModoConsulta.CLIENTE)
                    {
                        if(ClienteSelecionado != null)
                        {
                            valido = valido && venda.ClienteId == ClienteSelecionado.Id;
                        }
                    }

                    if ((modo & ModoConsulta.VEICULO) == ModoConsulta.VEICULO)
                    {
                        if (VeiculoSelecionado != null)
                        {
                            valido = valido && venda.VeiculoId == VeiculoSelecionado.Id;
                        }
                    }
                }

                return valido;
            }).ToList();
        }

        private void btNovaConsulta_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedIndex = -1;
            cbVeiculo.SelectedIndex = -1;
            AtualizarResultados(null);
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            AtualizarResultados(ModoConsulta.CLIENTE);
        }

        private void btBuscarClientePlaca_Click(object sender, EventArgs e)
        {
            AtualizarResultados(ModoConsulta.CLIENTE | ModoConsulta.VEICULO);
        }

        private void btBuscarVeiculo_Click(object sender, EventArgs e)
        {
            AtualizarResultados(ModoConsulta.VEICULO);
        }
    }
}
