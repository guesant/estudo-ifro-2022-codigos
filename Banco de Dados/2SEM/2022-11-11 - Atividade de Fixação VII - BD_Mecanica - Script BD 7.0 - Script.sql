# Gabriel Rodrigues Antunes
#BD Mecanica 7.0

drop database if exists bd_mecanica_7;
create database bd_mecanica_7;
use bd_mecanica_7;

create table Estado (
id_est int not null primary key auto_increment,
nome_est varchar (200) not null,
sigla_est varchar (2)
);

insert into Estado values (null, 'Acre', 'AC');
insert into Estado values (null, 'Alagoas', 'AL');
insert into Estado values (null, 'Amapá','AP');
insert into Estado values (null, 'Amazonas','AM');
insert into Estado values (null, 'Bahia','BA');
insert into Estado values (null, 'Ceara','CE');
insert into Estado values (null, 'Distrito Federal','DF');
insert into Estado values (null, 'Espírito Santo','ES');
insert into Estado values (null, 'Goiás','GO');
insert into Estado values (null, 'Maranhão','MA');
insert into Estado values (null, 'Mato Grosso','MT');
insert into Estado values (null, 'Mato Grosso do Sul','MS');
insert into Estado values (null, 'Minas Gerais','MG');
insert into Estado values (null, 'Pará','PA');
insert into Estado values (null, 'Paraíba','PB');
insert into Estado values (null, 'Paraná','PR');
insert into Estado values (null, 'Pernambuco','PE');
insert into Estado values (null, 'Piauí','PI');
insert into Estado values (null, 'Rio de Janeiro','RJ');
insert into Estado values (null, 'Rio Grande do Norte','RN');
insert into Estado values (null, 'Rio Grande do Sul','RS');
insert into Estado values (null, 'Rondônia','RO');
insert into Estado values (null, 'Roraima','RR');
insert into Estado values (null, 'Santa Catarina','SC');
insert into Estado values (null, 'São Paulo','SP');
insert into Estado values (null, 'Sergipe','SE');
insert into Estado values (null, 'Tocantins','TO');

create table cidade (
id_cid int not null primary key auto_increment,
nome_cid varchar (200) not null,
id_est_fk int,
foreign key (id_est_fk) references Estado (id_est)
);

insert into cidade values (null, 'Ji-Paraná', 22);
insert into cidade values (null, 'Porto Velho', 22);
insert into cidade values (null, 'Vilhena', 22);
insert into cidade values (null, 'Ariquemes', 22);
insert into cidade values (null, 'Jaru', 22);
insert into cidade values (null, 'Guajará-Mirim ', 22);
insert into cidade values (null, 'Colorado do Oeste', 22);
insert into cidade values (null, 'Ouro Preto do Oeste', 22);
insert into cidade values (null, 'Pimenta Bueno', 22);
insert into cidade values (null, 'Rio Branco', 1);
insert into cidade values (null, 'São Paulo', 25);
insert into cidade values (null, 'Manaus', 4);

create table Endereco (
id_end integer not null primary key auto_increment,
rua_end varchar (300),
numero_end integer,
bairro_end varchar (100),
id_cid_fk int not null,
foreign key (id_cid_fk) references Cidade (id_cid)
); 

insert into Endereco values (null, 'Av. Brasil', 111, 'Nova Brasília', 1);
insert into Endereco values (null, 'Av. Marechal Rondon', 1245, 'Centro', 1);
insert into Endereco values (null, 'Rua Dr. Telma Rios', 1174, 'Colina Park I', 1);
insert into Endereco values (null, 'Av. Aracaju', 911, 'BNH', 1);
insert into Endereco values (null, 'Rua 07 de Setembro', 121,'Centro',  1);
insert into Endereco values (null, 'Rua Mato Grosso', 887, 'Dom Bosco', 1);
insert into Endereco values (null, 'Av. Jorge Teixeira', 1589, 'Centro', 2);
insert into Endereco values (null, 'Av. Paulista', 989, 'Centro', 11);
insert into Endereco values (null, 'Travessa dos Mineiros', 456, 'Centro', 4);
insert into Endereco values (null, 'Av. Monte Castelo', 555, 'Jardim dos Migrantes', 1);
insert into Endereco values (null, 'Av. Aracaju', 5111, 'Nova Brasilia', 1);
insert into Endereco values (null, 'Av. Monte Castelo', 9999, 'Jardim dos Migrantes', 1);
insert into Endereco values (null, 'Rua X', 12, 'Jardim dos Migrantes', 1);
insert into Endereco values (null, 'K-0', 522, 'São Francisco', 1);
insert into Endereco values (null, 'Av. Monte Castelo', 11229, 'Jardim dos Migrantes', 1);

