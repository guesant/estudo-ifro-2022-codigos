using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormExemplo1QuartaEtapa.Formularios;

namespace FormExemplo1QuartaEtapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastroPessoa_Click(object sender, EventArgs e)
        {
            var form = new FormCadastroPessoa();
            form.ShowDialog();
        }

        private void btListarPessoas_Click(object sender, EventArgs e)
        {
            var form = new FormListarPessoas();
            form.ShowDialog();
        }

        private void btConsultarPessoas_Click(object sender, EventArgs e)
        {
            var form = new FormConsultarPessoas();
            form.ShowDialog();
        }
    }
}
