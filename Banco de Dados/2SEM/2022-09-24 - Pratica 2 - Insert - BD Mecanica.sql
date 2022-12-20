/*
Scrit do BD_Mecanica Carro ZERO
 */
 #SEU NOME: Gabriel Rodrigues Antunes

drop database if exists BD_mecanica_gabriel_rodrigues_antunes;

create database BD_mecanica_gabriel_rodrigues_antunes;
use BD_mecanica_gabriel_rodrigues_antunes;

CREATE TABLE Cliente (
    id_cli INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome_cli VARCHAR(200) NOT NULL,
    cpf_cli VARCHAR(50) NOT NULL,
    rg_cli VARCHAR(50) NOT NULL,
    telefone_cli VARCHAR(50) NOT NULL,
    endereco_cli VARCHAR(200) NOT NULL,
    email_cli VARCHAR(100),
    sexo_cli VARCHAR(50),
    renda_cli DOUBLE NOT NULL,
    data_Nasc_cli DATE NOT NULL,
    status_cli VARCHAR(100)
);
INSERT INTO Cliente (id_cli, nome_cli, cpf_cli, rg_cli, telefone_cli, endereco_cli, email_cli, sexo_cli, renda_cli, data_Nasc_cli, status_cli) VALUES (null, 'Calebe Luan Geraldo Gonçalves', '552.647.315-51', '25.123.399-6', '(84) 98731-1369', 'Avenida Wilson Rosado, 455. Aeroporto. Mossoró - RN. Brasil.', 'calebe-goncalves98@lavabit.com', 'Masculino', 3421.27, '1963-01-03', null);
INSERT INTO Cliente (id_cli, nome_cli, cpf_cli, rg_cli, telefone_cli, endereco_cli, email_cli, sexo_cli, renda_cli, data_Nasc_cli, status_cli) VALUES (null, 'Stella Alana da Conceição', '720.032.463-98', '25.861.868-1', '(63) 98741-2841', 'Avenida Tocantins, 765. Loteamento Araguaína Sul. Araguaína - TO. Brasil.', 'stella_daconceicao@poligerma.com.br', 'Feminino', 3331.87, '1988-02-25', null);
INSERT INTO Cliente (id_cli, nome_cli, cpf_cli, rg_cli, telefone_cli, endereco_cli, email_cli, sexo_cli, renda_cli, data_Nasc_cli, status_cli) VALUES (null, 'Joana Vanessa Carolina Gomes', '983.536.187-88', '32.304.609-5', '(21) 98394-6698', 'Rua Luiz Batista Lópes, 186. Iucas. Teresópolis - RJ. Brasil.', 'joanavanessagomes@qmagico.com.br', 'Feminino', 3423.58, '1949-06-16', null);
INSERT INTO Cliente (id_cli, nome_cli, cpf_cli, rg_cli, telefone_cli, endereco_cli, email_cli, sexo_cli, renda_cli, data_Nasc_cli, status_cli) VALUES (null, 'Luan Ian Kaique Souza', '218.680.816-13', '11.912.457-9', '(84) 99899-0090', 'Rua Cândido Martins dos Santos, 483. Rosa dos Ventos. Parnamirim - RN. Brasil.', 'luan_ian_souza@a.com', 'Masculino', 4187.52, '1947-01-11', null);
INSERT INTO Cliente (id_cli, nome_cli, cpf_cli, rg_cli, telefone_cli, endereco_cli, email_cli, sexo_cli, renda_cli, data_Nasc_cli, status_cli) VALUES (null, 'Edson André Nascimento', '539.423.658-55', '38.178.381-9', '(27) 99945-1105', 'Rua Usiminas, 900. Serramar. Serra - ES. Brasil.', 'edson-nascimento97@redealumni.com', 'Masculino', 1365.04, '1954-05-20', null);
select * from Cliente;