create table Sexo (
id_sex int not null primary key auto_increment,
nome_sex varchar (100) not null
);

insert into Sexo values (null, 'Masculino');
insert into Sexo values (null, 'Feminino');

create table Cliente (
id_cli integer not null primary key auto_increment,
nome_cli varchar (200) not null,
estado_civil_cli varchar (50),
cpf_cli varchar (20) not null,
rg_cli varchar (30),
data_nascimento_cli date,
renda_familiar_cli float,
telefone_cli varchar (50),
celular_cli varchar (50) not null,
id_sex_fk integer not null,
id_end_fk integer not null,
foreign key (id_sex_fk) references Sexo (id_sex),
foreign key (id_end_fk) references Endereco (id_end)
);

insert into cliente values (null, 'Rodrigo Hilbert', 'Casado', '111.111.111-11', '54654 sesdec', '1987-06-30', 10000.00, '69 84085712', '69 84111111', 1, 3);
insert into cliente values (null, 'Tiago Lacerda', 'Casado', '111.111.111-22', '54654 sesdec',  '1965-1-1', 456454.45, '', '', 1, 8);
insert into cliente values (null, 'Tom Cruise', 'Solteiro', '111.111.111-33', '48877 sesdec',  '1950-05-30', 0.00, '11 454546511', '', 1, 1);
insert into cliente values (null, 'José Pereiro da Silva', 'Casado', '222.222.222-88', '8888888 spp',  '1990-11-12', 900.00, '69 88998899', '69 4444 4444', 1, 4);
insert into cliente values (null, 'Maria de Jesus dos Santos', 'Solteira', '554.454.444-99', '99999 sesdec',  '1993-06-21', 3000.00, '69 3421 5511', '69 99111111', 2, 3);
insert into cliente values (null, 'Camila de Oliveira', 'Casada', '987.123.654-55', '8889999 sesdec',  '2000-12-12', 5450.00, '69 3421 1122', '69 9999 7788', 2, 10);
insert into cliente values (null, 'Marcos Araujo de Souza', 'Casado', '654.789.123-88', '998877 sesdec',  '1970-01-01', 6845.00, '69 84085712', '69 84111111', 1, 9);
insert into cliente values (null, 'Cleiton Batista Ferraz', 'Solteiro', '321.111.222-44', '1234312 sesdec',  '1982-07-30', 4199.00, '69 3421 2211', '69 84118811', 1, 2);
insert into cliente values (null, 'Eliana da Cruz', 'Solteira', '988.235.654-54', '12345 sesdec',  '1978-11-11', 3250.00, '69 3421 9999', '69 84118811', 2, 5);
insert into cliente values (null, 'Igor Garcia da Silva', 'Solteiro', '123.445.888-99', '999992 sesdec',  '1989-12-30', 9600.00, '69 3421 1123', '69 84118811', 1, 11);
insert into cliente values (null, 'Jackson Henrique da Silva Bezerra', 'Casado', '529.562.612-15', '880075 sesdec',  '1987-06-30', 11000.00, '', '69 84085712', 1, 3);
insert into cliente values (null, 'Jaqueline Leão Pereira', 'Casada', '522.222.153-15', '12315 sesdec', '1993-06-21', 11000.00, null, '69 984210921', 2, 3);
insert into cliente values (null, 'Gleicy Borgio', 'Casada', '126.777.888-99', null, null, 5000.00, null, '69 84888899', 2, 11);
insert into cliente values (null, 'Diego da Silva Bezerra', 'Solteiro', '111.987.123-55', null, null, 3999.99, null, '69 88997722', 1, 15);
insert into cliente values (null, 'Murilo Benicio', 'Casado', '321.123.321-55', null, null, 2450.80, null, '11 2121 1111', 1, 8);

