# Gabriel Rodrigues Antunes
# 2A - 2022

drop database if exists db_hotel_dorme_bem_gabriel_rodrigues_antunes;

create database db_hotel_dorme_bem_gabriel_rodrigues_antunes;

use db_hotel_dorme_bem_gabriel_rodrigues_antunes;

create table quarto (
  id_qua int primary key,
  
  numero_qua int,
  andar_qua int,
  tipo_qua varchar(100),
  status_qua varchar(200),
  descricao_qua varchar(1000),
  
  area_qua double
);

create table produto (
  id_pro int primary key,
  
  tipo_pro varchar(100),
  descricao_pro varchar(1000),
  valor_pro double,
  nome_pro varchar(200),
  
  peso_pro double
);

create table fornecedor (
  id_for int primary key,
  
  razao_social_for varchar(100),
  nome_fantasia_for varchar(100),
  cnpj_for varchar(40),
  endereco_for varchar(400),
  contato_for varchar(400),
  
  data_criacao_for date
);

create table hospede (
  id_hde int primary key,
  
  nome_hde varchar(100),
  cpf_hde varchar(11),
  data_nascimento_hde date,
  endereco_hde varchar(1000),
  contato_hde varchar(400),
  email_hde varchar(200),
  
  rg_hde varchar(200)
);

create table funcionario (
  id_fun int primary key,
  
  nome_fun varchar(100),
  cpf_fun varchar(11),
  funcao_fun varchar(100),
  setor_fun varchar(100),
  endereco_hde varchar(1000),
  contato_hde varchar(400),
  
  email_hde varchar(200),  
  data_nascimento_hde date
);

create table servico (
  id_ser int primary key,
  
  valor_ser double,
  tipo_ser varchar(100),
  nome_ser varchar(200),

  descricao_ser varchar(200)
);

create table estoque (
  id_est int primary key,
  
  data_compra_est date,
  data_vencimento_est date,  
  local_est varchar(100),
  quantidade double,
  
  lote_est varchar(100),
  
  id_pro_fk int,
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro)
);

create table compra(
  id_com int primary key,
  
  data_com date,
  nf_com varchar(1000),
  valor_com double,
  forma_pagamento_com varchar(100),
  forma_entrega_com varchar(200),
  
  id_for_fk int,
  FOREIGN KEY (id_for_fk) REFERENCES fornecedor(id_for)
);

create table hospedagem (
  id_hgm int primary key,
  
  valor_diarias_hgm double,
  data_checkin_hgm date,
  data_checkout_hgm date,
  
  categoria_hgm varchar(100),
  
  id_fun_fk int,
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table venda (
  id_ven int primary key,
  
  data_ven date,
  valor_hospedagem_ven double,
  valor_consumo_ven double,
  valor_desconto_ven double,
  valor_total_ven double,  
  forma_recebimento_ven varchar(100),
  
  id_hgm_fk int,
  id_fun_fk int,
  
  FOREIGN KEY (id_hgm_fk) REFERENCES hospedagem(id_hgm),
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table caixa (
  id_cai int primary key,
  
  data_cai date,
  numero_cai int,
  saldo_final_cai double,
  status_cai varchar(100),
  total_pagamentos_cai double,
  total_recebimentos_cai double,
  saldo_inicial_cai double,
  
  tipo_de_atendimento_cai varchar(100),
  
  id_fun_fk int,
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table recebimento (
  id_rec int primary key,
  
  status_rec varchar(100),
  vencimento_rec date,
  valor_rec double,
  parcela_rec double,
  
  data_recebido_rec date,
  
  id_ven_fk int,
  id_cai_fk int,
  
  FOREIGN KEY (id_ven_fk) REFERENCES venda(id_ven),
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai)
);

create table despesa (
  id_des int primary key,
  
  nome_des varchar(100),
  valor_des double,
  forma_pagamento_des varchar(100),
  tipo_des varchar(100),
  categoria_des varchar(100),
  
  parcelas_des int,
  
  id_for_fk int,
  FOREIGN KEY (id_for_fk) REFERENCES fornecedor(id_for)
);

create table pagamento (
  id_pag int primary key,
  
  parcela_pag int,
  valor_pag double,
  vencimento_pag date,
  status_pag varchar(100),
  data_pagado_pag date,
  
  id_cai_fk int,
  id_des_fk int,
  
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai),
  FOREIGN KEY (id_des_fk) REFERENCES despesa(id_des)
);


create table quarto_hospedagem (
  id_q_h int primary key,
  
  id_qua_fk int,
  id_hgm_fk int,
  
  data_inicio_q_h date,
  data_fim_q_h date,
  
  FOREIGN KEY (id_qua_fk) references quarto(id_qua),
  FOREIGN KEY (id_hgm_fk) references hospedagem(id_hgm)
  
  # TODO
);

create table quarto_produto (
  id_q_p int primary key,
  
  id_qua_fk int,
  id_pro_fk int,
  
  data_reposicao_q_p date,
  quantidade_q_p double,
  
  FOREIGN KEY (id_qua_fk) REFERENCES quarto(id_qua),
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro)
);

create table quarto_servico (
  id_q_s int primary key,
  
  id_qua_fk int,
  id_ser_fk int,
  id_fun_fk int,
  
  data_q_s date,
  horario_q_s time,
  
  FOREIGN KEY (id_qua_fk) REFERENCES quarto(id_qua),
  FOREIGN KEY (id_ser_fk) REFERENCES servico(id_ser),
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun)
);

create table venda_produto (
  id_v_p int primary key,
  
  id_ven_fk int,
  id_pro_fk int,
  
  FOREIGN KEY (id_ven_fk) REFERENCES venda(id_ven),
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro)
);

create table venda_servico (
  id_v_s int primary key,
  
  id_ven_fk int,
  id_ser_fk int,
  
  FOREIGN KEY (id_ven_fk) REFERENCES venda(id_ven),
  FOREIGN KEY (id_ser_fk) REFERENCES servico(id_ser)
);

create table compra_produto (
  id_c_p int primary key,
  
  id_com_fk int,
  id_pro_fk int,
  
  FOREIGN KEY (id_com_fk) REFERENCES compra(id_com),
  FOREIGN KEY (id_pro_fk) REFERENCES produto(id_pro)
);

create table hospedagem_hospede (
  id_h_h int primary key,
  
  id_hgm_fk int,
  id_hde_fk int,
  
  FOREIGN KEY (id_hgm_fk) REFERENCES hospedagem(id_hgm),
  FOREIGN KEY (id_hde_fk) REFERENCES hospede(id_hde)
);
