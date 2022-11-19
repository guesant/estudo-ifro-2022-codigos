using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using FormCadastroArquivo.RegrasDeNegocio;

namespace FormCadastroArquivo.Contexto
{
    internal class Dados
    {

        //####################################### PARA REGISTRAR E LISTAR PESSOAS #############################################
        public void AddPessoa(Pessoa p)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(2).RowsUsed();
            var plan2 = pasta.Worksheet(2);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas+1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan2.Cell(proximaLinha, 1).Value = proximaLinha;
            plan2.Cell(proximaLinha, 2).Value = p.Cpf;
            plan2.Cell(proximaLinha, 3).Value = p.Nome;

            pasta.Save();

        }

        public List<Pessoa> ListaDePessoas
        {
            get
            {
                List<Pessoa> pessoaList = new List<Pessoa>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(2).RowsUsed();
                foreach (var row in itens)
                {
                    if (row.RowNumber() > 1)
                    {
                        Pessoa p = new Pessoa();
                        p.Id = Convert.ToInt32(row.Cell(1).Value);
                        p.Cpf = row.Cell(2).Value.ToString();
                        p.Nome =  row.Cell(3).Value.ToString();
                        pessoaList.Add(p);
                    }
                }
                return pessoaList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR VEÍCULOS #############################################
        public void AddVeiculo(Veiculos v)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(1).RowsUsed();
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas+1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan1.Cell(proximaLinha, 1).Value = proximaLinha;
            plan1.Cell(proximaLinha, 2).Value = v.Modelo;
            plan1.Cell(proximaLinha, 3).Value = v.Marca;
            plan1.Cell(proximaLinha, 4).Value = v.Placa;
            plan1.Cell(proximaLinha, 5).Value = v.Ano;
            plan1.Cell(proximaLinha, 6).Value = v.Valor;

            pasta.Save();

        }

        public List<Veiculos> ListaDeVeiculos
        {
            get
            {
                List<Veiculos> veiculoList = new List<Veiculos>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(1).RowsUsed();
                foreach (var row in itens)
                {
                    if (row.RowNumber() > 1)
                    {
                        Veiculos v = new Veiculos();
                        v.Id = Convert.ToInt32(row.Cell(1).Value);
                        v.Modelo = row.Cell(2).Value.ToString();
                        v.Marca = row.Cell(3).Value.ToString();
                        v.Placa = row.Cell(4).Value.ToString();
                        v.Ano = Convert.ToInt32(row.Cell(5).Value);
                        v.Valor = Convert.ToDouble(row.Cell(6).Value);
                        veiculoList.Add(v);
                    }
                }
                return veiculoList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR VENDAS #############################################

        public void AddVendas(Venda v)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(3).RowsUsed();
            var plan3 = pasta.Worksheet(3);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan3.Cell(proximaLinha, 1).Value = proximaLinha;
            plan3.Cell(proximaLinha, 2).Value = v.DataVenda;
            plan3.Cell(proximaLinha, 3).Value = v.VeiculoId;
            plan3.Cell(proximaLinha, 4).Value = v.PessoaId;
           

            pasta.Save();

        }

        public List<Venda> ListaDeVendas
        {
            get
            {
                List<Venda> vendaList = new List<Venda>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\RegistrosDeVeiculos.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(3).RowsUsed();
                foreach (var row in itens)
                {
                    if (row.RowNumber() > 1)
                    {
                        Venda v = new Venda();
                        v.Id = Convert.ToInt32(row.Cell(1).Value);
                        v.DataVenda = Convert.ToDateTime(row.Cell(2).Value.ToString());
                        v.VeiculoId = Convert.ToInt32(row.Cell(3).Value);
                        v.PessoaId = Convert.ToInt32(row.Cell(4).Value);
                       
                        vendaList.Add(v);
                    }
                }
                return vendaList;
            }
        }

    }
}
