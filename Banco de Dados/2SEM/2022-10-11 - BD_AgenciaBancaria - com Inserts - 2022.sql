drop database if exists BD_Banco;
create database BD_Banco;
use BD_Banco;

create table Banco (
cod_ban int primary key not null,
nome_ban varchar (200) not null
);

insert into Banco values (1, 'Caixa Econômica Federal');
insert into Banco values (2, 'Banco do Brasil');

create table Agencia (
cod_ag int primary key not null,
numero_ag varchar (100) not null,
nome_ag varchar (100),
telefone_ag varchar (200),
cod_ban_fk int not null,
foreign key (cod_ban_fk) references Banco (cod_ban)
);

insert into Agencia values (1, '0951-2', 'Centro', '69 3423 1925', 2);
insert into Agencia values (2, '4402-1', 'Centro', '69 3423 1925', 2);
insert into Agencia values (3, '1824', 'Centro', '69 3423 1925', 1);


create table Cliente (
cod_cli int primary key not null,
nome_cli varchar (200) not null,
cpf_cli varchar (50) not null,
rg_cli varchar (100) not null,
sexo_cli varchar (1),
data_nascimento_cli date not null,
renda_cli float not null,
endereco_cli varchar (300) not null,
email_cli varchar (300) not null,
telefone_cli varchar (200) not null
);


insert into Cliente values (1, 'Maria da Silva', '123.123.123-23', '1113322 sesdec/RO', 'F', '1990-10-10', 2500.00, 'Rua das Flores', 'maria.silva@hotmail.com', '3423 3333'); 
insert into Cliente values (2, 'Roberto Carlos', '789.789.789-89', '889977 sesdec/RO', 'M', '1975-01-10', 4990.00, 'Av. Costa', 'roberto.carlos@gmail.com', '8444 8899'); 
insert into Cliente values (3, 'Jane Pereira', '444.666.444-44', '005548 sesdec/RO', 'F', '1989-06-07', 1850.50, 'Rua Presidente', 'jane.pereira@hotmail.com', '9977 8899'); 
insert into Cliente values (4, 'Clodoaldo Bragança', '654.456.654-65', '654658 sesdec/RO', 'F', '1991-10-12', 9850.50, 'Av. Brasil', 'clodoaldo.bragança@gmail.com', '3423 5500'); 
insert into Cliente values (5, 'Livia de Souza', '333.444.666-98', '0033333 sesdec/RO', 'F', '1982-01-30', 1100.00, 'Av. Ji-Parana', 'livia.souza@hotmail.com', '8498 9898'); 
insert into Cliente values (6, 'Joab da Silva', '159.425.456-77', '001215 sesdec/RO', 'M', '2000-10-01', 4990.00, 'Av. Ji-Parana', 'joab.silva@hotmail.com', '69 8411 2321');
insert into cliente values (7, 'Rodrigo Hilbert', '123.445.888-99', '5592 sesdec', 'M', '1970-09-30', 2500.00, 'Rua Dr. Luiz', 'rodrigo.hilbert@yahoo.com.br', '9944 4545');
insert into cliente values (8, 'João Eujácio Teixeira Júnior', '999.445.789-99', '978999992 sesdec', 'M', '1989-01-10', 6000.00, 'Rua Silva Abreu', 'joao.eujacio@ifro.edu.br', '3421 1159');
insert into cliente values (9, 'Everton Feline', '123.123.888-99', '12392 sesdec', 'M', '1987-12-10', 11500.00, 'Rua Alencar Vieira', 'everton.feline@gmail.com','69 84228811');
insert into cliente values (10, 'Igor de Souza Santos', '123.345.848-99', '43299892 sesdec', 'M', '1990-12-30', 1000.00, 'Av. Brasil', 'igor.souza@gmail.com', '69 9977 7777');
insert into cliente values (11, 'Francisco Bezerra', '888.123.111-11', '213156 sesdec', 'M', '1965-01-30', 3500.00, 'Rua Fim do Mundo', 'francisco.bezerra@ifro.edu.br', '69 3423 5502');


create table Conta_Corrente (
cod_cc int primary key not null,
numero_cc int not null,
data_abertura_cc date not null,
saldo_cc float not null,
valor_limite_cc float not null,
taxa_mensal_cc float not null,
cod_ag_fk int not null,
cod_cli_fk int not null,
foreign key (cod_ag_fk) references Agencia (cod_ag),
foreign key (cod_cli_fk) references Cliente (cod_cli)
);