create table Carro (
id_car int primary key not null auto_increment,
modelo_car varchar (100) not null,
cor_car varchar (50) not null,
portas_car varchar (50),
placa_car varchar (50) not null,
marca_car varchar (50) not null,
id_cli_fk int not null,
foreign key (id_cli_fk) references Cliente (id_cli)
);

insert into carro values (null, 'Gol 1.0', 'preto', '4 portas', 'ndr 2815', 'Volkswagen', 1);
insert into carro values (null, 'Palio 1.0', 'branco', '4 portas', 'nea 1231', 'Fiat', 2);
insert into carro values (null, 'Gol 1.0', 'preto', '4 portas', 'wat 1254', 'Volkswagen', 3);
insert into carro values (null, 'S-10', 'prata', '2 portas', 'eae 2815', 'GM', 4);
insert into carro values (null, 'Celta Spirit 1.0', 'branco', '4 portas', 'ndd 2815', 'GM', 5);
insert into carro values (null, 'Celta Life 1.0', 'vermelho', '2 portas', 'mra 1288', 'GM', 6);
insert into carro values (null, 'Hilux 2.4', 'prata', '4 portas', 'rtu 3498', 'Toyota', 7);
insert into carro values (null, 'Prisma LTZ', 'branco', '4 portas', 'oip 1231', 'GM', 8);
insert into carro values (null, 'Hilux 2.4', 'branco', '4 portas', 'asd 1234', 'Toyota', 9);
insert into carro values (null, 'HB-20', 'preto', '4 portas', 'ndt 1155', 'Hunday', 10);
insert into carro values (null, 'Hilux 2.4', 'prata', '4 portas', 'noo 2010', 'Toyota', 1);
insert into carro values (null, 'Gol 1.6', 'branco', '4 portas', 'nnd 2066', 'Volkswagen', 7);
insert into carro values (null, 'Cruze LTZ 1.8', 'preto', '4 portas', 'ndm 2819', 'GM', 11);
insert into carro values (null, 'Cruze LTZ 1.8', 'branco', '4 portas', 'nra 2233', 'GM', 5);
insert into carro values (null, 'Celta Spirit 1.0', 'branco', '4 portas', 'ndr 2233', 'GM', 12);

create table Departamento (
id_dep integer not null primary key auto_increment,
nome_dep varchar (100),
descricao_dep varchar (300)
);

insert into Departamento values (null, 'Vendas', 'Venda de peças e serviços');
insert into Departamento values (null, 'Financeiro', 'Controle Financeiro e Caixa');
insert into Departamento values (null, 'Entrega', 'Entregar peças');
insert into Departamento values (null, 'Mecânica', 'Realizar manutenção em veículos');
insert into Departamento values (null, 'Administração', 'Gestão da Empresa');

create table Funcionario (
id_func integer not null primary key auto_increment,
nome_func varchar (200) not null,
cpf_func varchar (20) not null,
rg_func varchar (20),
data_nascimento_func date,
salario_func double not null,
telefone_func varchar (50),
celular_func varchar (50) not null,
funcao_func varchar (50) not null,
id_sex_fk integer not null,
id_dep_fk integer not null,
id_end_fk integer not null,
foreign key (id_sex_fk) references Sexo (id_sex),
foreign key (id_dep_fk) references Departamento (id_dep),
foreign key (id_end_fk) references Endereco (id_end)
);