create table Funcionario (
id_func int primary key auto_increment not null,
nome_func varchar(200) not null,
funcao_func varchar(100) not null,
cpf_func varchar(50) not null,
rg_func varchar(50) not null,
telefone_func varchar(50),
endereco_func varchar (200),
email_func varchar (200),
sexo_func varchar (20),
salario_func double not null
);
INSERT INTO Funcionario (id_func, nome_func, funcao_func, cpf_func, rg_func, salario_func) VALUES (null, 'Cláudia Stefany Souza', 'Gerente', '876.853.459-00', '17.181.501-4', 1616.07);
INSERT INTO Funcionario (id_func, nome_func, funcao_func, cpf_func, rg_func, salario_func) VALUES (null, 'Enrico Gael Miguel Mendes', 'Atendente', '343.999.550-07', '18.279.926-8', 1783.48);
INSERT INTO Funcionario (id_func, nome_func, funcao_func, cpf_func, rg_func, salario_func) VALUES (null, 'Nair Luna Silva', 'Caixa', '050.686.389-19', '45.425.244-4', 2211.95);
INSERT INTO Funcionario (id_func, nome_func, funcao_func, cpf_func, rg_func, salario_func) VALUES (null, 'Ester Kamilly Ferreira', 'Vendedor', '632.345.984-10', '16.175.800-9', 2811.17);
INSERT INTO Funcionario (id_func, nome_func, funcao_func, cpf_func, rg_func, salario_func) VALUES (null, 'Igor Geraldo da Mota', 'Mecânico', '651.873.646-18', '50.713.029-7', 3185.61);
select * from Funcionario;

create table Servico (
id_serv int primary key auto_increment not null,
descricao_serv varchar(300) not null,
valor_serv double not null,
tempo_serv time
);
INSERT INTO Servico VALUES (null, 'Revisão', 100, '01:00');
INSERT INTO Servico VALUES (null, 'Limpeza Geral', 300, '00:30');
INSERT INTO Servico VALUES (null, 'Pintura', 500, '03:00');
INSERT INTO Servico VALUES (null, 'Trocar Escapamento', 400, '00:50');
INSERT INTO Servico VALUES (null, 'Limpeza de Filtro Ar-Condicionado', 200, '00:30');
select * from Servico;

create table Fornecedor (
id_forn int primary key auto_increment not null,
razao_forn varchar(150) not null,
nome_forn varchar(150) not null,
cnpj_forn varchar(50) not null,
endereco_forn varchar(300) not null,
telefone_forn varchar(50) not null
);
INSERT INTO Fornecedor VALUES (null, 'Tânia e Benício Adega Ltda', 'TB Peças e Acessórios', '92.673.137/0001-25', 'Rua Olímpio Correia da Silva, 271. Vila Iti. Presidente Prudente - SP. Brasil.', '(69) 3574-8999');
INSERT INTO Fornecedor VALUES (null, 'Tatiane e Vitor Restaurante Ltda', 'Restaurante Come Bem', '00.813.301/0001-34', 'Rua Vinte e Dois, 885. João Crevelaro. Birigüi - SP. Brasil.', '(69) 3988-9042');
INSERT INTO Fornecedor VALUES (null, 'Heloisa e Kaique Marketing ME', 'Sempre Conectado', '16.516.165/0001-50', 'Rua Rio Negro, 584. Jardim dos Migrantes. Ji-Paraná - RO. Brasil.', '(69) 98543-9121');
INSERT INTO Fornecedor VALUES (null, 'Malu e Tatiane Filmagens ME', 'TaLu Films', '66.234.571/0001-07', 'Rua Voluntários da Pátria, 727. Socialista. Porto Velho - RO. Brasil.', '(69) 99918-2256');
INSERT INTO Fornecedor VALUES (null, 'Yuri e Raquel Contábil ME', 'Yuri e Raquel Contabilidade', '76.066.281/0001-47', 'Rua Vera Lúcia, 203. Floresta. Porto Velho - RO. Brasil.', '(69) 3551-5332');
select * from Fornecedor;

create table Produto ( 
id_prod int primary key auto_increment not null,
nome_prod varchar(300) not null,
marca_prod varchar(150) not null,
estoque_prod int not null,
valor_prod double not null,
tamanho_prod varchar(5) not null,
tipo_prod varchar(50) not null
);
INSERT INTO Produto (id_prod, nome_prod, marca_prod, estoque_prod, valor_prod, tamanho_prod, tipo_prod) VALUES (null, 'Trena Amarela de 5M', 'STARRETT', 259, 26.9, '10 cm', 'Ferramentas');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, estoque_prod, valor_prod, tamanho_prod, tipo_prod) VALUES (null, 'Nível Torpedo Magnético', 'STARRETT', 123, 62.9, '23 cm', 'Ferramentas');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, estoque_prod, valor_prod, tamanho_prod, tipo_prod) VALUES (null, 'Alicate Universal 8 Pol. Profissional', 'GEDORE', 500, 48.79, '13cm', 'Ferramentas');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, estoque_prod, valor_prod, tamanho_prod, tipo_prod) VALUES (null, 'Óleo Lubrificante Mobil Super 20w50 Mineral', 'Mobil Super ', 30, 32.09, '30 cm', 'Lubrificantes');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, estoque_prod, valor_prod, tamanho_prod, tipo_prod) VALUES (null, 'Pneu Kelly Edge Touring 165/70R13 83 T', 'Kelly', 20, 331.10, '77cm', 'Pneus');
select * from Produto;