insert into Conta_Corrente values (1, 40650, '2009-01-01', 500.00, 1000.00, 10.00, 1, 1);
insert into Conta_Corrente values (2, 41897, '2009-01-30', 2200.00, 5000.00, 40.00, 1, 2);
insert into Conta_Corrente values (3, 42487, '2010-06-06', 1500.00, 2000.00, 30.00, 1, 3);
insert into Conta_Corrente values (4, 43456, '2011-04-21', 3200.00, 5000.00, 40.00, 1, 4);
insert into Conta_Corrente values (5, 44787, '2012-12-31', 100.00, 1000.00, 10.00, 1, 5);
insert into Conta_Corrente values (6, 45650, '2013-01-01', 500.00, 1000.00, 10.00, 1, 6);
insert into Conta_Corrente values (7, 46897, '2014-01-30', 2200.00, 5000.00, 40.00, 1, 7);
insert into Conta_Corrente values (8, 47487, '2014-06-06', 1500.00, 2000.00, 30.00, 1, 8);
insert into Conta_Corrente values (9, 48456, '2015-04-21', 2500.00, 5000.00, 40.00, 1, 9);
insert into Conta_Corrente values (10, 49787, '2016-12-31', 1100.00, 1000.00, 10.00, 1, 10);
insert into Conta_Corrente values (11, 280191, '2016-12-31', 1100.00, 1000.00, 10.00, 3, 11);


create table Saque (
cod_saq int primary key not null,
valor_saq float not null,
data_saq date not null,
local_saq varchar (100) not null,
hora_saq time,
cod_cc_fk int not null,
foreign key (cod_cc_fk) references Conta_Corrente (cod_cc)
);

insert into Saque values (1, 100.00, '2014-11-12', 'Caixa Eletrônico', sysdate(), 5);
insert into Saque values (2, 200.00, '2014-12-11', 'Agência', sysdate(), 1);
insert into Saque values (3, 120.00, '2015-12-02', 'Caixa Eletrônico', sysdate(), 2);
insert into Saque values (4, 100.00, '2015-01-03', 'Caixa Eletrônico', sysdate(), 5);
insert into Saque values (5, 200.00, '2015-01-30', 'Caixa Eletrônico', sysdate(), 1);
insert into Saque values (6, 120.00, '2015-02-25', 'Agência', sysdate(), 6);
insert into Saque values (7, 100.00, '2016-01-07', 'Agência', sysdate(), 1);
insert into Saque values (8, 200.00, '2016-01-08', 'Caixa Eletrônico', sysdate(), 4);
insert into Saque values (9, 120.00, '2016-03-20', 'Caixa Eletrônico', sysdate(), 2);
insert into Saque values (10, 100.00, '2016-03-23', 'Agência', sysdate(), 7);
insert into Saque values (11, 200.00, '2016-05-09', 'Caixa Eletrônico', sysdate(), 4);
insert into Saque values (12, 120.00, '2016-06-16', 'Agência', sysdate(), 6);
insert into Saque values (13, 100.00, '2016-08-21', 'Caixa Eletrônico', sysdate(), 9);
insert into Saque values (14, 200.00, '2016-09-06', 'Caixa Eletrônico',sysdate(), 8);
insert into Saque values (15, 120.00, '2016-10-20', 'Caixa Eletrônico', sysdate(), 10);
insert into Saque values (16, 122.22, '2016-10-20', 'Agência', sysdate(), 2);


create table Transferencia (
cod_trans int primary key not null,
valor_trans float not null,
data_trans date not null,
descricao_trans varchar (100),
cod_cc_origem_fk int not null,
cod_cc_destino_fk int not null,
foreign key (cod_cc_origem_fk) references Conta_Corrente (cod_cc),
foreign key (cod_cc_destino_fk) references Conta_Corrente (cod_cc)
);

insert into Transferencia values (1, 5100.00, '2010-01-01', 'Pagamento Pensão', 4, 1);
insert into Transferencia values (2, 150.00, '2011-09-20', 'Compra Moto', 2, 3);
insert into Transferencia values (3, 50.00, '2013-10-23', 'Pagamento Divida', 3, 1);
insert into Transferencia values (4, 1000.00, '2014-12-29', '', 10, 3);
insert into Transferencia values (5, 660.00, '2016-11-30', '', 1, 9);
insert into Transferencia values (6, 340.00, '2016-10-10', 'Pagamento', 7, 6);

create table Deposito (
cod_dep int primary key not null,
valor_dep float not null,
data_dep date not null,
tipo_dep varchar (100),
cod_cc_fk int not null,
foreign key (cod_cc_fk) references Conta_Corrente (cod_cc)
);