insert into funcionario values (null, 'João Batista', '123.544.311-99', '22222 sesdec', '1988-10-30', 5000.00, '', '69 84111155', 'Gerente', 1, 5, 3);
insert into funcionario values (null, 'Marcos Garcia Souza', '565.888.988-88', '64444 sesdec', '1965-1-20', 45000.00, '', '', 'Vendedor', 1, 1, 8);
insert into funcionario values (null, 'Leticia de Jesus', '998.999.789-55', '46666 sesdec', '1990-05-23', 1500.00, '11 454546511', '', 'Vendedora', 2, 1, 10);
insert into funcionario values (null, 'Mateus Solano ', '522.222.232-08', '65655 spp', '1990-11-30', 900.00, '69 8855 5544', '69 5555 4444', 'Mecanico', 1, 4, 4);
insert into funcionario values (null, 'Roger da Silva', '123.589.978-77', null, '1987-11-11', 1100.00, null, '69 9988 7788', 'Mecanico', 1, 4, 11);
insert into funcionario values (null, 'Karina Quadros', '987.987.788-88', null, '1985-11-22', 1000.50, null, '69 8888 7777', 'Caixa', 2, 2, 1);
insert into funcionario values (null, 'Isaias Queiroz', '123.121.321-88', '87788 sesdec', '1980-11-30', 2000.00, null, '69 8877 88881', 'Entregador', 1, 3, 7);

create table Fornecedor (
id_forn integer not null primary key auto_increment,
razao_social_forn varchar (200),
nome_fantasia_forn varchar (100),
representante_forn varchar (100),
id_end_fk integer not null,
foreign key (id_end_fk) references Endereco (id_end)
);

insert into Fornecedor values (null, 'GM Motors LTDA', 'Chevrolet GM', 'Tony', 5);
insert into Fornecedor values (null, 'Fiat LTDA', 'Fiat', 'Fabio', 1);
insert into Fornecedor values (null, 'Toyota LTDA', 'Toyota', 'Marcos', 2);
insert into Fornecedor values (null, 'Volkswagen LTDA', 'Volkswagem', 'Nilson', 3);
insert into Fornecedor values (null, 'Hunday LTDA', 'Hynday', 'Marcos', 3);
insert into Fornecedor values (null, 'Eletrobrás Brasil', 'Ceron', 'Governo', 10);
insert into Fornecedor values (null, 'Companhia de Agua e Esgoto de Rondonia', 'Caerd', 'Maria', 11);

create table Produto (
id_prod int primary key not null auto_increment,
descricao_prod varchar (50) not null,
marca_prod varchar (50),
quant_prod int,
valor_prod double,
tamanho_prod varchar (50),
tipo_prod varchar (50)
);

insert into produto values (null, 'Farol Civic 2020 LD', 'HONDA', 5, 3500.00, 'Médio', 'LED');
insert into produto values (null, 'Pneu aro 17 225/45', 'Pirelli', 20, 999.00, 'Médio', 'Borracha');
insert into produto values (null, 'Farol Gol G7 2020 LE', 'Volkswagen', 10, 1500.99, 'Médio', 'Vidro');
insert into produto values (null, 'Farol Gol G7 2020 LD', 'Ford', 10, 1500.99, 'Médio', 'Vidro');
insert into produto values (null, 'Capô Uno 2018', 'FIAT', 5, 900.00, 'Grande', 'Metal');
insert into produto values (null, 'Volante Sportivo Cruze 2021', 'Chevrolet', 3, 4000.00, 'Médio', 'Borracha');
insert into produto values (null, 'Difusor Ar Condicionado Celta 2011 LE', 'Chevrolet', 10, 50.00, 'Médio', 'Plastico');
insert into produto values (null, 'Parachoque S10 2020', 'Chevrolet', 10, 2500.00, 'Médio', 'Fibra');
insert into produto values (null, 'Parachoque Celta 2020', 'Chevrolet', 10, 1000.00, 'Médio', 'Fibra');
insert into produto values (null, 'Roda aro 15', 'FIAT', 4, 1000.00, 'Médio', 'Metal');
insert into produto values (null, 'Porta Hillux 2021 LD', 'Toyota', 4, 5000.00, 'Médio', 'Metal');
insert into produto values (null, 'Escape Gol 2021', 'volkswagen', 10, 500.00, 'Médio', 'Metal');
insert into produto values (null, 'Bico injetor motor 1.6 Uno 2020', 'FIAT', 5, 500.00, 'Médio', 'Metal');
insert into produto values (null, 'Lanterna S10 2020 LD', 'Chevrolet', 10, 1800.00, 'Médio', 'Plastico');
insert into produto values (null, 'Lanterna S10 2020 LE', 'Chevrolet', 10, 1800.00, 'Médio', 'Plastico');
insert into produto values (null, 'Escape Cela 2008', 'Chevrolet', 10, 500.00, 'Médio', 'Metal');
insert into produto values (null, 'Difusor Ar Condicionado Celta 2011 LD', 'Chevrolet', 10, 50.00, 'Médio', 'Plastico');
insert into produto values (null, 'Farol Civic 2020 LE', 'HONDA', 5, 3500.00, 'Médio', 'LED');
insert into produto values (null, 'Grade Difusora Civic 2021', 'Honda', 3, 3200.00, 'Médio', 'Metal');
insert into produto values (null, 'Motor 1.8 Cruze 2021', 'Chevrolet', 1, 18500.00, 'Grande', 'Metal');

