using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPythonParaEstacionamentoJava.Contexto
{
    internal class Arquivo
    {
        public static string LerUltimaLinha(string arquivo)
        {
            FileStream fs = new FileStream(arquivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string ultimaLinha = null;

            while (sr.EndOfStream == false)
            {
                ultimaLinha = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

            return ultimaLinha;
        }

    }
}
