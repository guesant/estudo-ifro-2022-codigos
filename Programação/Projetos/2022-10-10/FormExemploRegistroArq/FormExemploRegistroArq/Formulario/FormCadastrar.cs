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

namespace FormExemploRegistroArq.Formulario
{
    public partial class FormCadastrar : Form
    {
        private int id;
        public FormCadastrar()
        {
            InitializeComponent();
            //bloquear campos e botões exceto o btAdd
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEmail.Enabled = false;
            txtRenda.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            BuscarUltimoId();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           //libera os campos e botões
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtRenda.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            //bloqueia o botão ADD
            btAdd.Enabled = false;
            txtNome.Select();//coloca o curso no campo do nome
            id++;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo Cancelar?",//mensagem
                                                "ADS 2P",//título
                                                MessageBoxButtons.YesNo,//botões
                                                MessageBoxIcon.Question //ícone
                                                );
            //para o caso da resposta ser sim 
            if (resp == DialogResult.Yes)
            {
                //bloqueio os campos
                txtNome.Enabled = false;
                txtCpf.Enabled = false;
                txtEmail.Enabled = false;
                txtRenda.Enabled = false;
                btCancelar.Enabled = false;
                btSalvar.Enabled = false;
                btAdd.Enabled = true;//libera o botão ADD
                //limpa os campos
                txtNome.Clear();
                txtCpf.Clear();
                txtRenda.Clear();
                txtEmail.Clear();
                id--;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("SALVO COM SUCESSO!",//mensagem
                            "ADS 2P",//título
                            MessageBoxButtons.OK,//botões
                            MessageBoxIcon.Information //ícone
                            );
          
            //bloqueio os campos
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEmail.Enabled = false;
            txtRenda.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;//libera o botão ADD
            //limpa os campos
            txtNome.Clear();
            txtCpf.Clear();
            txtRenda.Clear();
            txtEmail.Clear();
        }

        private void BuscarUltimoId()
        {
            
        }
    }
}
