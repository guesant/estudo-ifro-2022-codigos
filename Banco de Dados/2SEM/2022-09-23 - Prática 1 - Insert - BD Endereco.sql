drop database if exists BD_Endereco;

create database BD_Endereco;
use BD_Endereco;

create table Pais (
	id_pai integer primary key auto_increment,
	nome_pai varchar (100),
	continente_pai varchar (100)
);

# 1. Insira 05 registros na tabela Pais mencionando os atributos;

insert into Pais (id_pai, nome_pai, continente_pai) VALUES (null, 'Brasil', 'América do Sul');
insert into Pais (id_pai, nome_pai, continente_pai) VALUES (null, 'México', 'América do Norte');
insert into Pais (id_pai, nome_pai, continente_pai) VALUES (null, 'Panamá', 'América Central');
insert into Pais (id_pai, nome_pai, continente_pai) VALUES (null, 'Argélia', 'África');
insert into Pais (id_pai, nome_pai, continente_pai) VALUES (null, 'Austrália', 'Oceania');

# 2. Insira 05 registros na tabela Pais sem mencionar os atributos;

insert into Pais VALUES (null, 'Tailândia', 'Ásia');
insert into Pais VALUES (null, 'Índia', 'Ásia');
insert into Pais VALUES (null, 'Bulgária', 'Europa');
insert into Pais VALUES (null, 'Lituânia', 'Europa');
insert into Pais VALUES (null, 'República Centro-Africana', 'África');

select * from Pais;

create table Estado (
	id_est integer primary key auto_increment,
	nome_est varchar (100),
	sigla_est varchar (10),
	regiao_est varchar (100),
	id_pai_fk integer,
	foreign key (id_pai_fk) references Pais (id_pai)
);

# 3. Insira 05 registros na tabela Estado mencionando os atributos;

insert into Estado (id_est, nome_est, sigla_est, regiao_est, id_pai_fk) VALUES (null, 'Rondônia', 'RO', 'Norte', 1);
insert into Estado (id_est, nome_est, sigla_est, regiao_est, id_pai_fk) VALUES (null, 'Acre', 'AC', 'Norte', 1);
insert into Estado (id_est, nome_est, sigla_est, regiao_est, id_pai_fk) VALUES (null, 'Amazonas', 'AM', 'Norte', 1);
insert into Estado (id_est, nome_est, sigla_est, regiao_est, id_pai_fk) VALUES (null, 'Pará', 'PA', 'Norte', 1);
insert into Estado (id_est, nome_est, sigla_est, regiao_est, id_pai_fk) VALUES (null, 'Tocantins', 'TO', 'Norte', 1);

# 4. Insira 05 registros na tabela Estado sem mencionar os atributos;

insert into Estado VALUES (null, 'Maranhão', 'MA', 'Nordeste', 1);
insert into Estado VALUES (null, 'Mato Grosso do Sul', 'MS', 'Centro-Oeste', 1);
insert into Estado VALUES (null, 'Espírito Santo', 'ES', 'Sudeste', 1);
insert into Estado VALUES (null, 'Rio Grande do Sul', 'RS', 'Sul', 1);
insert into Estado VALUES (null, 'Amapá', 'AP', 'Norte', 1);

select * from Estado;

Create table Cidade (
	id_cid integer primary key auto_increment,
	nome_cid varchar (100),
	data_criacao_cid date,
	id_est_fk integer,
	foreign key (id_est_fk) references Estado (id_est)
);

# 5. Insira 05 registros na tabela Cidade mencionando os atributos;

insert into Cidade (id_cid, nome_cid, data_criacao_cid, id_est_fk) VALUES (null, 'Porto Velho', '1914-10-02', 1);
insert into Cidade (id_cid, nome_cid, data_criacao_cid, id_est_fk) VALUES (null, 'Ji-Paraná', '1977-11-22', 1);
insert into Cidade (id_cid, nome_cid, data_criacao_cid, id_est_fk) VALUES (null, 'Ariquemes', '1977-10-11', 1);
insert into Cidade (id_cid, nome_cid, data_criacao_cid, id_est_fk) VALUES (null, 'Vilhena', '1977-11-23', 1);
insert into Cidade (id_cid, nome_cid, data_criacao_cid, id_est_fk) VALUES (null, 'Cacoal', '1977-11-26', 1);

# 6. Insira 05 registros na tabela Cidade sem mencionar os atributos;

insert into Cidade VALUES (null, 'Rolim de Moura', '1983-08-05', 1);
insert into Cidade VALUES (null, 'Jaru', '1981-06-16', 2);
insert into Cidade VALUES (null, 'Guajará-Mirim', '1928-07-12', 3);
insert into Cidade VALUES (null, 'Machadinho d\'Oeste', '1988-05-11', 4);
insert into Cidade VALUES (null, 'Buritis', '1995-11-27', 5);