create table Servico (
id_serv int not null primary key auto_increment,
descricao_serv varchar(300),
tipo_serv varchar (100),
valor_serv float not null,
tempo_serv time
);

insert into servico values (null, 'Funilaria de parachoque traseiro', 'Conserto', 350.00, '04:00:00');
insert into servico values (null, 'Rebaixar suspensao dianteira carro', 'Estética', 400.50, '01:10:00');
insert into servico values (null, 'Envelopar veiculo com pelicula preto fosco', 'Pintura', 1900.00, '08:00:00');
insert into servico values (null, 'Trocar volante', 'Conserto', 49.99, '00:50:00');
insert into servico values (null, 'Instalacao de acessório interno', 'Estética', 49.99, '00:50:00');
insert into servico values (null, 'Trocar pneu traseiro', 'Conserto', 30.80, '00:30:00');
insert into servico values (null, 'Instalar jogo de rodas', 'Conserto', 100.00, '00:30:00');
insert into servico values (null, 'Pintar veículo sedan', 'Pintura', 5000.00, '12:00:00');
insert into servico values (null, 'Substituição de suspensão dianteira', 'Conserto', 299.90, '03:00:00');
insert into servico values (null, 'Funilaria de parachoque dianteiro', 'Conserto', 350.00, '04:00:00'); 

create table Compra_Produto (
id_comp integer not null primary key auto_increment,
data_comp date,
valor_total_comp double,
forma_pagamento_comp varchar (100),
id_func_fk integer not null,
id_forn_fk integer not null,
foreign key (id_func_fk) references Funcionario (id_func),
foreign key (id_forn_fk) references Fornecedor (id_forn)
);

create table Itens_Compra (
id_itc integer not null primary key auto_increment,
quant_itc integer not null,
valor_itc float not null,
id_prod_fk integer not null,
id_comp_fk integer not null,
foreign key (id_prod_fk) references Produto (id_prod),
foreign key (id_comp_fk) references Compra_Produto (id_comp)
);

create table Caixa (
id_cai integer not null primary key auto_increment,
data_abertura_cai date not null,
data_fechamento_cai date,
saldo_inicial_cai double not null,
troco_cai double,
valor_creditos_cai double,
valor_debitos_cai double,
saldo_final_cai double,
status_cai varchar (100) not null
);

insert into Caixa values (null, '2018-08-19', '2019-08-20', 0, 100.00, 500.00, 0, 600.00, 'Fechado');
insert into Caixa values (null, curdate(), null, 0, 0.00, 0, 0, 0, 'Aberto');

create table Venda (
id_vend integer not null primary key auto_increment,
data_vend date,
valor_total_vend double not null,
desconto_vend double,
forma_recebimento_vend varchar (50),
parcelas_vend int,
id_func_fk integer not null,
id_cli_fk integer not null,
foreign key (id_func_fk) references Funcionario (id_func),
foreign key (id_cli_fk) references Cliente (id_cli)
);

create table Itens_Venda (
id_itv integer not null primary key auto_increment,
quant_itv integer not null,
id_prod_fk integer not null,
id_vend_fk integer not null,
foreign key (id_prod_fk) references Produto (id_prod),
foreign key (id_vend_fk) references Venda (id_vend)
);

create table Recebimentos (
id_rec integer not null primary key auto_increment,
data_vencimento_rec date,
valor_rec double,
parcela_rec varchar(100),
status_rec varchar (100),
forma_recebimento_rec varchar (100),
data_recebimento_rec date,
id_func_fk integer,
id_cai_fk integer,
id_vend_fk integer not null,
foreign key (id_func_fk) references Funcionario (id_func),
foreign key (id_cai_fk) references Caixa (id_cai),
foreign key (id_vend_fk) references Venda (id_vend)
);

