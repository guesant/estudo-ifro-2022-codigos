# Gabriel Rodrigues Antunes
# 2A - 2022

drop database if exists db_clinica_odontologica_gabriel_rodrigues_antunes;

create database db_clinica_odontologica_gabriel_rodrigues_antunes;

use db_clinica_odontologica_gabriel_rodrigues_antunes;

create table paciente (
  id_pac int primary key,
  
  nome_pac varchar(200),
  cpf_pac varchar(11),
  data_nascimento_pac date,
  email_pac varchar(300),
  celular_pac varchar(200),
  endereco_pac varchar(400),

  tipo_sanguineo_pac varchar(3)
);

create table funcionario(
  id_fun int primary key,
  
  especialidade_fun varchar(200),
  nome_fun varchar(200),
  cpf_fun varchar(11),
  rg_fun varchar(150),
  funcao_fun varchar(200),
  data_nascimento_fun date,
  celular_fun varchar(100),
  endereco_fun varchar(300),
  email_fun varchar(300),
  
  salario_fun double
);

create table fornecedor(
  id_for int primary key,
  
  razao_social_for varchar(200),
  nome_fantasia_for varchar(200),
  cnpj_for varchar(200),
  endereco_for varchar(300),
  contato_for varchar(200),
  
  email_for varchar(200)
);

create table compra(
  id_com int primary key,
  
  data_com date,
  valor_com double,
  
  numero_nota_fiscal_com varchar(1000),
  
  id_for_fk int,
  FOREIGN KEY (id_for_fk) REFERENCES fornecedor(id_for)
);

create table despesa(
  id_des int primary key,
  
  nome_des varchar(100),
  data_des date,
  vencimento_des date,
  
  parcelamento_des int,
  
  categoria_des varchar(200)
);

create table sala(
  id_sal int primary key,
  
  nome_sal varchar(100),
  equipamentos_sal varchar(200),
  capacidade_sal int,
  
  area_sal double
);

create table material(
  id_mat int primary key,
  
  nome_mat varchar(200),
  descricao_mat varchar(300),
  estoque_mat double,
  valor_mat double,
  tipo_mat varchar(150),
  
  peso_mat double
);

create table procedimento(
  id_pro int primary key,
  
  valor_pro double,
  nome_pro varchar(200),
  descricao_pro varchar(400),
  tempo_pro time,
  tipo_pro varchar(200),
  requisitos_pro varchar(200),
  
  data_pro date
);

create table consulta (
  id_con int primary key,
  
  valor_con double,
  tempo_con time,
  data_con date,
  
  convenio_con varchar(200),
  
  id_fun_fk int,
  id_pac_fk int,
  id_sal_fk int,
  
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun),
  FOREIGN KEY (id_pac_fk) REFERENCES paciente(id_pac),
  FOREIGN KEY (id_sal_fk) REFERENCES sala(id_sal)
);

create table odontograma(
  id_odo int primary key,
  
  data_odo date,
  
  dente_3_molar_odo varchar(200),
  dente_1_premolar_odo varchar(200),
  dente_2_premolar_odo varchar(200),
  dente_incisivo_central_odo varchar(200),
  dente_2_molar_odo varchar(200),
  dente_canino_odo varchar(200),
  dente_1_molar_odo varchar(200),
  dente_incisivo_lateral_odo varchar(200),
  
  hora_odo time,
  
  id_con_fk int,
  id_pac_fk int,
  
  FOREIGN KEY (id_con_fk) REFERENCES consulta(id_con),
  FOREIGN KEY (id_pac_fk) REFERENCES paciente(id_pac)
);

# 11

create table caixa(
  id_cai int primary key,
  
  data_cai date,
  saldo_inicial_cai double,
  total_entrada_cai double,
  total_saida_cai double,
  saldo_final_cai double,
  
  hora_cai time,
  numero_cai int
);

# 12

create table recebimento(
  id_rec int primary key,
  
  parcela_rec int,
  status_rec varchar(200),
  forma_rec varchar(100),
  data_rec date,
  valor_rec double,
  
  id_cai_fk int,
  id_con_fk int,
  
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai),
  FOREIGN KEY (id_con_fk) REFERENCES consulta(id_con),
  
  vencimento_rec date
);

# 13

create table pagamento(
  id_pag int primary key,
  
  parcela_rec int,
  status_rec varchar(200),
  forma_rec varchar(100),
  data_rec date,
  valor_rec double,
  
  id_cai_fk int,
  id_des_fk int,
  
  FOREIGN KEY (id_cai_fk) REFERENCES caixa(id_cai),
  FOREIGN KEY (id_des_fk) REFERENCES despesa(id_des),
  
  vencimento_rec date
);

# 14

create table anamnese(
  id_ana int primary key,
  
  data_ana date,

  diabete_ana varchar(100),
  cardiopatia_ana varchar(100),
  obesidade_ana varchar(200),
  sintomas_ana varchar(200),
  
  tipo_ana varchar(100),
  
  peso_ana double,
  
  id_pac_fk int,
  FOREIGN KEY (id_pac_fk) REFERENCES paciente(id_pac)
);

# 15

create table agenda(
  id_age int primary key,
  
  data_age date,
  hora_age time,
  tipo_age varchar(100),
  
  previsao_duracao_age time,
  
  id_fun_fk int,
  id_pac_fk int,
  id_sal_fk int,
  
  FOREIGN KEY (id_fun_fk) REFERENCES funcionario(id_fun),
  FOREIGN KEY (id_pac_fk) REFERENCES paciente(id_pac),
  FOREIGN KEY (id_sal_fk) REFERENCES sala(id_sal)
);

# 16

create table compra_material(
  id_com_mat int primary key,
  
  id_com_fk int,
  FOREIGN KEY (id_com_fk) REFERENCES compra(id_com),
  
  id_mat_fk int,
  FOREIGN KEY (id_mat_fk) REFERENCES material(id_mat),
  
  quantidade_com_mat double
);

# 17

create table consulta_material(
  id_con_mat int primary key,
  
  id_con_fk int,
  FOREIGN KEY (id_con_fk) REFERENCES consulta(id_con),
  
  id_mat_fk int,
  FOREIGN KEY (id_mat_fk) REFERENCES material(id_mat),
  
  quantidade_con_mat double
);

# 18

create table consulta_procedimento (
  id_con_mat int primary key,
  
  id_con_fk int,
  FOREIGN KEY (id_con_fk) REFERENCES consulta(id_con),
  
  id_pro_fk int,
  FOREIGN KEY (id_pro_fk) REFERENCES procedimento(id_pro)
);

# 19

create table procedimento_material (
  id_pro_mat int primary key,
  
  id_pro_fk int,
  FOREIGN KEY (id_pro_fk) REFERENCES procedimento(id_pro),
  
  id_mat_fk int,
  FOREIGN KEY (id_mat_fk) REFERENCES material(id_mat),
  
  quantidade_pro_mat double
);

