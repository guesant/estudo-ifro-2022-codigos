using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeusComponentes.Interacoes;
using AppRegistroVeiculo.RegrasDeNegocio; // Veiculo e Dados

namespace AppRegistroVeiculo.Formularios
{
    public partial class FormCadastroVeiculo : Form
    {
        public FormCadastroVeiculo()
        {
            InitializeComponent();

            // 5. Bloquear os componentes
            BloquearComponentes();
            BloquearBotaoCancelarSalvar();
        }

        private void BloquearComponentes ()
        {
            edModelo.Enabled = false;
            edAno.Enabled = false;
            edPlaca.Enabled = false;
            edMarca.Enabled = false;
            edValor.Enabled = false;
        }

        private void LimparComponentes()
        {
            edModelo.Clear();
            edAno.Clear();
            edPlaca.Clear();
            edMarca.Clear();
            edValor.Clear();
        }

        private void LiberarComponentes()
        {
            edModelo.Enabled = true;
            edAno.Enabled = true;
            edPlaca.Enabled = true;
            edMarca.Enabled = true;
            edValor.Enabled = true;
        }


        private void BloquearBotaoCancelarSalvar()
        {
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;
            btAdd.Enabled = true;
        }


        private void BloquearBotaoAdd()
        {
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            btAdd.Enabled = false;
        }

        private bool ValidarFormulario()
        {

            if(edModelo.Text == "" || edAno.Text == "" || edPlaca.Text == "" || edMarca.Text == "" || edValor.Text == "")
            {
                Mensagem.Erro("Informe corretamente os dados", "2A INF");
                return false;
            }

            return true;            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            LiberarComponentes();            
            BloquearBotaoAdd();            
            edModelo.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            // 7. Limpar campos e bloquear componentes

            string resp = Mensagem.Pergunta("Deseja realmente cancelar esta operação?", "2A INF");

            if(resp == "sim")
            {
                BloquearComponentes();
                LimparComponentes();
                BloquearBotaoCancelarSalvar();
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidarFormulario())
            {
                return;
            }

            // 8. Salvar registro

            // 8.2. Instância que armazena os valores
            Veiculo veiculo = new Veiculo();

            // 8.3. Atribuir dados
            // veiculo.Id = ++id;
            veiculo.Modelo = edModelo.Text;
            veiculo.Marca = edMarca.Text;
            veiculo.Placa = edPlaca.Text;
            veiculo.Ano = Convert.ToInt32(edAno.Text);
            veiculo.Valor = Convert.ToDouble(edValor.Text);

            Dados.SalvarVeiculo(veiculo);

            // 8.7. Limpar e bloquear os componentes
            BloquearComponentes();
            LimparComponentes();
            BloquearBotaoCancelarSalvar();

            Mensagem.Informacao("Salvado com sucesso", "Cadastro");
        }
    }
}
