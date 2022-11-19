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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroPessoa form = new FormCadastroPessoa();
            form.ShowDialog();  
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListarPessoas form = new FormListarPessoas();
            form.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar form = new FormConsultar();
            form.ShowDialog();
        }
    }
}
