/* 
Scrit do BD_Mecanica Carro ZERO
 */

drop database if exists BD_mecanica;
create database BD_mecanica;
use BD_mecanica;

create table Cliente(
cod_cli int primary key auto_increment not null,
nome_cli varchar(200) not null,
cpf_cli varchar(50) not null,
rg_cli varchar(50) not null,
telefone_cli varchar(50) not null,
endereco_cli varchar(200) not null,
email_cli varchar(100),
sexo_cli varchar(50),
renda_cli double not null,
data_Nasc_cli date not null,
status_cli varchar (100)
);

create table Funcionario(
cod_func int primary key auto_increment not null,
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

create table Servico(
cod_serv int primary key auto_increment not null,
descricao_serv varchar(300) not null,
valor_serv double not null,
tempo_serv time
);

create table Fornecedor(
cod_forn int primary key auto_increment not null,
razao_forn varchar(150) not null,
nome_forn varchar(150) not null,
cnpj_forn varchar(50) not null,
endereco_forn varchar(300) not null,
telefone_forn varchar(50) not null
);

create table Produto(
cod_prod int primary key auto_increment not null,
nome_prod varchar(300) not null,
marca_prod varchar(150) not null,
estoque_prod int not null,
valor_prod double not null,
tamanho_prod varchar(5) not null,
tipo_prod varchar(50) not null
);

create table Compra(
cod_comp int primary key auto_increment not null,
data_comp date not null,
valor_comp double not null,
quant_itens_comp int,
forma_Pag_comp varchar(50) not null,
cod_forn_fk int not null,
foreign key (cod_forn_fk) references Fornecedor(cod_forn)
);

create table Despesa(
cod_desp int primary key auto_increment not null,
descricao_desp varchar(200),
valor_desp double not null,
data_desp date not null,
forma_pag_desp varchar(100) not null
);

create table Caixa(
cod_cai int primary key auto_increment not null,
data_cai date not null,
saldo_inicial_cai double not null,
total_recebimento_cai double not null,
total_pagamento_cai double not null,
saldo_final_cai double not null,
cod_func_fk int not null,
foreign key (cod_func_fk) references Funcionario (cod_func)
);

create table Pagamento(
cod_pag int primary key auto_increment not null,
valor_pag double not null,
parcela_pag double not null,
data_pag date not null,
forma_pag varchar(50) not null,
cod_comp_fk int,
cod_cai_fk int not null,
cod_desp_fk int,
foreign key (cod_comp_fk) references Compra (cod_comp),
foreign key (cod_cai_fk) references Caixa (cod_cai),
foreign key (cod_desp_fk) references Despesa (cod_desp)
);

create table Venda (
cod_vend int primary key auto_increment not null,
valor_vend double not null,
data_vend date not null,
hora_vend varchar(20),
forma_pag_vend varchar(100),
cod_cli_fk int not null,
cod_func_fk int not null,
foreign key (cod_cli_fk) references Cliente (cod_cli),
foreign key (cod_func_fk) references Funcionario (cod_func)
);

create table Recebimento (
cod_rec int primary key auto_increment not null,
valor_rec double not null,
parcela_rec int not null,
forma_rec varchar(100) not null,
data_vencimento_rec date not null,
cod_cai_fk int not null,
cod_vend_fk int not null,
foreign key (cod_cai_fk) references Caixa (cod_cai),
foreign key (cod_vend_fk) references Venda(cod_vend)
);

create table Venda_Serv(
cod_vser int primary key auto_increment not null,
cod_vend_fk int not null,
cod_serv_fk int not null,
quant_vser int,
foreign key (cod_vend_fk) references Venda (cod_vend),
foreign key (cod_serv_fk) references Servico (cod_serv)
);

create table Venda_Prod(
cod_vpro int primary key auto_increment not null,
cod_vend_fk int not null,
cod_prod_fk int not null,
quant_vpro int,
foreign key (cod_vend_fk) references Venda (cod_vend),
foreign key (cod_prod_fk) references Produto (cod_prod)
);

create table Compra_Prod(
cod_cprod int primary key auto_increment not null,
cod_comp_fk int not null,
cod_prod_fk int not null,
quant_cprod int,
valor_cprod float,
foreign key (cod_comp_fk) references Compra (cod_comp),
foreign key (cod_prod_fk) references Produto (cod_prod)
);

create table Funcionario_Servico (
cod_fserv int not null primary key auto_increment,
cod_func_fk int not null,
cod_serv_fk int not null,
foreign key (cod_func_fk) references Funcionario (cod_func),
foreign key (cod_serv_fk) references Servico (cod_serv)
);

/*INSERTS*/

insert into Cliente values
(null, 'João da Silva', '259.658.325-69', '1616565', '5454 4545', 'Rua X', 'joao@gmail.com', 'Masculino', 9000, '1980-12-01', null),
(null, 'Reginaldo Marques', '658.698.588-58', '1616565', '5454 4545', 'Rua Y', 'reginaldo@gmail.com', 'Masculino', 1200, '1979-10-20', null),
(null, 'Lucas dos Santos', '159.589.699-85', '1616565', '5454 4545', 'Rua Y', 'lucasS@gmail.com', 'Masculino', 900, '1990-11-02', null),
(null, 'Senor Abravanel', '478.698.582-688', '1616565', '5454 4545', 'Rua D', 'senor@gmail.com', 'Masculino', 1300, '1999-12-01', null),
(null, 'Roque Junior', '589.685.656-78', '1616565', '5454 4545', 'Rua X', 'roque@gmail.com', 'Masculino', 5800, '1975-11-02', null),
(null, 'Oscar Schimidt', '458.658.659-58', '1616565', '5454 4545', 'Rua D', 'oscar@gmail.com', 'Masculino', 2600, '1970-05-26', null),
(null, 'Fausto Silva', '458.693.215-00', '1616565', '5454 4545', 'Rua X', 'faustao@gmail.com', 'Masculino', 1200, '1997-06-01', null),
(null, 'Jô Soares', '159.951.357-22', '1616565', '5454 4545', 'Rua C', 'josoares@gmail.com', 'Masculino', 3000, '1989-04-16', null),
(null, 'Diego Armando', '154.982.369-58', '1616565', '5454 4545', 'Rua C', 'maradona@gmail.com', 'Masculino', 10000, '1974-02-27', null),
(null, 'Carlos Alberto', '159.654.258-87', '1616565', '5454 4545', 'Rua B', 'carlosalberto@gmail.com', 'Masculino', 8800, '1964-06-30', null),
(null, 'Ronald Golias', '565.656.655-56', '1616565', '5454 4545', 'Rua Z', 'ronald@gmail.com', 'Masculino', 900, '1980-12-02', null),
(null, 'Fernando Alvarenga', '466.122.321-78', '1616565', '5454 4545', 'Rua Y', 'fernando@gmail.com', 'Masculino', 800, '1969-12-01', null),
(null, 'Clarice Lispector', '568.125.244-58', '1616565', '5454 4545', 'Rua X', 'clarice@gmail.com', 'Feminino', 1500, '1974-12-01', null),
(null, 'Carlos Drumond', '797.565.589-78', '1616565', '5454 4545', 'Rua X', 'carlosD@gmail.com', 'Masculino', 2300, '1998-12-01', null),
(null, 'Elis Regina', '252.362.256-69', '1616565', '5454 4545', 'Rua B', 'ElisR@gmail.com', 'Feminino', 5800, '1960-12-01', null),
(null, 'Hebe Camargo', '798.696.454-85', '1616565', '5454 4545', 'Rua A', 'hebe@gmail.com', 'Feminino', 4500, '1997-12-01', null),
(null, 'Hortência Marcari', '798.258.696-58', '1616565', '5454 4545', 'Rua Y', 'hortencia@gmail.com', 'Feminino', 800, '1995-12-01', null),
(null, 'Marta da Silva', '568.596.658-98', '1616565', '5454 4545', 'Rua X', 'marta@gmail.com', 'Feminino', 5000, '1982-12-01', null),
(null, 'Fernanda Montenegro', '978.547.566-89', '1616565', '5454 4545', 'Rua Z', 'fernanda@gmail.com', 'Feminino', 1200, '1994-12-01', null),
(null, 'Galvão Bueno', '444.444.444-44', '1616565', '5454 4545', 'Rua Y', 'galvao@gmail.com', 'Masculino', 2500, '1980-10-09', null);

insert into Funcionario values
(null, 'Flávio Fernandes', 'Vendedor', '252.256.696-89', '1256987', '5656-6598', 'Rua A', 'flavio@gmail.com', 'Masculino', 2800),
(null, 'Roberto Silva', 'Caixa', '989.589.596-78', '5656562', '8989-9958', 'Rua B', 'Roberto@hotmail.com', 'Masculino', 1800),
(null, 'Miriam Cruz', 'Vendedor', '159.951.357-58', '565656', '5665-5555', 'Rua XX', 'mirian@gmail.com', 'Feminino', 3800),
(null, 'Cláudio Borges', 'Zelador', '565.654.585-55', '158959', '6565-6666', 'Rua MM', 'claudio@gmail.com', 'Masculino', 900),
(null, 'Gina Braga', 'Gerente', '123.321.654-58', '2323265', '6565-5588', 'Rua Cz', 'Gina@gmail.com', 'Feminino', 4000),
(null, 'Rogério Marques', 'Mecânico', '655.555.889-98', '555656', '5656-9999','Rua AAA', 'roge@gmail.com', 'Masculino',  5800);

insert into Servico values
(null, 'Trocar óleo', 20.00, '00:10:00'),
(null, 'Trocar freio', 70.50, '00:30:00'),
(null, 'Consertar embreagem', 100.00, '01:00:00'),
(null, 'Consertar direção', 50.00, '00:30:00'),
(null, 'Trocar óleo', 25.00, '00:10:00'),
(null, 'Consertar motor', 2500.00, '03:00:00'),
(null, 'Consertar freio', 60.50, '00:45:00'),
(null, 'Trocar embreagem', 88.00, '00:50:00'),
(null, 'Trocar óleo', 25.00, '00:15:00'),
(null, 'Trocar rodas', 250.00, '01:00:00');

insert into Fornecedor values
(null, 'Empresa Pemaza LTDA', 'Pemaza Auto Peças', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Rondobras LTDA', 'Rondobras', '56565989', 'Rua Boa', '5656-9898'),
(null, 'VW Ltda', 'Vw', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Boa Ltda.', 'Empresa Boa', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Fera Ltda.', 'Empresa Fera', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Massa Ltda.', 'Empresa Massa', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Loka Ltda.', 'Empresa Loka', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Legal Ltda.', 'Empresa Legal', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Bacana Ltda.', 'Empresa Bacana', '56565989', 'Rua Boa', '5656-9898'),
(null, 'Empresa Ninja Ltda.', 'Empresa Ninja', '56565989', 'Rua Boa', '5656-9898');

insert into Produto values
(null, 'Roda aro 14', 'Yokohama', 20, 120, '16', 'Roda'),
(null, 'Amortecedor do Celta 2013', 'Marca Boa', 20, 200, '20', 'Amortecedor'),
(null, 'Motor do Gol 2000', 'Marca Boa', 20, 4000, '16', 'Motor'),
(null, 'Freio do Uno mil', 'Marca Boa', 20, 320, '16', 'Freio'),
(null, 'Embreagem do Cruze 2012', 'Marca Boa', 20, 240, '16', 'Embreagem'),
(null, 'Volante da Hillux', 'Marca Boa', 20, 120, '16', 'Volante'),
(null, 'Parachoque frente Uno 2010', 'Marca Boa', 20, 120, '16', 'Parachoque'),
(null, 'Retrovisor do Celta LD', 'Marca Boa', 20, 60, '16', 'Retrovisor'),
(null, 'Escape de Gol 2017', 'Yokohama', 20, 130, '16', 'Escape'),
(null, 'Retrovisor do Celta LE', 'Yokohama', 20, 120, '16', 'Retrovisor'),
(null, 'Farol do Palio 2014', 'Yokohama', 20, 120, '16', 'Farol'),
(null, 'Carburador do Celta 2010', 'Yokohama', 20, 120, '16', 'Carburador'),
(null, 'Pisca LD Gol Bola', 'Yokohama', 20, 120, '16', 'Pisca'),
(null, 'Parabrisa de Cruze LTZ', 'Yokohama', 20, 120, '16', 'Parabrisa'),
(null, 'Limpador de parabrisa VW', 'Yokohama', 20, 120, '16', 'Limpador'),
(null, 'Velocímetro do Celta', 'Yokohama', 20, 120, '16', 'Velocímetro'),
(null, 'Painel Gol Bola', 'Outra Marca Boa', 20, 3600, '16', 'Painel'),
(null, 'Freio de Uno 2008', 'Marca Boa', 20, 256, '16', 'Freio'),
(null, 'Embreagem de S10 2000', 'Marca Boa', 20, 120, '16', 'Embreagem'),
(null, 'Roda Aro 14 VW', 'Marca Boa', 20, 230, '16', 'Roda');

insert into Compra values
(null, '2017-01-29', 5000, 50, 'Cartão', 1),
(null, '2017-02-14', 4500, 25, 'Dinheiro', 2),
(null, '2017-01-20', 3200, 40, 'Dinheiro', 1),
(null, '2017-02-16', 2900, 15, 'Cartão', 3),
(null, '2017-03-02', 3800, 20, 'Cheque', 4),
(null, '2017-03-03', 7800, 2, 'Cartão', 5),
(null, '2017-01-27', 1000, 35, 'Cheque', 6),
(null, '2017-02-23', 600, 20, 'Dinheiro', 5),
(null, '2017-03-04', 780, 15, 'Cartão', 1),
(null, '2017-01-10', 900, 45, 'Cartão', 2);

insert into Compra_Prod values
(null, 1, 1, 10, 60.00),
(null, 1, 2, 25, 105.00),
(null, 1, 3, 5, 2000.00),
(null, 2, 4, 10, 100.25),
(null, 3, 5, 20, 120.50),
(null, 3, 6, 50, 50.00),
(null, 4, 7, 20, 62.00),
(null, 5, 8, 10, 30.00),
(null, 5, 9, 5, 52.00),
(null, 5, 10, 10, 68.00),
(null, 6, 11, 15, 62.00),
(null, 7, 12, 22, 58.50),
(null, 7, 13, 30, 69.99),
(null, 8, 14, 10, 60.00),
(null, 8, 15, 15, 51.00),
(null, 9, 16, 5, 1500.50),
(null, 10, 17, 15, 58.00),
(null, 10, 18, 10, 46.00),
(null, 10, 19, 15, 48.99),
(null, 10, 20, 15, 48.99);

insert into Despesa values
(null, 'Luz', 800, '2017-02-28', 'A vista'),
(null, 'Água', 450, '2017-02-28', 'A vista'),
(null, 'Energia', 1600, '2017-02-28', 'A vista'),
(null, 'Salário', 10000, '2017-03-05', 'A vista'),
(null, 'Luz', 825, '2017-01-30', 'A vista'),
(null, 'Água', 425, '2017-01-30', 'A vista'),
(null, 'Energia', 1550, '2017-01-30', 'A vista'),
(null, 'Salário', 10000, '2017-02-05', 'A vista'),
(null, 'Outros', 320, '2017-02-25', 'A vista'),
(null, 'Outros', 240, '2017-02-22', 'A vista');

insert into Caixa values
(null, '2017-02-20', 100, 3600, 2900, 800, 2),
(null, '2017-02-21', 400, 4800, 2000, 2800, 2),
(null, '2017-02-22', 200, 4900, 1000, 3900, 2),
(null, '2017-02-23', 150, 2800, 500, 2300, 2),
(null, '2017-02-24', 360, 3000, 1500, 1500, 2),
(null, '2017-02-25', 200, 2000, 350, 1650, 2),
(null, '2017-02-26', 150, 3600, 1200, 2400, 2),
(null, '2017-02-27', 100, 3500, 1500, 2000, 2),
(null, '2017-02-28', 150, 3400, 2200, 1200, 2),
(null, '2017-03-01', 200, 2800, 2900, -100, 2);

insert into Pagamento values 
(null, 450.50, 1, '2017-02-28', 'Dinheiro', 1, 9, null),
(null, 888.99, 2, '2017-02-27', 'Cartão', null, 8, 2),
(null, 750.88, 2, '2017-02-26', 'Cheque', null, 7, 3),
(null, 959.00, 3, '2017-02-25', 'Dinheiro', 4, 6, null),
(null, 258.60, 1, '2017-02-28', 'Dinheiro', 5, 9, null),
(null, 659.99, 1, '2017-02-27', 'Cartão', 6, 8, null),
(null, 350.00, 1, '2017-02-26', 'Cheque', null, 7, 7),
(null, 450.50, 1, '2017-02-25', 'Dinheiro', null, 6, 8),
(null, 950.75, 3, '2017-02-24', 'Dinheiro', null, 5, 9),
(null, 1450.00, 4, '2017-02-23', 'Cartão', 10, 4, null),
(null, 151.99, 1, '2017-02-23', 'Dinheiro', 1, 4, null),
(null, 350.80, 1, '2017-02-22', 'Dinheiro', null, 3, 2),
(null, 650.80, 1, '2017-02-21', 'Cheque', 3, 2, null),
(null, 750.00, 2, '2017-02-20', 'Dinheiro', null, 1, 4),
(null, 2050.00, 6, '2017-02-20', 'Cartão', 5, 1, null);

insert into Venda values
(null, 250.00, '2017-02-18', '13:00', 'A vista', 1, 1),
(null, 450.50, '2017-02-18', '14:00', 'Parcelado', 2, 3),
(null, 150.00, '2017-02-19', '15:00', 'A vista', 3, 1),
(null, 350.00, '2017-02-19', '16:00', 'A vista', 4, 3),
(null, 50.00, '2017-02-19', '17:00', 'A vista', 5, 1),
(null, 250.50, '2017-02-20', '12:00', 'A vista', 6, 3),
(null, 350.40, '2017-02-21', '08:00', 'Parcelado', 7, 1),
(null, 650.90, '2017-02-22', '09:00', 'Parcelado', 8, 3),
(null, 750.50, '2017-02-22', '10:00', 'Parcelado', 9, 1),
(null, 150.80, '2017-02-23', '11:00', 'A vista', 10, 3);

insert into Venda_Serv values
(null, 1, 1, 1),
(null, 2, 2, 2),
(null, 3, 3, 1),
(null, 4, 4, 1),
(null, 5, 5, 1),
(null, 6, 6, 2),
(null, 7, 7, 3),
(null, 8, 8, 1),
(null, 9, 9, 1),
(null, 10, 10, 2);

insert into Venda_Prod values
(null, 1, 1, 5),
(null, 2, 2, 3),
(null, 3, 3, 2),
(null, 4, 4, 1),
(null, 5, 5, 3),
(null, 6, 6, 2),
(null, 7, 7, 2),
(null, 8, 8, 1),
(null, 9, 9, 2),
(null, 10, 10, 3),
(null, 1, 11, 5),
(null, 2, 12, 3),
(null, 3, 13, 2),
(null, 4, 14, 1),
(null, 5, 15, 3),
(null, 6, 16, 2),
(null, 7, 17, 2),
(null, 8, 18, 1),
(null, 9, 19, 2),
(null, 10, 20, 3);

insert into Recebimento values
(null, 200.00, 1, 'Cartão', '2017-02-08', 1, 1),
(null, 300.00, 2, 'Cartão', '2017-02-09', 1, 2),
(null, 100.00, 1, 'Dinheiro', '2017-02-10', 2, 3),
(null, 350.00, 2, 'Dinheiro', '2017-02-11', 2, 4),
(null, 500.00, 1, 'Dinheiro', '2017-02-12', 3, 5),
(null, 200.00, 2, 'Dinheiro', '2017-02-13', 3, 6),
(null, 400.00, 1, 'Cheque', '2017-02-14', 4, 7),
(null, 150.00, 2, 'Cartão', '2017-02-15', 4, 8),
(null, 50.00, 1, 'Cartão', '2017-02-16', 5, 9),
(null, 100.00, 2, 'Cartão', '2017-02-17', 5, 10),
(null, 250.00, 1, 'Dinheiro', '2017-02-18', 6, 1),
(null, 100.00, 2, 'Cartão', '2017-02-19', 6, 2),
(null, 50.00, 1, 'Cartão', '2017-02-20', 7, 3),
(null, 100.00, 2, 'Cheque', '2017-02-21', 7, 4),
(null, 300.00, 1, 'Cartão', '2017-02-22', 8, 5),
(null, 50.00, 2, 'Dinheiro', '2017-02-23', 8, 6),
(null, 150.00, 1, 'Cartão', '2017-02-24', 9, 7),
(null, 600.00, 2, 'Dinheiro', '2017-02-25', 9, 8),
(null, 300.00, 1, 'Cartão', '2017-02-26', 9, 9),
(null, 300.00, 2, 'Cheque', '2017-02-27', 9, 10);

insert into Funcionario_Servico values 
(null, 6, 1),
(null, 6, 2),
(null, 6, 6);

#FAÇA AQUI OS COMANDOS SQL PARA ATINGIR OS OBJETIVOS A SEGUIR:

# Hora de Praticar 1 (DELETE)
SELECT * FROM Cliente;
# 1. Selecione os clientes com renda entre 500 e 20000 e nascidos em ‘1987’ e que possui RG com emissão ‘sesdec’.
SELECT * FROM Cliente WHERE (renda_cli BETWEEN 500 AND 20000) AND (data_Nasc_cli LIKE '1987%') AND (rg_cli LIKE '%sesdec%');
# 2. Selecione os clientes com sobrenome ‘Pereira’ ou ‘Souza’ e que possuam telefone com o DDD ’69’ e a renda entre 100 e 2000 ou 5000 e 10000;
SELECT * FROM Cliente WHERE ((nome_cli LIKE '% Pereira%') OR (nome_cli LIKE '% Souza%')) AND (telefone_cli LIKE '69%') AND ((renda_cli BETWEEN 100 AND 2000) OR (renda_cli BETWEEN 5000 AND 10000));
# 3. Selecione os clientes nascidos entre ‘1960’ e ‘1990’ e com renda entre 1000 e 10000 e com nome iniciado com a letra ‘J’ ou ‘M’;
SELECT * FROM Cliente WHERE (data_Nasc_cli BETWEEN '1960-01-01' AND '1990-12-31') AND (renda_cli BETWEEN 1000 AND 10000) AND ((nome_cli LIKE 'J%') OR (nome_cli LIKE 'M%'));
# 4. Selecione os carros com modelo ‘Gol’ e com placas que contenham os números ‘4’ ou ‘6’;
# 5. Selecione os fornecedores que possui o ‘LTDA’ no nome e que comecem com a letra ‘G’ ou ‘T’;
SELECT * FROM Fornecedor WHERE (razao_forn LIKE '%LTDA%') AND ((nome_forn LIKE 'G%') OR (nome_forn LIKE 'T%'));
# 6. Selecione os produtos com o ‘LD’ na descrição e com quantidade entre 1 e 100 e valor entre 500 e 5000;
SELECT * FROM Produto WHERE (nome_prod LIKE '%LD%') AND (estoque_prod BETWEEN 1 and 100) AND (valor_prod BETWEEN 500 AND 5000);
# 7. Selecione os produtos com o ‘LE’ na descrição e com ‘2020’ ou ‘2011 na descrição e com estoque entre 100 e 200 e valor entre 1 e 1000 e do tipo ‘Metal’ ou ‘Vidro’;
SELECT * FROM Produto WHERE (nome_prod LIKE '%LE%') AND ((nome_prod LIKE '%2020%') OR (nome_prod LIKE '%2021%')) AND (estoque_prod BETWEEN 100 AND 200) AND (valor_prod BETWEEN 1 AND 1000) AND ((tipo_prod = 'Metal') OR (tipo_prod = 'Vidro'));
# 8. Selecione serviços do tipo ‘Conserto’ e com tempo entre 0 e 1h e valor entre 0 e 1000;
SELECT * FROM Servico WHERE (descricao_serv LIKE '%Consert%') AND (tempo_serv BETWEEN '00:00' AND '01:00') AND (valor_serv BETWEEN 0 AND 1000);
# 9. Selecione estados que terminam com a letra ‘s’ no nome;
# 10. Selecione estados que comecem com a letra ‘m’ no nome;
# 11. Selecione estados que possui o termo ‘para’ no nome;
# 12. Selecione endereços que possui o termo ‘Av’ no nome das ruas;
SELECT cod_cli, endereco_cli FROM Cliente WHERE (endereco_cli LIKE '%Av%');
# 13. Selecione endereços que com o numero entre 100 e 10000 e do bairro ‘Centro’ e contenham um ‘.’ no nome da rua;
# 14. Selecione os clientes que possui rg com o termo ‘ssp’ e telefone com o ddd ‘69’;
SELECT * FROM Cliente WHERE (rg_cli LIKE '%ssp%') AND (telefone_cli LIKE '69%');
# 15. Agora para cada SELECT que você criou, crie um DELETE para o mesmo fim, ou seja, ao invés de selecionar você deverá deletar (obs: alguns registros não serem excluídos devido a dependência, normal);
DELETE FROM Cliente WHERE (renda_cli BETWEEN 500 AND 20000) AND (data_Nasc_cli LIKE '1987%') AND (rg_cli LIKE '%sesdec%');
DELETE FROM Cliente WHERE ((nome_cli LIKE '% Pereira%') OR (nome_cli LIKE '% Souza%')) AND (telefone_cli LIKE '69%') AND ((renda_cli BETWEEN 100 AND 2000) OR (renda_cli BETWEEN 5000 AND 10000));
# DELETE FROM Cliente WHERE (data_Nasc_cli BETWEEN '1960-01-01' AND '1990-12-31') AND (renda_cli BETWEEN 1000 AND 10000) AND ((nome_cli LIKE 'J%') OR (nome_cli LIKE 'M%'));
DELETE FROM Fornecedor WHERE (razao_forn LIKE '%LTDA%') AND ((nome_forn LIKE 'G%') OR (nome_forn LIKE 'T%'));
DELETE FROM Produto WHERE (nome_prod LIKE '%LD%') AND (estoque_prod BETWEEN 1 and 100) AND (valor_prod BETWEEN 500 AND 5000);
DELETE FROM Produto WHERE (nome_prod LIKE '%LE%') AND ((nome_prod LIKE '%2020%') OR (nome_prod LIKE '%2021%')) AND (estoque_prod BETWEEN 100 AND 200) AND (valor_prod BETWEEN 1 AND 1000) AND ((tipo_prod = 'Metal') OR (tipo_prod = 'Vidro'));
# DELETE FROM Servico WHERE (descricao_serv LIKE '%Consert%') AND (tempo_serv BETWEEN '00:00' AND '01:00') AND (valor_serv BETWEEN 0 AND 1000);
DELETE FROM Cliente WHERE (endereco_cli LIKE '%Av%');
DELETE FROM Cliente WHERE (rg_cli LIKE '%ssp%') AND (telefone_cli LIKE '69%');

# Hora de Praticar 2 (SELECT)

# 1. Selecione os clientes pelo nome em ordem crescente;
SELECT * FROM Cliente ORDER BY nome_cli ASC;
# 2. Selecione os clientes pela data de nascimento em ordem decrescente;
SELECT * FROM Cliente ORDER BY data_Nasc_cli DESC;
# 3. Selecione os clientes com os sobrenomes Silva ou Souza, do sexo feminino, com renda entre 500 e 10.000 reais e nascidos após 01/01/1980 ;
SELECT * FROM Cliente WHERE ((nome_cli LIKE '% Silva') OR (nome_cli LIKE '% Souza')) AND (sexo_cli = 'Feminino') AND (renda_cli BETWEEN 500 AND 10000) AND (data_Nasc_cli >= '1980-01-01');
# 4. Mostre quantos clientes existem cadastrados;
SELECT count(cod_cli) FROM Cliente;
# 5. Mostre os dados do cliente que possui a maior renda;
SELECT * FROM Cliente WHERE (renda_cli = (SELECT max(renda_cli) FROM Cliente));
# 6. Mostre a média das rendas de todos os clientes;
SELECT avg(renda_cli) FROM Cliente;
# 7. Mostre o valor médio dos produtos cadastrados;
SELECT avg(valor_prod) FROM Produto;
# 8. Mostre quais são os estados civis diferentes existentes na tabela cliente;
SELECT status_cli FROM Cliente GROUP BY status_cli;
# 9. Selecione o dados dos clientes do RG nulo;
SELECT * FROM Cliente WHERE (rg_cli IS NULL);
# 10. Mostre quantas cores diferentes existem na tabela carro;
# SELECT count(id_car) FROM Carro GROUP BY cor_car;
# 11. Mostre quais são as cores diferentes existem na tabela carro;
# SELECT cor_car FROM Carro GROUP BY cor_car;
# 12. Mostre todos os dados dos clientes que possuem renda inferior a média ordenados por renda;
SELECT * FROM Cliente WHERE (renda_cli < (SELECT avg(renda_cli) FROM Cliente)) ORDER BY renda_cli;
# 13. Mostre todos os dados dos clientes que possuem renda superior a média ordenados por renda descrescente;
SELECT * FROM Cliente WHERE (renda_cli > (SELECT avg(renda_cli) FROM Cliente)) ORDER BY renda_cli DESC;
