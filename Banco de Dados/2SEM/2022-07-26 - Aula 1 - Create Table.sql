create database bd_aula_1;

use bd_aula_1;

CREATE TABLE endereco (
    id_end INT PRIMARY KEY,
    rua_end VARCHAR(200),
    numero_end INT,
    bairro_end VARCHAR(200)
);

CREATE TABLE cidade (
    id_cid INT PRIMARY KEY,
    nome_cid VARCHAR(200) NOT NULL,
    data_criacao DATE
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

CREATE TABLE estado (
    id_est INT PRIMARY KEY,
    nome_est VARCHAR(300) NOT NULL,
    sigla_est VARCHAR(2),
    regiao_est VARCHAR(20)
);

CREATE TABLE pais (
    id_pais INT PRIMARY KEY,
    nome_pais VARCHAR(200) NOT NULL,
    continente_pais VARCHAR(50)
);