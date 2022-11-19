using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormExemplo1QuartaEtapa.RegrasDeNegocio;

namespace FormExemplo1QuartaEtapa.Formularios
{
    public partial class FormConsultarPessoas : Form
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();

        public FormConsultarPessoas()
        {
            InitializeComponent();
            CarregarDados();

            dtTabela.DataSource = listaPessoas;
        }

        private void CarregarDados()
        {
            listaPessoas = Pessoa.CarregarLista();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string query = edNome.Text;

            dtTabela.DataSource = null;
            dtTabela.Rows.Clear();
            dtTabela.DataSource = listaPessoas.Where((pessoa) => pessoa.Nome.ToLower().Contains(query.ToLower())).ToList();
        }

        private void edNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btBuscar_Click(null, null);
            }
        }
    }
}
