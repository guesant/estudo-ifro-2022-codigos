using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysPythonParaEstacionamentoJava.Contexto;
using SysPythonParaEstacionamentoJava.RegrasDeNegocio;

namespace SysPythonParaEstacionamentoJava.Formularios
{
    public partial class ListarVeiculo : Form
    {
        List<Veiculo> listaVeiculos = new List<Veiculo>();

        public ListarVeiculo()
        {
            InitializeComponent();
            
            BuscarDados();

            dgvListaVeiculos.DataSource = bsResultados;
            
            cbPlaca.DataSource = bsVeiculos;
            cbPlaca.DisplayMember = "Placa";
            cbPlaca.SelectedIndex = -1;
        }

        private string PlacaSelecionada
        {
            get
            {
                string placa = "";

                if(cbPlaca.SelectedIndex != -1)
                {
                    var veiculo = cbPlaca.SelectedItem as Veiculo;
                    placa = veiculo.Placa;
                }

                return placa;
            }
        }

        private void BuscarDados()
        {
            listaVeiculos = Dados.BuscarVeiculos();

            bsVeiculos.DataSource = listaVeiculos;

            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            bsResultados.DataSource = listaVeiculos.Where((veiculo) => {
                if(PlacaSelecionada !=  "")
                {
                    return veiculo.Placa == PlacaSelecionada;
                }

                return true;
            });
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            cbPlaca.SelectedIndex = -1;
        }

        private void cbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultados();
        }
    }
}