create table Despesas (
id_desp integer not null primary key auto_increment,
descricao_desp varchar (200),
valor_desp double,
numero_documento_desp integer,
id_forn_fk int,
foreign key (id_forn_fk) references Fornecedor (id_forn)
);

create table Pagamentos (
id_pag integer not null primary key auto_increment,
data_vencimento_pag date,
valor_pag float,
parcela_pag varchar (100),
status_pag varchar (100),
forma_pagamento_pag varchar (100),
data_pagamento_pag date,
id_func_fk integer,
id_cai_fk integer,
id_desp_fk integer,
id_comp_fk integer,
foreign key (id_func_fk) references Funcionario (id_func),
foreign key (id_cai_fk) references Caixa (id_cai),
foreign key (id_desp_fk) references Despesas (id_desp),
foreign key (id_comp_fk) references Compra_produto (id_comp)
);

# 1. Selecione os clientes com renda entre 500 e 20000 e nascidos em ‘1987’ e que possui RG com emissão ‘sesdec’.
SELECT * FROM Cliente WHERE (renda_familiar_cli BETWEEN 500 AND 20000) AND (data_nascimento_cli LIKE '1987%') AND (rg_cli LIKE '%sesdec%');
# 2. Selecione os clientes com sobrenome ‘Pereira’ ou ‘Souza’ e que possuam telefone com o DDD ’69’ e a renda entre 100 e 2000 ou 5000 e 10000;
SELECT * FROM Cliente WHERE ((nome_cli LIKE '% Pereira%') OR (nome_cli LIKE '% Souza%')) AND (telefone_cli LIKE '69 %') AND ((renda_familiar_cli BETWEEN 100 AND 2000) OR (renda_familiar_cli BETWEEN 5000 AND 10000));
# 3. Selecione os clientes nascidos entre ‘1960’ e ‘1990’ e com renda entre 1000 e 10000 e com nome iniciado com a letra ‘J’ ou ‘M’;
SELECT * FROM Cliente WHERE (data_nascimento_cli BETWEEN '1960-01-01' AND '1990-12-31') AND (renda_familiar_cli BETWEEN 1000 AND 10000) AND ((nome_cli LIKE 'J%') OR (nome_cli LIKE 'M%'));
# 4. Selecione os carros com modelo ‘Gol’ e com placas que contenham os números ‘4’ ou ‘6’; 
SELECT * FROM Carro WHERE (modelo_car LIKE 'Gol %') AND ((placa_car LIKE '%4%') OR (placa_car LIKE '%6%'));
# 5. Selecione os fornecedores que possui o ‘LTDA’ no nome e que comecem com a letra ‘G’ ou ‘T’;
SELECT * FROM Fornecedor WHERE (razao_social_forn LIKE '% LTDA') AND ((razao_social_forn LIKE 'G%') OR (razao_social_forn LIKE 'T%'));
# 6. Selecione os produtos com o ‘LD’ na descrição e com quantidade entre 1 e 100 e valor entre 500 e 5000;
SELECT * FROM Produto WHERE (descricao_prod LIKE '%LD%') AND (quant_prod BETWEEN 1 AND 100) AND (valor_prod BETWEEN 500 AND 5000);
# 7. Selecione os produtos com o ‘LE’ na descrição e com ‘2020’ ou ‘2011 na descrição e com estoque entre 100 e 200 e valor entre 1 e 1000 e do tipo ‘Metal’ ou ‘Vidro’;
SELECT * FROM Produto WHERE (descricao_prod LIKE '%LE%') AND ((descricao_prod LIKE '%2020%') or (descricao_prod LIKE '%2011%')) AND (quant_prod BETWEEN 100 AND 200) AND (valor_prod BETWEEN 1 AND 1000) AND ((tipo_prod = 'Metal') or (tipo_prod = 'Vidro'));
# 8. Selecione serviços do tipo ‘Conserto’ e com tempo entre 0 e 1h e valor entre 0 e 1000;
SELECT * FROM Servico WHERE (tipo_serv = 'Conserto') AND (tempo_serv BETWEEN '00:00' AND '01:00') AND (valor_serv BETWEEN 0 AND 1000);
# 9. Selecione estados que terminam com a letra ‘s’ no nome;
SELECT * FROM Estado WHERE (nome_est LIKE '%s');
# 10. Selecione estados que comecem com a letra ‘m’ no nome;
SELECT * FROM Estado WHERE (nome_est LIKE 'M%');
# 11. Selecione estados que possui o termo ‘para’ no nome;
SELECT * FROM Estado WHERE (nome_est LIKE '%para%');
# 12. Selecione endereços que possui o termo ‘Av’ no nome das ruas;
SELECT * FROM Endereco WHERE (rua_end LIKE '%Av%');
# 13. Selecione endereços que com o numero entre 100 e 10000 e do bairro ‘Centro’  e contenham um ‘.’ no nome da rua;
SELECT * FROM Endereco WHERE (numero_end BETWEEN 100 AND 10000) AND (bairro_end = 'Centro') AND (rua_end LIKE '%.%');
# 14. Selecione os clientes que possui rg com o termo ‘ssp’ e telefone com o ddd ‘69’;
SELECT * FROM Cliente WHERE (rg_cli LIKE '%ssp%') AND (telefone_cli LIKE '69 %');

