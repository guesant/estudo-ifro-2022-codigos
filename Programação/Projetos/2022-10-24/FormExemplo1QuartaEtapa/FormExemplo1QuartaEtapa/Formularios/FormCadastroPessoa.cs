using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;//para mensagens
using System.IO; // para trabalhar com arquivos
using FormExemplo1QuartaEtapa.RegrasDeNegocio; //acessar as classes

namespace FormExemplo1QuartaEtapa.Formularios
{
    public partial class FormCadastroPessoa : Form
    {
        private int id = 0; 
        List<Pessoa> listaPessoa = new List<Pessoa>();
        
        public FormCadastroPessoa()
        {
            InitializeComponent();
            CarregarLista();
            id = listaPessoa.Last().Id;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = ++id;
            pessoa.Nome = edNome.Text;
            pessoa.Cpf = edCpf.Text;
            pessoa.Email = edEmail.Text;
            //=================================
            //Classe StreamWriter => cria e grava registros
            StreamWriter sw = new StreamWriter("cadastroPessoa.csv", true);
            sw.WriteLine(pessoa.ToString());//salvar no arquivo
            sw.Close();//fechar o arquivo
            Mensagem.Informacao("SALVAR COM SUCESSO!", "2A INF"); 
            listaPessoa.Clear();
            CarregarLista(); 
            id = listaPessoa.Last().Id;

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
