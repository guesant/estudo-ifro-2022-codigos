using SysPythonParaEstacionamentoJava.Contexto;
using SysPythonParaEstacionamentoJava.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPythonParaEstacionamentoJava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarVeiculo();
            form.ShowDialog();
        }

        private void btRegistrarEstacionamento_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarEstacionamento();
            form.ShowDialog();
        }

        private void btListarVeiculos_Click(object sender, EventArgs e)
        {
            var form = new ListarVeiculo();
            form.ShowDialog();
        }

        private void btListarEstacionamentos_Click(object sender, EventArgs e)
        {
            var form = new FormBuscarEstacionamentos();
            form.ShowDialog();
        }

        private void btFerramentasAdministrativas_Click(object sender, EventArgs e)
        {
            var form = new FormFerramentasAdministrativas();
            form.ShowDialog();
        }

        private void btCadastrarVagas_Click(object sender, EventArgs e)
        {
            var form = new FormCadastrarVaga();
            form.ShowDialog();
        }

        private void btListarVagas_Click(object sender, EventArgs e)
        {
            var form = new FormBuscarVagas();
            form.ShowDialog();
        }


        private void btRegistrarSaida_Click(object sender, EventArgs e)
        {
            var form = new FormRegistrarSaida();
            form.ShowDialog();
        }
    }
}
