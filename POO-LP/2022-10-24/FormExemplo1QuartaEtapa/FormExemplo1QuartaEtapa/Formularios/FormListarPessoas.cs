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
using System.IO;//para acessar as pastas

namespace FormExemplo1QuartaEtapa.Formularios
{
    public partial class FormListarPessoas : Form
    {
        private List<Pessoa> listaPessoa = new List<Pessoa>();
        
        //método construtor
        public FormListarPessoas()
        {
            InitializeComponent();
            CarregarLista();
            dtTabela.DataSource = listaPessoa;//conectar com a tabela
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

    }
}