create table Compra (
id_comp int primary key auto_increment not null,
data_comp date not null,
valor_comp double not null,
quant_itens_comp int,
forma_pagamento_comp varchar(50) not null,
id_forn_fk int not null,
foreign key (id_forn_fk) references Fornecedor (id_forn)
);
INSERT INTO Compra VALUES (null, '2022-09-20', 100.99, 1, 'Dinheiro 1x', 1);
INSERT INTO Compra VALUES (null, '2022-09-21', 120.99, 4, 'Cartão 2x', 1);
INSERT INTO Compra VALUES (null, '2022-09-22', 400.99, 130, 'Cheque', 1);
INSERT INTO Compra VALUES (null, '2022-09-23', 60.99, 35, 'Pix', 1);
INSERT INTO Compra VALUES (null, '2022-09-24', 24.99, 96, 'Depósito Bancário', 1);
select * from Compra;

create table Despesa (
id_desp int primary key auto_increment not null,
descricao_desp varchar(200),
valor_desp double not null,
data_desp date not null,
forma_pagamento_desp varchar(100) not null
);
INSERT INTO Despesa VALUES (null, 'Conta de Luz', 400.99, '2022-09-20', 'Dinheiro');
INSERT INTO Despesa VALUES (null, 'Reposição de Estoque', 100.99, '2022-09-21', 'Dinheiro');
INSERT INTO Despesa VALUES (null, 'Conta de Água', 50.99, '2022-09-22', 'Dinheiro');
INSERT INTO Despesa VALUES (null, 'Reposição de Estoque', 5000.99, '2022-09-23', 'Dinheiro');
INSERT INTO Despesa VALUES (null, 'Conta de Internet', 120.99, '2022-09-24', 'Dinheiro');
select * from Despesa;

create table Caixa(
id_cai int primary key auto_increment not null,
data_cai date not null,
saldo_inicial_cai double not null,
total_recebimento_cai double not null,
total_pagamento_cai double not null,
saldo_final_cai double not null,
status_cai varchar (300),
id_func_fk int not null,
foreign key (id_func_fk) references Funcionario (id_func)
);
INSERT INTO Caixa VALUES (null, '2022-09-20', 120.25, 300, 200, 220.25, 'Aberto', 1);
INSERT INTO Caixa VALUES (null, '2022-09-21', 0, 300, 0, 300, 'Fechado', 2);
INSERT INTO Caixa VALUES (null, '2022-09-22', 500, 0, 200, 300, 'Aberto', 3);
INSERT INTO Caixa VALUES (null, '2022-09-23', 80, 100, 100, 80, 'Fechado', 4);
INSERT INTO Caixa VALUES (null, '2022-09-24', 220.75, 100, 200, 120.75, 'Aberto', 5);
select * from Caixa;

create table Pagamento (
id_pag int primary key auto_increment not null,
valor_pag double not null,
parcela_pag double not null,
data_pag date not null,
forma_pag varchar(50) not null,
status_pag varchar (300),
id_comp_fk int,
id_cai_fk int not null,
id_desp_fk int,
foreign key (id_comp_fk) references Compra (id_comp),
foreign key (id_cai_fk) references Caixa (id_cai),
foreign key (id_desp_fk) references Despesa (id_desp)
);
INSERT INTO Pagamento VALUES (null, 100, 1, '2022-09-24', 'Dinheiro', 'Pago', 1, 1, 1);
INSERT INTO Pagamento VALUES (null, 200, 2, '2022-09-23', 'Cartão', 'A Pagar', 2, 2, 2);
INSERT INTO Pagamento VALUES (null, 300, 3, '2022-09-22', 'Depósito Bancário', 'Pago', 3, 3, 3);
INSERT INTO Pagamento VALUES (null, 400, 4, '2022-09-21', 'Pix', 'A Pagar', 4, 4, 4);
INSERT INTO Pagamento VALUES (null, 500, 5, '2022-09-20', 'Dinheiro', 'Pago', 5, 5, 5);
select * from Pagamento;

