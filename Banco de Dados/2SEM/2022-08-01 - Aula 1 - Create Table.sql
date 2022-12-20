# Gabriel Rodrigues Antunes
# 2A - 2022

create database bd_aula_1;

use bd_aula_1;

CREATE TABLE pais (
    id_pais INT PRIMARY KEY,
    nome_pais VARCHAR(200) NOT NULL,
    continente_pais VARCHAR(50)
);

CREATE TABLE estado (
    id_est INT PRIMARY KEY,
    nome_est VARCHAR(300) NOT NULL,
    sigla_est VARCHAR(2),
    regiao_est VARCHAR(20),
    id_pais_fk INT,
    FOREIGN KEY (id_pais_fk)
        REFERENCES pais (id_pais)
);

CREATE TABLE cidade (
    id_cid INT PRIMARY KEY,
    nome_cid VARCHAR(200) NOT NULL,
    data_criacao DATE,
    id_est_fk INT,
    FOREIGN KEY (id_est_fk)
        REFERENCES estado (id_est)
);

CREATE TABLE endereco (
    id_end INT PRIMARY KEY,
    rua_end VARCHAR(200),
    numero_end INT,
    bairro_end VARCHAR(200),
    id_cid_fk INT,
    FOREIGN KEY (id_cid_fk)
        REFERENCES cidade (id_cid)
);

CREATE TABLE cliente (
    id_cli INT PRIMARY KEY,
    
    nome_cli VARCHAR(300) NOT NULL,
    cpf_cli VARCHAR(11),
    data_nasc_cli DATE,
    sexo_cli VARCHAR(50),
    email_cli VARCHAR(300),
    
    id_end_fk INT,
    FOREIGN KEY (id_end_fk)
        REFERENCES endereco (id_end)
);

CREATE TABLE funcionario (
    id_fun INT PRIMARY KEY,
    cpf_fun VARCHAR(11),
    nome_fun VARCHAR(200) NOT NULL,
    data_contratacao_fun DATE,
    funcao_fun VARCHAR(100),
    salario_fun DOUBLE,
    email_fun VARCHAR(200),
    telefone_fun VARCHAR(30),
    sexo_fun VARCHAR(10),
    data_nasc_fun DATE
);

CREATE TABLE venda (
    id_ven INT PRIMARY KEY,
    valor_ven DOUBLE,
    forma_pagamento_ven VARCHAR(200),
    data_ven DATE,
    id_cli_fk INT,
    FOREIGN KEY (id_cli_fk)
        REFERENCES cliente (id_cli),
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES funcionario (id_fun)
);

CREATE TABLE produto (
    id_pro INT PRIMARY KEY,
    nome_pro VARCHAR(200) NOT NULL,
    valor_pro FLOAT,
    estoque_pro FLOAT,
    marca_pro VARCHAR(100),
    descricao_pro VARCHAR(1000)
);

CREATE TABLE venda_produto (
    id_ven_prod INT PRIMARY KEY,
    
    quant DOUBLE,
    
    id_ven_fk INT,
    FOREIGN KEY (id_ven_fk)
        REFERENCES venda (id_ven),

    id_pro_fk INT,
    FOREIGN KEY (id_pro_fk)
        REFERENCES produto (id_pro)    
);

