using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCadastroArquivo.Formularios;

namespace FormCadastroArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btListarPessoas_Click(object sender, EventArgs e)
        {
            FormListarPessoas form = new FormListarPessoas();
            form.ShowDialog(); 
        }

        private void btListarVeiculo_Click(object sender, EventArgs e)
        {
            FormListarVeiculos form = new FormListarVeiculos();
            form.ShowDialog();
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            FormRealizarVendas form = new FormRealizarVendas();
            form.ShowDialog();
        }
    }
}