insert into Deposito values (1, 500.00, '2011-03-21', 'Dinheiro', 1);
insert into Deposito values (2, 50.00, '2011-10-09', 'Dinheiro', 4);
insert into Deposito values (3, 1500.00, '2011-12-20', 'Cheque', 3);
insert into Deposito values (4, 125.00, '2011-06-11', 'Dinheiro', 1);
insert into Deposito values (5, 490.00, '2012-12-02', 'Dinheiro', 1);
insert into Deposito values (6, 1010.00, '2012-12-11', 'Cheque', 6);
insert into Deposito values (7, 120.00, '2016-01-30', 'Dinheiro', 7);
insert into Deposito values (8, 550.00, '2016-06-30', 'Dinheiro', 9);
insert into Deposito values (9, 80.00, '2016-10-23', 'Dinheiro', 10);
insert into Deposito values (10, 1000.00, '2016-11-08', 'Cheque', 10);


create table Pagamento (
cod_pag int primary key not null,
valor_pag float not null,
data_pag date not null,
tipo_pag varchar (100),
data_vencimento_pag date not null,
codigo_barras_pag varchar (300),
cod_cc_fk int not null,
foreign key (cod_cc_fk) references Conta_Corrente (cod_cc)
);

insert into Pagamento values (1, 300.00, '2015-10-20', 'Boleto', '2015-10-20', '1212312111131', 1);
insert into Pagamento values (2, 54.00, '2015-01-20', 'Convênio', '2015-01-20', '787987987987', 2);
insert into Pagamento values (3, 89.00, '2016-06-20', 'Boleto', '2016-06-22', '6544678979', 1);
insert into Pagamento values (4, 321.00, '2016-10-20', 'Convênio', '2016-10-20', '156546465454', 2);
insert into Pagamento values (5, 123.00, '2016-11-08', 'Boleto', '2016-11-09', '132131564587', 1);

SELECT * from Cliente;
SELECT * from Conta_Corrente;

# 1. Crie um update que mude o nome do cliente nº 5 para ‘Lucas Matos’;
UPDATE Cliente SET nome_cli = 'Lucas Matos' WHERE cod_cli = 5;
# 2. Crie um update que aumenta a renda em 20% dos clientes nascidos antes do ano 2000;
UPDATE Cliente SET renda_cli = renda_cli * 1.2 WHERE data_nascimento_cli < '2000-01-01';
# 3. Crie um update para diminuir a renda em 27% dos clientes homens com renda maior ou igual a 5000 reais;
UPDATE Cliente SET renda_cli = renda_cli * 0.73 WHERE (sexo_cli = 'M') AND (renda_cli >= 5000);
# 4. Crie um update para alterar a idade do cliente nº 2 para 40 anos.
UPDATE Cliente SET data_nascimento_cli = '1982-01-10' WHERE cod_cli = 2;
# 5. Altere para 50 a idade dos clientes com ID entre 2 e 5 ou nascidos entre 1970 e 1980;
UPDATE Cliente SET data_nascimento_cli = '1972-10-12' WHERE ((cod_cli >= 2 AND cod_cli <= 5)) OR ((data_nascimento_cli >= '1970-01-01') AND (data_nascimento_cli <= '1980-12-31'));
# 6. Diminua 500 reais na renda dos clientes nascidos entre 1980 e 2000 que tenha renda superior a 1000 reais e idade menos que 50;
UPDATE Cliente SET renda_cli = renda_cli - 500 WHERE ((data_nascimento_cli >= '1980-01-01' AND data_nascimento_cli <= '2000-12-31')) AND (renda_cli > 100) AND (data_nascimento_cli > '1972-10-12');
# 7. Aumente 1000 reais na renda dos clientes com idade entre 10 e 20 anos ou 40 e 60 anos.
UPDATE Cliente SET renda_cli = renda_cli + 1000 WHERE ((data_nascimento_cli >= '2002-10-12') AND (data_nascimento_cli <= '2012-10-12')) OR ((data_nascimento_cli >= '1962-10-12') AND (data_nascimento_cli <= '1982-10-12'));
# 8. Aumente a taxa mensal em 30% das conta corrente com saldo maior do que 500 reais e data de abertura no primeiro semestre de 2009;
UPDATE Conta_Corrente SET taxa_mensal_cc = taxa_mensal_cc * 1.3 WHERE (saldo_cc > 500) AND ((data_abertura_cc >= '2009-01-01') AND (data_abertura_cc <= '2009-06-30'));
# 9. Zere a taxa mensal das conta corrente com saldo superior ou igual a 1000 reais.
UPDATE Conta_Corrente SET taxa_mensal_cc = 0 WHERE saldo_cc >= 1000;
# 10. Aumente o valor do limite em 50% das contas com data de aberta anterior a 2014 ou com valor de limite inferior a 1000 reais.
UPDATE Conta_Corrente SET valor_limite_cc = valor_limite_cc * 1.5 WHERE (data_abertura_cc < '2014-01-01') OR (valor_limite_cc < 1000);

SELECT * from Cliente;
SELECT * from Conta_Corrente;