create table Venda (
id_vend int primary key auto_increment not null,
valor_vend double not null,
data_vend date not null,
hora_vend varchar(20),
forma_pag_vend varchar(100),
id_cli_fk int not null,
id_func_fk int not null,
foreign key (id_cli_fk) references Cliente (id_cli),
foreign key (id_func_fk) references Funcionario (id_func)
);
INSERT INTO Venda VALUES (null, 550, '2022-09-22', '10:55', 'Dinheiro', 1, 1);
INSERT INTO Venda VALUES (null, 550, '2022-09-21', '08:15', 'Cartão 2x', 2, 2);
INSERT INTO Venda VALUES (null, 550, '2022-09-23', '14:28', 'Dinheiro', 3, 3);
INSERT INTO Venda VALUES (null, 550, '2022-09-24', '19:12', 'Cartão 4x', 4, 4);
INSERT INTO Venda VALUES (null, 550, '2022-09-20', '07:21', 'Dinheiro', 5, 5);
select * from Venda;

create table Recebimento (
id_rec int primary key auto_increment not null,
valor_rec double not null,
parcela_rec int not null,
forma_rec varchar(100) not null,
data_vencimento_rec date not null,
status_rec varchar (300),
id_cai_fk int not null,
id_vend_fk int not null,
foreign key (id_cai_fk) references Caixa (id_cai),
foreign key (id_vend_fk) references Venda(id_vend)
);
INSERT INTO Recebimento VALUES (null, 500.98, 5, 'Dinheiro', '2022-09-20', 'Recebido', 1, 5);
INSERT INTO Recebimento VALUES (null, 600.98, 4, 'Pix', '2022-09-21', 'A Receber', 2, 4);
INSERT INTO Recebimento VALUES (null, 700.98, 3, 'Cartão', '2022-09-22', 'Recebido', 3, 3);
INSERT INTO Recebimento VALUES (null, 800.98, 2, 'Dinheiro', '2022-09-23', 'A Receber', 4, 2);
INSERT INTO Recebimento VALUES (null, 900.98, 1, 'Cartão', '2022-09-24', 'A Receber', 5, 1);
select * from Recebimento;

create table Venda_Serv(
id_vser int primary key auto_increment not null,
id_vend_fk int not null,
id_serv_fk int not null,
quant_vser int,
foreign key (id_vend_fk) references Venda (id_vend),
foreign key (id_serv_fk) references Servico (id_serv)
);
INSERT INTO Venda_Serv VALUES (null, 1, 5, 1);
INSERT INTO Venda_Serv VALUES (null, 2, 4, 2);
INSERT INTO Venda_Serv VALUES (null, 3, 3, 1);
INSERT INTO Venda_Serv VALUES (null, 4, 2, 3);
INSERT INTO Venda_Serv VALUES (null, 5, 1, 1);
select * from Venda_Serv;

create table Venda_Prod(
id_vpro int primary key auto_increment not null,
id_vend_fk int not null,
id_prod_fk int not null,
quant_vpro int,
foreign key (id_vend_fk) references Venda (id_vend),
foreign key (id_prod_fk) references Produto (id_prod)
);
INSERT INTO Venda_Prod VALUES (null, 5, 1, 2);
INSERT INTO Venda_Prod VALUES (null, 4, 2, 1);
INSERT INTO Venda_Prod VALUES (null, 3, 3, 4);
INSERT INTO Venda_Prod VALUES (null, 2, 4, 1);
INSERT INTO Venda_Prod VALUES (null, 1, 5, 6);
select * from Venda_Prod;

create table Compra_Prod(
id_cprod int primary key auto_increment not null,
id_comp_fk int not null,
id_prod_fk int not null,
quant_cprod int,
valor_cprod float,
foreign key (id_comp_fk) references Compra (id_comp),
foreign key (id_prod_fk) references Produto (id_prod)
);
INSERT INTO Compra_Prod VALUES (null, 1, 5, 120, 240.99);
INSERT INTO Compra_Prod VALUES (null, 2, 3, 452, 140.99);
INSERT INTO Compra_Prod VALUES (null, 4, 5, 10, 440.99);
INSERT INTO Compra_Prod VALUES (null, 3, 2, 100, 1140.99);
INSERT INTO Compra_Prod VALUES (null, 5, 1, 20, 640.99);
select * from Compra_Prod;

create table Funcionario_Servico (
id_fserv int not null primary key auto_increment,
id_func_fk int not null,
id_serv_fk int not null,
foreign key (id_func_fk) references Funcionario (id_func),
foreign key (id_serv_fk) references Servico (id_serv)
);
INSERT INTO Funcionario_Servico VALUES (null, 5, 1);
INSERT INTO Funcionario_Servico VALUES (null, 4, 2);
INSERT INTO Funcionario_Servico VALUES (null, 3, 3);
INSERT INTO Funcionario_Servico VALUES (null, 2, 4);
INSERT INTO Funcionario_Servico VALUES (null, 1, 5);
select * from Funcionario_Servico;