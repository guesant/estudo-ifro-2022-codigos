# Gabriel Rodrigues Antunes
# 2A - 2022

create database db_fabrica_gabriel_rodrigues_antunes;

use db_fabrica_gabriel_rodrigues_antunes;

CREATE TABLE fornecedor (
    id_for INT PRIMARY KEY,
    razao_social_for VARCHAR(200),
    nome_fantasia_for VARCHAR(200),
    cnpj_for VARCHAR(14),
    email_for VARCHAR(200)
);

CREATE TABLE despesa (
    id_des INT PRIMARY KEY,
    descricao_des VARCHAR(200),
    valor_des FLOAT,
    parcelamento_des INT,
    tipo_des VARCHAR(100),
    id_for_fk INT,
    FOREIGN KEY (id_for_fk)
        REFERENCES fornecedor (id_for),
    vencimento_des DATE
);

CREATE TABLE cliente (
    id_cli INT PRIMARY KEY,
    nome_cli VARCHAR(200) NOT NULL,
    cpf_cli VARCHAR(11),
    email_cli VARCHAR(11),
    celular_cli VARCHAR(20),
    data_nasc_cli DATE,
    endereco_cli VARCHAR(300)
);

CREATE TABLE compra (
    id_com INT PRIMARY KEY,
    data_com DATE,
    valor_com DOUBLE,
    forma_pagamento_com VARCHAR(100),
    id_for_fk INT,
    FOREIGN KEY (id_for_fk)
        REFERENCES fornecedor (id_for),
    numero_nota_fiscal_com VARCHAR(1000)
);

CREATE TABLE materia_prima (
    id_mp INT PRIMARY KEY,
    tipo_mp VARCHAR(100),
    nome_mp VARCHAR(100),
    marca_mp VARCHAR(100),
    caracteristicas_mp VARCHAR(200),
    estoque_mp DOUBLE,
    valor_mp DOUBLE,
    peso_mp DOUBLE
);

CREATE TABLE movel (
    id_mov INT PRIMARY KEY,
    valor_mov DOUBLE,
    estoque_mov DOUBLE,
    nome_mov VARCHAR(200),
    peso_mov DOUBLE,
    cor_mov VARCHAR(100),
    comprimento_mov DOUBLE,
    altura_mov DOUBLE,
    largura_mov DOUBLE,
    duracao_fabricacao_mov TIME
);

CREATE TABLE funcionario (
    id_fun INT PRIMARY KEY,
    nome_fun VARCHAR(200),
    funcao_fun VARCHAR(100),
    contato_fun VARCHAR(300),
    endereco_fun VARCHAR(300)
);

CREATE TABLE caixa (
    id_cai INT PRIMARY KEY,
    data_cai DATE,
    saldo_inicial_cai DOUBLE,
    total_entradas_cai DOUBLE,
    total_saidas_cai DOUBLE,
    saldo_final_cai DOUBLE,
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES funcionario (id_fun),
    numero_cai INT
);

CREATE TABLE pagamento (
    id_pag INT PRIMARY KEY,
    status_pag VARCHAR(200),
    valor_pag DOUBLE,
    parcela_pag INT,
    id_des_fk INT,
    FOREIGN KEY (id_des_fk)
        REFERENCES despesa (id_des),
    id_cai_fk INT,
    FOREIGN KEY (id_cai_fk)
        REFERENCES caixa (id_cai),
    vencimento_pag DATE
);

CREATE TABLE fabricacao (
    id_fab INT PRIMARY KEY,
    tempo_fab TIME,
    data_fab DATE,
    lote_fab VARCHAR(30),
    observacoes_fab VARCHAR(1000)
);

CREATE TABLE servico (
    id_ser INT PRIMARY KEY,
    tempo_ser TIME,
    valor_ser DOUBLE,
    tipo_ser VARCHAR(20),
    nome_ser VARCHAR(200),
    descricao_ser VARCHAR(1000)
);

CREATE TABLE venda (
    id_ven INT PRIMARY KEY,
    forma_recebimento_ven VARCHAR(200),
    valor_ven DOUBLE,
    data_ven DATE,
    tipo_ven VARCHAR(200),
    id_cli_fk INT,
    FOREIGN KEY (id_cli_fk)
        REFERENCES cliente (id_cli),
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES funcionario (id_fun),
    valor_desconto_ven DOUBLE
);

CREATE TABLE recebimento (
    id_rec INT PRIMARY KEY,
    status_rec VARCHAR(100),
    valor_rec DOUBLE,
    parcela_rec INT,
    id_ven_fk INT,
    FOREIGN KEY (id_ven_fk)
        REFERENCES venda (id_ven),
    id_cai_fk INT,
    FOREIGN KEY (id_cai_fk)
        REFERENCES caixa (id_cai),
    data_vencimento_rec DATE
);

CREATE TABLE compra_materia_prima (
    id_com_mp INT PRIMARY KEY,
    id_com_fk INT,
    FOREIGN KEY (id_com_fk)
        REFERENCES compra (id_com),
    id_mp_fk INT,
    FOREIGN KEY (id_mp_fk)
        REFERENCES materia_prima (id_mp),
    quantidade_com_mp INT
);

CREATE TABLE fabricacao_materia_prima (
    id_fab_mp INT PRIMARY KEY,
    id_fab_fk INT,
    FOREIGN KEY (id_fab_fk)
        REFERENCES fabricacao (id_fab),
    id_mp_fk INT,
    FOREIGN KEY (id_mp_fk)
        REFERENCES materia_prima (id_mp),
    quantidade_fab_mp INT
);

CREATE TABLE fabricacao_movel (
    id_fab_mov INT PRIMARY KEY,
    id_fab_fk INT,
    FOREIGN KEY (id_fab_fk)
        REFERENCES fabricacao (id_fab),
    id_mov_fk INT,
    FOREIGN KEY (id_mov_fk)
        REFERENCES movel (id_mov),
    quantidade_fab_mov INT
);

CREATE TABLE venda_movel (
    id_ven_mov INT PRIMARY KEY,
    id_ven_fk INT,
    FOREIGN KEY (id_ven_fk)
        REFERENCES venda (id_ven),
    id_mov_fk INT,
    FOREIGN KEY (id_mov_fk)
        REFERENCES movel (id_mov),
    quantidade_ven_mov INT
);

CREATE TABLE venda_servico (
    id_ven_mov INT PRIMARY KEY,
    id_ven_fk INT,
    FOREIGN KEY (id_ven_fk)
        REFERENCES venda (id_ven),
    id_ser_fk INT,
    FOREIGN KEY (id_ser_fk)
        REFERENCES servico (id_ser),
    quantidade_ven_ser INT,
    observacoes_ven_ser VARCHAR(1000)
);

CREATE TABLE fabricacao_funcionario (
    id_fab_fun INT PRIMARY KEY,
    id_fab_fk INT,
    FOREIGN KEY (id_fab_fk)
        REFERENCES fabricacao (id_fab),
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES funcionario (id_fun),
    funcao_fab_fun VARCHAR(100)
);