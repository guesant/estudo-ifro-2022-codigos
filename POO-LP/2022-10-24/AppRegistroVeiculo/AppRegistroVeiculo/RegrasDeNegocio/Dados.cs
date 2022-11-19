using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRegistroVeiculo.RegrasDeNegocio
{
    internal class Dados
    {

        private const string ARQUIVO_VEICULOS = "veiculo.csv";
        private const string ARQUIVO_CLIENTES= "cliente.csv";
        private const string ARQUIVO_VENDAS  = "venda.csv";

        private static List<Venda> listaVendas = new List<Venda>();
        private static List<Veiculo> listaVeiculos = new List<Veiculo>();
        private static List<Cliente> listaClientes = new List<Cliente>();

        private static int veiculosLastId { 
            get { 
                return listaVeiculos.Count > 0 ? listaVeiculos.Last().Id : 0;
            }
        }
        private static int clientesLastId
        {
            get
            {
                return listaClientes.Count > 0 ? listaClientes.Last().Id : 0;
            }
        }
        private static int vendasLastId
        {
            get
            {
                return listaVendas.Count > 0 ? listaVendas.Last().Id : 0;
            }
        }

        private static void CarregarClientes()
        {
            listaClientes = BuscarClientes();
        }

        private static void CarregarVeiculos()
        {
            listaVeiculos = BuscarVeiculos();
        }

        private static void CarregarVendas()
        {
            listaVendas = BuscarVendas();
        }

        public static List<Veiculo> BuscarVeiculos()
        {
            var lista = new List<Veiculo>();

            // 1. Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader(ARQUIVO_VEICULOS);

            // 2. Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                // 2.1. Criar a classe para receber os dados do registro
                Veiculo registro = new Veiculo();

                // 2.2. Fazer a leitura do registro e armazenar no vetor
                string[] dados = sr.ReadLine().Split(';');

                // 2.3. Retirar os dados do vetor e inserir no obj veiculo
                registro.Id = Convert.ToInt32(dados[0]);
                registro.Modelo = dados[1];
                registro.Marca = dados[2];
                registro.Placa = dados[3];
                registro.Ano = Convert.ToInt32(dados[4]);
                registro.Valor = Convert.ToDouble(dados[5]);

                // 2.4. Adicionar objeto na lista de Veículos
                lista.Add(registro);
            }

            // 3. Fechar o arquivo
            sr.Close();

            // 4. Retornar a lista
            return lista;
        }

        public static void SalvarVeiculo(Veiculo registro)
        {
            // 1. 
            CarregarVeiculos();
            registro.Id = veiculosLastId + 1;

            // 2. Utilitário para escrever registros
            StreamWriter sw = new StreamWriter(ARQUIVO_VEICULOS, true);

            // 3. Escrever o registro no arquivo
            sw.WriteLine(registro.ToString());

            // 4. Fechar o arquivo
            sw.Close();
        }

        public static List<Cliente> BuscarClientes()
        {
            var lista = new List<Cliente>();

            // 1. Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader(ARQUIVO_CLIENTES);

            // 2. Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                // 2.1. Criar a classe para receber os dados do registro
                Cliente registro = new Cliente();

                // 2.2. Fazer a leitura do registro e armazenar no vetor
                string[] dados = sr.ReadLine().Split(';');

                // 2.3. Retirar os dados do vetor e inserir no obj veiculo
                registro.Id = Convert.ToInt32(dados[0]);
                registro.Cpf = dados[1];
                registro.Nome = dados[2];

                // 2.4. Adicionar objeto na lista de Veículos
                lista.Add(registro);
            }

            // 3. Fechar o arquivo
            sr.Close();

            // 4. Retornar a lista
            return lista;
        }

        public static void SalvarCliente(Cliente registro)
        {
            // 1. 
            CarregarClientes();
            registro.Id = clientesLastId + 1;

            // 2. Utilitário para escrever registros
            StreamWriter sw = new StreamWriter(ARQUIVO_CLIENTES, true);

            // 3. Escrever o registro no arquivo
            sw.WriteLine(registro.ToString());

            // 4. Fechar o arquivo
            sw.Close();
        }

        public static List<Venda> BuscarVendas()
        {
            var lista = new List<Venda>();

            // 1. Criar a classe para leitura do arquivo
            StreamReader sr = new StreamReader(ARQUIVO_VENDAS);

            // 2. Laço para ler os registros do arquivo
            while (!sr.EndOfStream)
            {
                // 2.1. Criar a classe para receber os dados do registro
                Venda registro = new Venda();

                // 2.2. Fazer a leitura do registro e armazenar no vetor
                string[] dados = sr.ReadLine().Split(';');

                // 2.3. Retirar os dados do vetor e inserir no obj veiculo
                registro.Id = Convert.ToInt32(dados[0]);
                registro.DataVenda = Convert.ToDateTime(dados[1]);
                registro.ValorDaVenda = Convert.ToDouble(dados[2]);
                registro.VeiculoId = Convert.ToInt32(dados[3]);
                registro.ClienteId = Convert.ToInt32(dados[4]);

                // 2.4. Adicionar objeto na lista de Veículos
                lista.Add(registro);
            }

            // 3. Fechar o arquivo
            sr.Close();

            // 4. Retornar a lista
            return lista;
        }

        public static void SalvarVenda(Venda registro)
        {
            // 1. 
            CarregarVendas();
            registro.Id = vendasLastId + 1;

            // 2. Utilitário para escrever registros
            StreamWriter sw = new StreamWriter(ARQUIVO_VENDAS, true);

            // 3. Escrever o registro no arquivo
            sw.WriteLine(registro.ToString());

            // 4. Fechar o arquivo
            sw.Close();
        }
    }
}
