using ComponenteMensagens.INTERACAO;

namespace AppTesteMensagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAlerta_Click(object sender, EventArgs e)
        {
            Mensagem.Alerta("Msg de alerta", "2A INF");
        }

        private void btInformacao_Click(object sender, EventArgs e)
        {
            Mensagem.Informacao("Msg de informacao", "2A INF");

        }

        private void btErro_Click(object sender, EventArgs e)
        {
            Mensagem.Erro("Msg de erro", "2A INF");
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            string resp = Mensagem.Questionamento("qasua resp", "oi");

            Mensagem.Informacao(resp, "resp");
        }
    }
}