using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using AppHotel.RegrasDeNegocio;

namespace AppHotel.Contexto
{
    internal class Dados
    {//começo da classe

        //####################################### PARA REGISTRAR E LISTAR CLIENTES #############################################
        public void AddCliente(Cliente cliente)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(1).RowsUsed();
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan1.Cell(proximaLinha, 1).Value = proximaLinha;
            plan1.Cell(proximaLinha, 2).Value = cliente.Cpf;
            plan1.Cell(proximaLinha, 3).Value = cliente.Nome;
            plan1.Cell(proximaLinha, 4).Value = cliente.Telefone;
            plan1.Cell(proximaLinha,5).Value = cliente.Email;

            pasta.Save();

        }

        public List<Cliente> ListarClientes
        {
            get
            {
                List<Cliente> pessoaList = new List<Cliente>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(1).RowsUsed();


                foreach (var row in itens)
                {
                    if (row.Cell(1).Value == null || row.Cell(1).Value == "")
                    {
                        break;
                    }

                    if (row.RowNumber() > 1)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(row.Cell(1).Value);
                        cliente.Cpf = row.Cell(2).Value.ToString();
                        cliente.Nome = row.Cell(3).Value.ToString();
                        cliente.Telefone = row.Cell(4).Value.ToString();
                        cliente.Email = row.Cell(5).Value.ToString();
                        pessoaList.Add(cliente);
                    }
                }
                return pessoaList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR QUARTOS #############################################
        public void AddQuarto(Quarto q)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(2).RowsUsed();
            var plan2 = pasta.Worksheet(2);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan2.Cell(proximaLinha, 1).Value = proximaLinha;
            plan2.Cell(proximaLinha, 2).Value = q.Tipo;
            plan2.Cell(proximaLinha, 3).Value = q.ValorDiaria;
          
            pasta.Save();

        }

        public List<Quarto> ListarQuartos
        {
            get
            {
                List<Quarto> quartoList = new List<Quarto>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(2).RowsUsed();

               
                foreach (var row in itens)
                {
                    if (row.Cell(1).Value == null || row.Cell(1).Value == "")
                    {
                        break;
                    }


                    if (row.RowNumber() > 1)
                    {
                        Quarto q = new Quarto();
                        q.Id = Convert.ToInt32(row.Cell(1).Value);
                        q.Tipo = row.Cell(2).Value.ToString();
                        q.ValorDiaria = Convert.ToDouble(row.Cell(3).Value);

                        quartoList.Add(q);
                    }
                }
                return quartoList;
            }
        }
        //##################################################################################################################

        //####################################### PARA REGISTRAR E LISTAR VENDAS #############################################

        public void AddHospedagem(Hospedagem h)
        {
            string caminho = System.IO.Directory.GetCurrentDirectory();
            caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
            var pasta = new XLWorkbook(caminho);
            var itens = pasta.Worksheet(3).RowsUsed();
            var plan3 = pasta.Worksheet(3);
            int qtdLinhas = itens.Count();
            int proximaLinha = qtdLinhas + 1;
            if (qtdLinhas == 0) proximaLinha = 1;
            plan3.Cell(proximaLinha, 1).Value = proximaLinha;
            plan3.Cell(proximaLinha, 2).Value = h.DataEntrada;
            plan3.Cell(proximaLinha, 3).Value = h.DataSaida;
            plan3.Cell(proximaLinha, 4).Value = h.IdCliente;
            plan3.Cell(proximaLinha, 5).Value = h.IdQuarto;


            pasta.Save();

        }

        public List<ConsultaHospedagem> ListarHospedagem
        {
            get
            {
                List<ConsultaHospedagem> listaHospedagem = new List<ConsultaHospedagem>();
                string caminho = System.IO.Directory.GetCurrentDirectory();
                caminho = caminho.Replace("\\bin\\Debug", "\\Registros\\bdHotel.xlsx");
                var pasta = new XLWorkbook(caminho);
                var itens = pasta.Worksheet(4).RowsUsed();
                foreach (var row in itens)
                {
                    if(row.Cell(1).Value == null || row.Cell(1).Value == "")
                    {
                        break;
                    }

                    if (row.RowNumber() > 1)
                    {
                        ConsultaHospedagem h = new ConsultaHospedagem();
                        h.Id = Convert.ToInt32(row.Cell(1).Value);
                        h.DataEntrada = Convert.ToDateTime(row.Cell(2).Value.ToString());
                        h.DataSaida = Convert.ToDateTime(row.Cell(3).Value.ToString());
                        h.IdCliente = Convert.ToInt32(row.Cell(4).Value);
                        h.IdQuarto = Convert.ToInt32(row.Cell(5).Value);
                        h.Cpf = row.Cell(6).Value.ToString();
                        h.Nome = row.Cell(7).Value.ToString();
                        h.Tipo = row.Cell(8).Value.ToString();
                        h.ValorDiaria = Convert.ToDouble(row.Cell(9).Value);
                        h.ValorAPagar = Convert.ToDouble(row.Cell(10).Value);

                        listaHospedagem.Add(h);
                    }
                }
                return listaHospedagem;
            }
        }

    }//fim da classe
}
