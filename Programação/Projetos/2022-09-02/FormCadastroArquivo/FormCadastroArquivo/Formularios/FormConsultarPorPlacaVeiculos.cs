using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCadastroArquivo.Contexto;
using FormCadastroArquivo.RegrasDeNegocio;

namespace FormCadastroArquivo.Formularios
{
    public partial class FormConsultarPorPlacaVeiculos : Form
    {
        Dados banco;

        public FormConsultarPorPlacaVeiculos()
        {
            InitializeComponent();

            banco = new Dados();

            bsVeiculos.DataSource = banco.ListaDeVeiculos;
            
            cbVeiculo.DataSource = bsVeiculos;
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;

            cbVeiculo.Focus();
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            edAno.Clear();
            edMarca.Clear();
            edModelo.Clear();
            edValor.Clear();

            Veiculos veiculo = (Veiculos)cbVeiculo.SelectedItem;

            if(veiculo != null)
            {
                edAno.Text = veiculo.Ano.ToString();
                edMarca.Text = veiculo.Marca;
                edModelo.Text = veiculo.Modelo;
                edValor.Text = veiculo.Valor.ToString("C2");
            }
        }
    }
}
