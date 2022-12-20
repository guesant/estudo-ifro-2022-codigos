using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FormExemplo1QuartaEtapa.RegrasDeNegocio;

namespace FormExemplo1QuartaEtapa.Formularios
{
    public partial class FormConsultar : Form
    {
        List<Pessoa> listaPessoa = new List<Pessoa>();
        public FormConsultar()
        {
            InitializeComponent();
            CarregarLista();
        }

        private void CarregarLista()
        {
            StreamReader sr = new StreamReader("cadastroPessoa.csv");
            while (!sr.EndOfStream)
            {
                string[] registro = sr.ReadLine().Split(';');
                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32(registro[0]); //Id
                pessoa.Nome = registro[1];//Nome
                pessoa.Cpf = registro[2];//CPF
                pessoa.Email = registro[3];
                listaPessoa.Add(pessoa);//guarda a pessoa na lista
            }
            sr.Close();//fechar arquivo
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dtTabela.DataSource = null;
            dtTabela.Rows.Clear();
            dtTabela.DataSource = listaPessoa.Where(p => p.Nome.ToUpper() == edNome.Text.ToUpper()).ToList();
        }
    }
}
