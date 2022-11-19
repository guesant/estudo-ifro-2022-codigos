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

namespace FormCadastroArquivo.Formularios
{
    public partial class FormListarPessoas : Form
    {
        public FormListarPessoas()
        {
            InitializeComponent();

            Dados banco = new Dados();
            bsPessoa.DataSource = banco.ListaDePessoas;
            dgvPessoa.DataSource = bsPessoa;
        }

        private void btCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FormCadastrarPessoas2 form = new FormCadastrarPessoas2();
            form.ShowDialog();
        }
    }
}
