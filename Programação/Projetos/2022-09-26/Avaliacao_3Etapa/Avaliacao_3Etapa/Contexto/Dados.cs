using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaliacao_3Etapa.RegrasDeNegocio;
using ClosedXML.Excel;

namespace Avaliacao_3Etapa.Contexto
{
    internal class Dados
    {
        public void AddMorador(Morador morador)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(1).RowsUsed();
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan1.Cell(proximaLinha, 1).Value = proximaLinha;
            plan1.Cell(proximaLinha, 2).Value = morador.Nome;
            plan1.Cell(proximaLinha, 3).Value = morador.Cpf;
            plan1.Cell(proximaLinha, 4).Value = morador.Telefone;
            plan1.Cell(proximaLinha, 5).Value = morador.Rua;
            plan1.Cell(proximaLinha, 6).Value = morador.NumeroCasa;

            pasta.Save();

        }

        public List<Morador> ListarMoradores
        {
            get
            {
                List<Morador> pessoaList = new List<Morador>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(1).RowsUsed();
                foreach (var row in itens)
                {
                    if (row.RowNumber() > 1)
                    {
                        Morador cliente = new Morador();
                        cliente.Id = Convert.ToInt32(row.Cell(1).Value);
                        cliente.Nome = row.Cell(2).Value.ToString();
                        cliente.Cpf = row.Cell(3).Value.ToString();
                        cliente.Telefone = row.Cell(4).Value.ToString();
                        cliente.Rua = row.Cell(5).Value.ToString();
                        cliente.NumeroCasa = Convert.ToInt32(row.Cell(6).Value);
                        pessoaList.Add(cliente);
                    }
                }
                return pessoaList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR QUARTOS #############################################
        public void AddMulta(Infracao q)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(2).RowsUsed();
            var plan2 = pasta.Worksheet(2);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan2.Cell(proximaLinha, 1).Value = proximaLinha;
            plan2.Cell(proximaLinha, 2).Value = q.Tipo;
            plan2.Cell(proximaLinha, 3).Value = q.ValorMulta;

            pasta.Save();

        }

        public List<Infracao> ListarInfracoes
        {
            get
            {
                List<Infracao> quartoList = new List<Infracao>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(2).RowsUsed();
                foreach (var row in itens)
                {
                    if (row.RowNumber() > 1)
                    {
                        Infracao q = new Infracao();
                        q.Id = Convert.ToInt32(row.Cell(1).Value);
                        q.Tipo = row.Cell(2).Value.ToString();
                        q.ValorMulta = Convert.ToDouble(row.Cell(3).Value);

                        quartoList.Add(q);
                    }
                }
                return quartoList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR VENDAS #############################################

        public void AddOcorrencia(Ocorrencia h)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(3).RowsUsed();
            var plan3 = pasta.Worksheet(3);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan3.Cell(proximaLinha, 1).Value = proximaLinha;
            plan3.Cell(proximaLinha, 2).Value = h.DataInicio;
            plan3.Cell(proximaLinha, 3).Value = h.DataFim;
            plan3.Cell(proximaLinha, 4).Value = h.IdMorador;
            plan3.Cell(proximaLinha, 5).Value = h.IdInfracao;


            pasta.Save();

        }

        public List<Relatorio> RelatorioOcorrencia
        {
            get
            {
                List<Relatorio> listaHospedagem = new List<Relatorio>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(4).RowsUsed();
                foreach (var row in itens)
                {                  
                    if (row.RowNumber() > 1)
                    {
                        var idTxt = row.Cell(1).Value;
                        
                        if (idTxt == "" || idTxt == null)
                        {
                            break;
                        }

                        Relatorio h = new Relatorio();
                        h.Id = Convert.ToInt32(row.Cell(1).Value);
                        h.DataInicio = Convert.ToDateTime(row.Cell(2).Value.ToString());
                        h.DataFim = Convert.ToDateTime(row.Cell(3).Value.ToString());
                        h.IdMorador = Convert.ToInt32(row.Cell(4).Value);
                        h.IdInfracao = Convert.ToInt32(row.Cell(5).Value);
                        h.Nome = row.Cell(6).Value.ToString();
                        h.Cpf = row.Cell(7).Value.ToString();
                        h.Tipo = row.Cell(8).Value.ToString();
                        h.ValorMulta = Convert.ToDouble(row.Cell(9).Value);
                        h.ValorAPagar = Convert.ToDouble(row.Cell(10).Value);

                        listaHospedagem.Add(h);
                    }
                }
                return listaHospedagem;
            }
        }

        public void AddLog(string log, DateTime data)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\Dados.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(5).RowsUsed();
            var plan3 = pasta.Worksheet(5);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan3.Cell(proximaLinha, 1).Value = proximaLinha;
            plan3.Cell(proximaLinha, 2).Value = log;
            plan3.Cell(proximaLinha, 3).Value = data;
            pasta.Save();

        }
    }
}
