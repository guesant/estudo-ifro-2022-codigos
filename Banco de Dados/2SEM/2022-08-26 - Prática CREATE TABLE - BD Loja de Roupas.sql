# Gabriel Rodrigues Antunes
# 2A - 2022

create database db_loja_de_roupas_gabriel_rodrigues_antunes;

use db_loja_de_roupas_gabriel_rodrigues_antunes;

create table fornecedor (
  id_for int primary key,
  nome_for varchar(200),
  cnpj_for varchar(50),
  email_for varchar(250)
);

create table cliente(
  id_cli int primary key,
  nome_cli varchar(200),
  cpf_cli varchar(11),
  rg_cli varchar(100),
  email_cli varchar(250),
  endereco_cli varchar(300),
  contato_cli varchar(200),
  data_nascimento_cli date
);

create table produto(
  id_pro int primary key,
  nome_pro varchar(200),
  marca_pro varchar(200),
  valor_venda_pro double,
  estoque_pro double,
  valor_compra_pro double,
  tipo_pro varchar(200),
  descricao_pro varchar(300),
  peso_pro double
);

create table funcionario(
  id_fun int primary key,
  nome_fun varchar(200),
  cpf_fun varchar(11),
  rg_fun varchar(50),
  contato_fun varchar(200),
  email_fun varchar(200),
  funcao_fun varchar(200),
  salario_fun double
);

create table caixa(
  id_cai int primary key,
  
  numero_cai int,
  
  data_cai date,
  
  saldo_inicial_cai double,
  total_recebimentos_cai double,
  total_retiradas_cai double,
  saldo_final_cai double,
  
  hora_abertura_cai time,
  hora_fechamento_cai time,
  
  id_fun_fk int,  
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table venda(
  id_ven int primary key,
  
  valor_ven double,
  data_ven date,
  
  numero_nf_ven varchar(300),
  
  id_cli_fk int,
  FOREIGN KEY (id_cli_fk) REFERENCES cliente(id_cli),
  
  id_fun_fk int, 
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table recebimento(
  id_rec int primary key,
  
  parcela_rec int,
  forma_rec varchar(200),
  valor_rec double,
  data_rec date,
  status_rec varchar(100),  
  data_vencimento_rec double,
  
  id_cai_fk int,
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai),
  
  id_ven_fk int,
  FOREIGN KEY (id_ven_fk) REFERENCES venda(id_ven)
);

create table compra(
  id_com int primary key,
  valor_com double,
  data_com double,
  numero_nf_com varchar(200),
  
  id_for_fk int,
  FOREIGN KEY (id_for_fk) REFERENCES fornecedor(id_for),
  
  id_fun_fk int,
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table despesa(
  id_des int primary key,
  
  descricao_des varchar(200),
  
  valor_des double,
  parcelas_des int,
  
  data_des date,
  vencimento_des date,
  
  categoria_des varchar(100),  
  
  id_com_fk int,
  FOREIGN KEY (id_com_fk) REFERENCES compra(id_com)
);

create table pagamento(
  id_pag int primary key,
  
  valor_pag double,
  data_pag date,
  parcela_pag int,
  status_pag varchar(100),
  forma_pag varchar(100),
  vencimento_pag date,
  
  id_des_fk int,
  FOREIGN KEY (id_des_fk) REFERENCES despesa(id_des),
  
  id_cai_fk int,
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai)
);

create table venda_produto(
  id_v_p int,
  
  id_ven_fk int,
  FOREIGN KEY (id_ven_fk) REFERENCES venda(id_ven),
  
  id_pro_fk int,
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro),
  
  quantidade_v_p double
);

create table compra_produto(
  id_c_p int,
  
  id_com_fk int,
  FOREIGN KEY (id_com_fk) REFERENCES compra(id_com),
  
  id_pro_fk int,
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro),
  
  quantidade_c_p double
);
