using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHotel.Contexto;
using AppHotel.RegrasDeNegocio;
using ComponenteMensagens.INTERACAO;

namespace AppHotel.Formularios
{
    public partial class FormCadastrarQuarto : Form
    {
        public FormCadastrarQuarto()
        {
            InitializeComponent();

            FecharComponentes();
            BloquearBotaoSalvarCancelar();
        }

        private void LimparComponentes()
        {
            edTipo.Clear();
            edDiaria.Clear();
        }

        private void LiberarComponentes()
        {
            edTipo.Enabled = true;
            edDiaria.Enabled = true;
        }

        private void FecharComponentes()
        {
            edTipo.Enabled = false;
            edDiaria.Enabled = false;
        }

        private void BloquearBotaoSalvarCancelar()
        {
            btAdd.Enabled = true;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
        }

        private void BloquearBotaoAdd()
        {
            btAdd.Enabled = false;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();
            BloquearBotaoAdd();

            edTipo.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("Deseja realmente cancelar?", "App Hotel");

            if(resp == "sim")
            {
                FecharComponentes();
                LimparComponentes();
                BloquearBotaoSalvarCancelar();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var quarto = new Quarto();
            
            quarto.Tipo = edTipo.Text;
            quarto.ValorDiaria = Convert.ToDouble(edDiaria.Text);

            Dados banco = new Dados();
            banco.AddQuarto(quarto);
            Mensagem.Informacao("Quarto salvado com sucesso!", "App Hotel");

            FecharComponentes();
            LimparComponentes();
            BloquearBotaoSalvarCancelar();
        }
    }
}
