using MeusComponentes.Interacoes;
using SysPythonParaEstacionamentoJava.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPythonParaEstacionamentoJava.Formularios
{
    public partial class FormFerramentasAdministrativas : Form
    {
        public FormFerramentasAdministrativas()
        {
            InitializeComponent();
        }
        private void btDebugAbrirPastaExecutavel_Click(object sender, EventArgs e)
        {
            string pwd = Directory.GetCurrentDirectory();
            Process.Start(pwd);
        }
        private void btDebugLimparDados_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Pergunta("Essa operação vai apagar todos os dados do sistema. Tem certeza que deseja prosseguir?", "SysPython");
            
            if(resp == "sim")
            {
                Dados.LimparDados();
                Mensagem.Informacao("Dados limpados com sucesso!", "SysPython");
            }
        }
    }
}
