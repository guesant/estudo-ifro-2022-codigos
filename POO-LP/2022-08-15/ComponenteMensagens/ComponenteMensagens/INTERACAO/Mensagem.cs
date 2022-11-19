using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteMensagens.INTERACAO
{
    public static class Mensagem
    {
        public static void Alerta(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Informacao(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Erro(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string Questionamento(string questao, string titulo)
        {
            DialogResult result = MessageBox.Show(questao, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string resp = "";

            if (result == DialogResult.Yes) resp = "sim";
            if (result == DialogResult.No) resp = "não";

            return resp;

        }
    }
}
