drop database if exists db_hora_praticar_alter_table_1;

create database db_hora_praticar_alter_table_1;

use db_hora_praticar_alter_table_1;

create table pais(
  id_pai int primary key,
  
  nome_pai varchar(200),
  continente_pai varchar(200)
);

create table estado(
  id_est int primary key,
  
  nome_est varchar(200),
  sigla_est varchar(4),
  regiao_est varchar(200),
  
  id_pai_fk int,
  FOREIGN KEY (id_pai_fk) REFERENCES pais(id_pai)
);

create table cidade(
  id_cid int primary key,
  
  nome_cid varchar(200),
  data_cricao_cid date,
  
  id_est_fk int,
  FOREIGN KEY (id_est_fk) REFERENCES estado(id_est)
);

create table endereco(
  id_end int primary key,
  
  rua_end varchar(200),
  numero_end int,
  bairro_end varchar(200),
  
  id_cid_fk int,
  FOREIGN KEY (id_cid_fk) REFERENCES cidade(id_cid)
);

create table cliente(
  id_cli int primary key,
  
  nome_cli varchar(200),
  cpf_cli varchar(11),
  data_nasc_cli date,
  sexo_cli varchar(20),
  email_cli varchar(200),
  
  id_end_fk int,
  FOREIGN KEY (id_end_fk) REFERENCES endereco(id_end)
);

#

alter table cliente add rg_cli varchar(300);
alter table cliente add telefone_cli varchar(50) after email_cli;
alter table endereco add referencia_cli varchar(200);
alter table pais drop continente_pai;
alter table cliente change sexo_cli genero_cli varchar(20);
alter table cliente change data_nasc_cli data_nasc_cli varchar(20);

# 

drop table cliente;
drop table endereco;
drop table cidade;
drop table estado;
drop table pais;
