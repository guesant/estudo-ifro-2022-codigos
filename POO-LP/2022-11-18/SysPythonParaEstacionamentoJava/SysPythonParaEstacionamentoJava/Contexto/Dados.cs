using Microsoft.Win32;
using SysPythonParaEstacionamentoJava.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPythonParaEstacionamentoJava.Contexto
{
    internal class Dados
    {
        private const string ARQUIVO_VAGAS = "vagas.csv";
        private const string ARQUIVO_VEICULOS = "veiculos.csv";
        private const string ARQUIVO_ESTACIONAMENTOS = "estacionamentos.csv";

        public static void LimparDados()
        {
            string[] arquivos = new string[] { ARQUIVO_ESTACIONAMENTOS, ARQUIVO_VEICULOS, ARQUIVO_VAGAS };

            foreach(string arquivo in arquivos)
            {
                File.Delete(arquivo);
                File.CreateText(arquivo).Close();
            }
        }

        public static int ProximoVeiculoId {
            get {
                string ultimaLinha = Arquivo.LerUltimaLinha(ARQUIVO_VEICULOS);

                if(ultimaLinha != null)
                {
                    Veiculo registro = Veiculo.FromString(ultimaLinha);
                    return registro.Id + 1;
                }

                return 1;
            }
        }

        public static int ProximoEstacionamentoId
        {
            get
            {
                string ultimaLinha = Arquivo.LerUltimaLinha(ARQUIVO_ESTACIONAMENTOS);

                if (ultimaLinha != null)
                {
                    Estacionamento registro = Estacionamento.FromString(ultimaLinha);
                    return registro.Id + 1;
                }

                return 1;
            }
        }

        public static int ProximaVagaId
        {
            get
            {
                string ultimaLinha = Arquivo.LerUltimaLinha(ARQUIVO_VAGAS);

                if (ultimaLinha != null)
                {
                    Vaga registro = Vaga.FromString(ultimaLinha);
                    return registro.Id + 1;
                }

                return 1;
            }
        }

        public static List<Vaga> BuscarVagas()
        {
            List<Vaga> listaRegistros = new List<Vaga>();

            FileStream fs = new FileStream(ARQUIVO_VAGAS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (sr.EndOfStream == false)
            {
                string linha = sr.ReadLine();
                Vaga registro = Vaga.FromString(linha);
                listaRegistros.Add(registro);
            }

            sr.Close();
            fs.Close();

            return listaRegistros;
        }

        public static Vaga BuscarVaga(int id)
        {
            FileStream fs = new FileStream(ARQUIVO_VAGAS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Vaga alvo = null;

            while (sr.EndOfStream == false)
            {
                var registro = Vaga.FromString(sr.ReadLine());

                if (registro.Id == id)
                {
                    alvo = registro;
                    break;
                }
            }

            sr.Close();
            fs.Close();

            return alvo;
        }

        public static void SalvarVaga(Vaga registro)
        {
            var arquivoBase = ARQUIVO_VAGAS;

            if (registro.Id == 0)
            {
                registro.Id = ProximaVagaId;

                var fs = new FileStream(arquivoBase, FileMode.Append | FileMode.OpenOrCreate, FileAccess.Write);

                var sw = new StreamWriter(fs);
                sw.WriteLine(registro.ToString());

                sw.Close();
                fs.Close();
            }
            else
            {
                var bakFile = arquivoBase + ".bak";

                File.Copy(arquivoBase, bakFile, true);

                var fsAntigo = new FileStream(bakFile, FileMode.OpenOrCreate, FileAccess.Read);
                var fsNovo = new FileStream(arquivoBase, FileMode.OpenOrCreate | FileMode.Truncate, FileAccess.ReadWrite);

                var sr = new StreamReader(fsAntigo);
                var sw = new StreamWriter(fsNovo);

                while (sr.EndOfStream == false)
                {
                    string linha = sr.ReadLine();
                    var registroAntigo = Vaga.FromString(linha);
                    sw.WriteLine(registroAntigo.Id == registro.Id ? registro.ToString() : linha);
                }

                sr.Close();
                sw.Close();
                fsAntigo.Close();
                fsNovo.Close();

                File.Delete(bakFile);
            }
        }

        public static List<Veiculo> BuscarVeiculos ()
        {
            List<Veiculo> listaRegistros = new List<Veiculo>();

            FileStream fs = new FileStream(ARQUIVO_VEICULOS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while(sr.EndOfStream == false)
            {
                string linha = sr.ReadLine();
                Veiculo registro = Veiculo.FromString(linha);
                listaRegistros.Add(registro);
            }

            sr.Close();
            fs.Close();

            return listaRegistros;
        }

        public static Veiculo BuscarVeiculo(int id)
        {
            FileStream fs = new FileStream(ARQUIVO_VEICULOS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Veiculo alvo = null;

            while (sr.EndOfStream == false)
            {
                var registro = Veiculo.FromString(sr.ReadLine());

                if (registro.Id == id)
                {
                    alvo = registro;
                    break;
                }
            }

            sr.Close();
            fs.Close();

            return alvo;
        }

        public static void SalvarVeiculo(Veiculo registro)
        {
            var arquivoBase = ARQUIVO_VEICULOS;

            if (registro.Id == 0)
            {
                registro.Id = ProximoVeiculoId;

                var fs = new FileStream(arquivoBase, FileMode.Append | FileMode.OpenOrCreate, FileAccess.Write);

                var sw = new StreamWriter(fs);
                sw.WriteLine(registro.ToString());

                sw.Close();
                fs.Close();
            }
            else
            {
                var bakFile = arquivoBase + ".bak";

                File.Copy(arquivoBase, bakFile, true);

                var fsAntigo = new FileStream(bakFile, FileMode.OpenOrCreate, FileAccess.Read);
                var fsNovo = new FileStream(arquivoBase, FileMode.OpenOrCreate | FileMode.Truncate, FileAccess.Write);

                var sr = new StreamReader(fsAntigo);
                var sw = new StreamWriter(fsNovo);

                while (sr.EndOfStream == false)
                {
                    string linha = sr.ReadLine();
                    var registroAntigo = Veiculo.FromString(linha);
                    sw.WriteLine(registroAntigo.Id == registro.Id ? registro.ToString() : linha);
                }

                sr.Close();
                sw.Close();
                fsAntigo.Close();
                fsNovo.Close();

                File.Delete(bakFile);
            }
        }

        public static List<Estacionamento> BuscarEstacionamentos()
        {
            List<Estacionamento> listaRegistros = new List<Estacionamento>();

            FileStream fs = new FileStream(ARQUIVO_ESTACIONAMENTOS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (sr.EndOfStream == false)
            {
                string linha = sr.ReadLine();
                var registro = Estacionamento.FromString(linha);
                listaRegistros.Add(registro);
            }

            sr.Close();
            fs.Close();

            return listaRegistros;
        }

        public static Estacionamento BuscarEstacionamento(int id)
        {
            FileStream fs = new FileStream(ARQUIVO_ESTACIONAMENTOS, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Estacionamento alvo = null;

            while (sr.EndOfStream == false)
            {
                Estacionamento registro = Estacionamento.FromString(sr.ReadLine());
                
                if(registro.Id == id)
                {
                    alvo = registro;
                    break;
                }
            }

            sr.Close();
            fs.Close();

            return alvo;
        }

        public static void SalvarEstacionamento(Estacionamento registro)
        {
            var arquivoBase = ARQUIVO_ESTACIONAMENTOS;

            if (registro.Id == 0)
            {
                registro.Id = ProximoEstacionamentoId;

                var fs = new FileStream(arquivoBase, FileMode.Append | FileMode.OpenOrCreate, FileAccess.Write);

                var sw = new StreamWriter(fs);
                sw.WriteLine(registro.ToString());

                sw.Close();
                fs.Close();
            }
            else
            {
                var bakFile = arquivoBase + ".bak";

                File.Copy(arquivoBase, bakFile, true);

                var fsAntigo = new FileStream(bakFile, FileMode.OpenOrCreate, FileAccess.Read);
                var fsNovo = new FileStream(arquivoBase, FileMode.OpenOrCreate | FileMode.Truncate, FileAccess.Write);

                var sr = new StreamReader(fsAntigo);
                var sw = new StreamWriter(fsNovo);

                while (sr.EndOfStream == false)
                {
                    string linha = sr.ReadLine();
                    var registroAntigo = Estacionamento.FromString(linha);
                    sw.WriteLine(registroAntigo.Id == registro.Id ? registro.ToString() : linha);
                }

                sr.Close();
                sw.Close();
                fsAntigo.Close();
                fsNovo.Close();

                File.Delete(bakFile);
            }
        }

        public static void ApagarEstacionamento(int id)
        {
            var arquivoBase = ARQUIVO_ESTACIONAMENTOS;

            var bakFile = arquivoBase + ".bak";

            File.Copy(arquivoBase, bakFile, true);

            var fsAntigo = new FileStream(bakFile, FileMode.OpenOrCreate, FileAccess.Read);
            var fsNovo = new FileStream(arquivoBase, FileMode.OpenOrCreate | FileMode.Truncate, FileAccess.Write);

            var sr = new StreamReader(fsAntigo);
            var sw = new StreamWriter(fsNovo);

            while (sr.EndOfStream == false)
            {
                string linha = sr.ReadLine();
                var registro = Estacionamento.FromString(linha);

                if (registro.Id != id)
                {
                    sw.WriteLine(linha);
                }
            }
            
            sr.Close();
            sw.Close();
            fsAntigo.Close();
            fsNovo.Close();

            File.Delete(bakFile);
        }
    }
}