# 15. Agora para cada SELECT que você criou, crie um DELETE para o mesmo fim, ou seja, ao invés de selecionar você deverá deletar (obs: alguns registros não serem excluídos devido a dependência, normal);
DELETE FROM Cliente WHERE (renda_familiar_cli BETWEEN 500 AND 20000) AND (data_nascimento_cli LIKE '1987%') AND (rg_cli LIKE '%sesdec%');
DELETE FROM Cliente WHERE ((nome_cli LIKE '% Pereira%') OR (nome_cli LIKE '% Souza%')) AND (telefone_cli LIKE '69 %') AND ((renda_familiar_cli BETWEEN 100 AND 2000) OR (renda_familiar_cli BETWEEN 5000 AND 10000));
DELETE FROM Cliente WHERE (data_nascimento_cli BETWEEN '1960-01-01' AND '1990-12-31') AND (renda_familiar_cli BETWEEN 1000 AND 10000) AND ((nome_cli LIKE 'J%') OR (nome_cli LIKE 'M%'));
DELETE FROM Carro WHERE (modelo_car LIKE 'Gol %') AND ((placa_car LIKE '%4%') OR (placa_car LIKE '%6%'));
DELETE FROM Fornecedor WHERE (razao_social_forn LIKE '% LTDA') AND ((razao_social_forn LIKE 'G%') OR (razao_social_forn LIKE 'T%'));
DELETE FROM Produto WHERE (descricao_prod LIKE '%LD%') AND (quant_prod BETWEEN 1 AND 100) AND (valor_prod BETWEEN 500 AND 5000);
DELETE FROM Produto WHERE (descricao_prod LIKE '%LE%') AND ((descricao_prod LIKE '%2020%') or (descricao_prod LIKE '%2011%')) AND (quant_prod BETWEEN 100 AND 200) AND (valor_prod BETWEEN 1 AND 1000) AND ((tipo_prod = 'Metal') or (tipo_prod = 'Vidro'));
DELETE FROM Servico WHERE (tipo_serv = 'Conserto') AND (tempo_serv BETWEEN '00:00' AND '01:00') AND (valor_serv BETWEEN 0 AND 1000);
DELETE FROM Estado WHERE (nome_est LIKE '%s');
DELETE FROM Estado WHERE (nome_est LIKE 'M%');
DELETE FROM Estado WHERE (nome_est LIKE '%para%');
DELETE FROM Endereco WHERE (rua_end LIKE '%Av%');
DELETE FROM Endereco WHERE (numero_end BETWEEN 100 AND 10000) AND (bairro_end = 'Centro') AND (rua_end LIKE '%.%');
DELETE FROM Cliente WHERE (rg_cli LIKE '%ssp%') AND (telefone_cli LIKE '69 %');