select * from Cidade;

Create table Endereco (
	id_end integer primary key auto_increment,
	rua_end varchar (100),
	numero_end integer,
	bairro_end varchar (100),
	id_cid_fk integer,
	foreign key (id_cid_fk) references Cidade (id_cid)
);

# 7. Insira 05 registros na tabela Endereco mencionando os atributos;

insert into Endereco (id_end, rua_end, numero_end, bairro_end, id_cid_fk) VALUES (null, 'Rua Fernando Sabino', 331, 'Vila Acre', 1);
insert into Endereco (id_end, rua_end, numero_end, bairro_end, id_cid_fk) VALUES (null, 'Rua Cinco', 463, 'Aleixo', 2);
insert into Endereco (id_end, rua_end, numero_end, bairro_end, id_cid_fk) VALUES (null, 'Rua Niquelândia', 653, 'Plano Diretor Norte', 1);
insert into Endereco (id_end, rua_end, numero_end, bairro_end, id_cid_fk) VALUES (null, 'Rua São Miguel', 669, 'Ikaray', 1);
insert into Endereco (id_end, rua_end, numero_end, bairro_end, id_cid_fk) VALUES (null, 'Rua Chaves', 339, 'Nova Cidade', 1);

# 8. Insira 05 registros na tabela Endereco sem mencionar os atributos;

insert into Endereco VALUES (null, 'Rua Saul Oliveira', 331, 'Carianos', 1);
insert into Endereco VALUES (null, 'Rua Paulo Carlos Moron', 658, 'Bela Vista', 2);
insert into Endereco VALUES (null, 'Rua Califórnia', 228, 'Novo Mundo', 3);
insert into Endereco VALUES (null, 'Rua Aristeu Ferreira Queiroz', 251, 'Itapoã', 4);
insert into Endereco VALUES (null, 'Rua Vinte e Seis de Agosto', 910, 'Amambaí', 5);

select * from Endereco;

create table Cliente (
	id_cli integer primary key auto_increment,
	nome_cli varchar (200) not null,
	cpf_cli varchar (15),
	data_nasc_cli date,
	sexo_cli varchar (30),
	email_cli varchar (200),
	id_end_fk integer,
	foreign key (id_end_fk) references Endereco (id_end)
);

# 9. Insira 05 registros na tabela Cliente mencionando os atributos;

insert into Cliente (id_cli, nome_cli, cpf_cli, data_nasc_cli, sexo_cli, email_cli, id_end_fk) VALUES (null, 'Pedro', '111.111.111-11', '1990-12-13', 'Masculino', 'pessoa1@email.com', 1);
insert into Cliente (id_cli, nome_cli, cpf_cli, data_nasc_cli, sexo_cli, email_cli, id_end_fk) VALUES (null, 'João', '222.222.222-11', '1990-12-15', 'Masculino', 'pessoa2@email.com', 2);
insert into Cliente (id_cli, nome_cli, cpf_cli, data_nasc_cli, sexo_cli, email_cli, id_end_fk) VALUES (null, 'Fernando', '333.444.555-11', '1990-12-19', 'Masculino', 'pessoa3@email.com', 3);
insert into Cliente (id_cli, nome_cli, cpf_cli, data_nasc_cli, sexo_cli, email_cli, id_end_fk) VALUES (null, 'Isabela', '999.999.999-11', '1990-12-12', 'Feminino', 'pessoa4@email.com', 4);
insert into Cliente (id_cli, nome_cli, cpf_cli, data_nasc_cli, sexo_cli, email_cli, id_end_fk) VALUES (null, 'Maria', '444.222.333-11', '1990-12-16', 'Feminino', 'pessoa5@email.com', 5);

# 10. Insira 05 registros na tabela Cliente sem mencionar os atributos;

insert into Cliente VALUES (null, 'Gabriel', '545.245.121-11', '1991-08-01', 'Masculino', 'pessoa6@email.com', 6);
insert into Cliente VALUES (null, 'Pedro', '252.522.722-11', '1992-09-02', 'Masculino', 'pessoa7@email.com', 7);
insert into Cliente VALUES (null, 'Marco', '471.896.342-15', '1993-10-05', 'Masculino', 'pessoa8@email.com', 8);
insert into Cliente VALUES (null, 'Tainara', '999.000.999-11', '1994-11-08', 'Feminino', 'pessoa9@email.com', 9);
insert into Cliente VALUES (null, 'Nícolas', '623.222.122-11', '1995-12-03', 'Masculino', 'pessoa10@email.com', 10);

select * from Cliente;