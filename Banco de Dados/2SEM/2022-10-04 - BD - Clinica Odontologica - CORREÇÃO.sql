#CLINICA ODONTOLOGICA

drop database if exists BD_Clinica_Odontologica;

create database BD_Clinica_Odontologica;
use BD_Clinica_Odontologica;

create table Paciente(
pac_id int primary key auto_increment,
pac_nome varchar (300),
pac_cpf varchar (100),
pac_data_nascimento date,
pac_email varchar (300),
pac_celular varchar (100),
pac_endereco varchar (300)
);

INSERT INTO Paciente VALUES (null, 'Clara Helena Sebastiana de Paula', '873.195.292-54', '1985-07-17', 'clara-depaula74@lordello.com.br', '(69) 99890-5035', 'Rua Manoel das Neves Rufino, 804. Copas Verdes. Ji-Paraná - RO. Brasil.');
INSERT INTO Paciente VALUES (null, 'Theo Kauê Silveira', '516.430.392-29', '2004-04-14', 'theo-silveira99@paulistadovale.org.br', '(69) 98423-9547', 'Rua Luziana, 339. Lagoa. Porto Velho - RO. Brasil.');
INSERT INTO Paciente VALUES (null, 'Jéssica Eloá Yasmin Araújo', '231.290.852-20', '1948-02-04', 'jessica.eloa.araujo@uniube.br', '(69) 99345-5678', 'Rua Angico, 246. Caladinho. Porto Velho - RO. Brasil.');
INSERT INTO Paciente VALUES (null, 'Marcelo Benício dos Santos', '442.398.732-58', '1943-01-06', 'marcelobeniciodossantos@publiout.com.br', '(69) 99895-2800', 'Beco Alto Paraíso, 910. Panair. Porto Velho - RO. Brasil.');
INSERT INTO Paciente VALUES (null, 'Nicolas Igor Cauã da Mota', '822.414.532-85', '1954-08-08', 'nicolas-damota70@petrobrais.com.br', '(69) 98161-1073', 'Avenida Guaporé, 112. Centro. Chupinguaia - RO. Brasil.');

select * from Paciente;

create table Anamnese(
ana_id int primary key auto_increment,
ana_data date,
ana_diabete varchar (100),
ana_cardiopatia varchar (300),
ana_obesidade varchar (300),
ana_sintomas varchar (1000),
ana_tipo varchar (100),
id_pac_fk int,
foreign key (id_pac_fk) references Paciente (pac_id)
);

insert into Anamnese (ana_id, ana_data, ana_diabete, ana_cardiopatia, ana_obesidade, ana_sintomas, ana_tipo, id_pac_fk) VALUES (null, '2022-10-02', 'Sim', 'Não', 'Não', 'Nenhum', 'Normal', 1);
insert into Anamnese (ana_id, ana_data, ana_diabete, ana_cardiopatia, ana_obesidade, ana_sintomas, ana_tipo, id_pac_fk) VALUES (null, '2022-10-02', 'Não', 'Não', 'Sim', 'Dor localizada', 'Normal', 2);
insert into Anamnese (ana_id, ana_data, ana_diabete, ana_cardiopatia, ana_obesidade, ana_sintomas, ana_tipo, id_pac_fk) VALUES (null, '2022-10-02', 'Sim', 'Não', 'Normal', 'Afta', 'Autismo tipo 1', 3);
insert into Anamnese (ana_id, ana_data, ana_diabete, ana_cardiopatia, ana_obesidade, ana_sintomas, ana_tipo, id_pac_fk) VALUES (null, '2022-10-02', 'Sim', 'Sim', 'Sim', 'Sangramento', 'Normal', 4);
insert into Anamnese (ana_id, ana_data, ana_diabete, ana_cardiopatia, ana_obesidade, ana_sintomas, ana_tipo, id_pac_fk) VALUES (null, '2022-10-02', 'Não', 'Não', 'Não', 'Sensibilidade', 'Normal', 5);

select * from Anamnese;

create table Odontograma(
odo_id int primary key auto_increment,
ono_incisivo_lateral varchar(40),
ono_1_molar varchar(40),
ono_canino varchar(40),
ono_2_molar varchar(40),
ono_incisivo_central varchar(40),
ono_2_premolar varchar(40),
ono_1_premolar varchar(40),
ono_3_molar varchar(40),
id_pac_fk int,
foreign key (id_pac_fk) references Paciente (pac_id)
);

insert into Odontograma VALUES (null, 'Bom', 'Com Cárie', 'Ótimo', 'Quebrado', 'Prótese', 'Implante', 'Bom', 'Bom', 1);
insert into Odontograma VALUES (null, 'Bom', 'Bom', 'Bom', 'Com Cárie', 'Com Cárie', 'Quebrado', 'Bom', 'Ruim', 2);
insert into Odontograma VALUES (null, 'Quebrado', 'Com Cárie', 'Ótimo', 'Ruim', 'Bom', 'Quebrado', 'Implante', 'Prótese', 3);
insert into Odontograma VALUES (null, 'Bom', 'Com Cárie', 'Ótimo', 'Quebrado', 'Ruim', 'Ruim', 'Ruim', 'Ruim', 4);
insert into Odontograma VALUES (null, 'Com Cárie', 'Ótimo', 'Bom', 'Prótese', 'Bom', 'Regular', 'Prótese', 'Regular', 5);

select * from Odontograma;

create table Funcionario(
fun_id int primary key auto_increment,
fun_nome varchar (300),
fun_especialidade varchar (300),
fun_cpf varchar (100),
fun_rg varchar (100),
fun_funcao varchar (300),
fun_data_nascimento date,
fun_celular varchar (100),
fun_endereco varchar (300),
fun_email varchar (300)
);

INSERT INTO Funcionario (fun_id, fun_nome, fun_especialidade, fun_cpf, fun_rg, fun_funcao, fun_data_nascimento, fun_celular, fun_email) VALUES (null, 'Clarice Evelyn Eloá Souza', 'Clínico Geral', '279.368.882-76', '49.941.685-5', 'Dentista', '1959-09-03', '(69) 99305-1871', 'clariceevelynsouza@kinouchi.com.br');
INSERT INTO Funcionario (fun_id, fun_nome, fun_especialidade, fun_cpf, fun_rg, fun_funcao, fun_data_nascimento, fun_celular, fun_email) VALUES (null, 'Gabriela Teresinha Galvão', 'Gestão Financeira', '884.157.692-88', '47.039.874-7', 'Secretário', '1973-04-18', '(69) 99569-2679', 'gabriela_teresinha_galvao@tribunaimpressa.com.br');
INSERT INTO Funcionario (fun_id, fun_nome, fun_especialidade, fun_cpf, fun_rg, fun_funcao, fun_data_nascimento, fun_celular, fun_email) VALUES (null, 'Letícia Josefa Baptista', 'Clínico Geral', '181.264.472-81', '13.071.743-5', 'Dentista', '1995-07-15', '(69) 98649-2418', 'leticia.josefa.baptista@transtelli.com.br');
INSERT INTO Funcionario (fun_id, fun_nome, fun_especialidade, fun_cpf, fun_rg, fun_funcao, fun_data_nascimento, fun_celular, fun_email) VALUES (null, 'Leonardo Leandro Kaique Martins', 'Administração', '656.050.482-44', '21.155.432-7', 'Gerente', '1967-04-13', '(69) 98417-6668', 'leonardo_martins@acaoi.com.br');
INSERT INTO Funcionario (fun_id, fun_nome, fun_especialidade, fun_cpf, fun_rg, fun_funcao, fun_data_nascimento, fun_celular, fun_email) VALUES (null, 'Benedito Thiago da Rosa', 'Nenhuma', '667.104.542-90', '42.656.376-1', 'Faxineiro', '1961-09-10', '(69) 99359-1786', 'benedito_darosa@roche.com');

select * from Funcionario;

create table Sala(
sal_id int primary key auto_increment,
sal_nome varchar (301),
sal_equipamentos varchar (1001),
sal_capacidade int
);

insert into Sala VALUES (null, 'Recepção', 'Computador; Cadeiras; Bebedouro;', 15);
insert into Sala VALUES (null, 'Banheiro', 'Pia; Vaso; Chuveiro;', 2);
insert into Sala VALUES (null, 'Consultório 1', 'Computador; Equipamentos', 4);
insert into Sala VALUES (null, 'Consultório 2', 'Computador; Equipamentos', 3);
insert into Sala VALUES (null, 'Direção', 'Todos', 5);

select * from Sala;

create table Caixa(
cai_id int primary key auto_increment,
cai_data date,
cai_saldo_inicial double,
cai_total_entrada double,
cai_total_saida double,
cai_saldo_final double
);

INSERT INTO Caixa VALUES (null, '2022-09-20', 120.25, 200, 220.25, 300);
INSERT INTO Caixa VALUES (null, '2022-09-21', 0, 0, 300, 300);
INSERT INTO Caixa VALUES (null, '2022-09-22', 500, 200, 300, 0);
INSERT INTO Caixa VALUES (null, '2022-09-23', 80, 100, 80,100);
INSERT INTO Caixa VALUES (null, '2022-09-24', 220.75, 200, 120.75, 100);

select * from Caixa;

create table Fornecedor(
for_id int primary key auto_increment,
for_razao_social varchar (300),
for_nome_santasia varchar (300),
for_cnpj varchar (300),
for_endereco varchar (300),
for_contato varchar (100)
);

INSERT INTO Fornecedor (for_id, for_nome_santasia, for_razao_social, for_cnpj, for_endereco, for_contato) VALUES (null, 'Pizzaria Céu da Boca', 'Clarice e Alana Pizzaria Delivery ME', '77.431.084/0001-42', 'Rua Abunã, 797. Olaria. Porto Velho - RO. Brasil.', 'atendimento@clariceealanapizzariadeliveryme.com.br; (69) 98564-9634');
INSERT INTO Fornecedor (for_id, for_nome_santasia, for_razao_social, for_cnpj, for_endereco, for_contato) VALUES (null, 'Top Frutas', 'Benjamin e Regina Alimentos Ltda', '14.311.859/0001-26', 'Rua Pérola, 825. Açaí. Ji-Paraná - RO. Brasil.', 'treinamento@benjaminereginaalimentosltda.com.br; (69) 98923-7750');
INSERT INTO Fornecedor (for_id, for_nome_santasia, for_razao_social, for_cnpj, for_endereco, for_contato) VALUES (null, 'Click Digital', 'Tomás e Manoel Marketing ME', '60.105.180/0001-06', 'Rua Machado de Assis, 693. Setor 06. Ariquemes - RO. Brasil.', 'seguranca@tomasemanoelmarketingme.com.br; (69) 99143-1141');
INSERT INTO Fornecedor (for_id, for_nome_santasia, for_razao_social, for_cnpj, for_endereco, for_contato) VALUES (null, 'RV Advogados', 'Rayssa e Valentina Advocacia ME', '38.393.634/0001-24', 'Rua Magno Arsolino, 851. Cidade Nova. Porto Velho - RO. Brasil.', 'contabil@rayssaevalentinaadvocaciame.com.br; (69) 99730-4548');
INSERT INTO Fornecedor (for_id, for_nome_santasia, for_razao_social, for_cnpj, for_endereco, for_contato) VALUES (null, 'Ponto Digital', 'Cláudia e Stefany Informática Ltda', '60.452.907/0001-13', 'Rua Padre Cícero, 800. Jardim Presidencial. Ji-Paraná - RO. Brasil.', 'faleconosco@claudiaestefanyinformaticaltda.com.br; (69) 99326-7566');

select * from Fornecedor;

create table Despesa(
des_id int primary key auto_increment,
des_nome varchar (301),
des_data date,
des_vencimento date,
des_parcelamento INT
);

INSERT INTO Despesa (des_id, des_nome, des_data, des_parcelamento, des_vencimento) VALUES (null, 'Conta de Luz', '2022-09-30', 3, '2022-10-30');
INSERT INTO Despesa (des_id, des_nome, des_data, des_parcelamento, des_vencimento) VALUES (null, 'Conta de Água', '2022-09-28', 1, '2022-10-30');
INSERT INTO Despesa (des_id, des_nome, des_data, des_parcelamento, des_vencimento) VALUES (null, 'Conta de Internet', '2022-09-24', 6, '2022-10-30');
INSERT INTO Despesa (des_id, des_nome, des_data, des_parcelamento, des_vencimento) VALUES (null, 'Reposição de Estoque', '2022-09-26', 2, '2022-10-30');
INSERT INTO Despesa (des_id, des_nome, des_data, des_parcelamento, des_vencimento) VALUES (null, 'Vencimento Funcionários', '2022-09-25', 1, '2022-10-30');

select * from Despesa;

create table Agenda(
age_id int primary key auto_increment,
age_data_hora datetime,
age_tipo varchar (301),
id_pac_fk int,
id_fun_fk int,
id_sal_fk int,
foreign key (id_pac_fk) references Paciente (pac_id),
foreign key (id_fun_fk) references Funcionario (fun_id),
foreign key (id_sal_fk) references Sala (sal_id)
);

insert into Agenda VALUES (null, '2022-10-04 14:30', 'Orçamento', 1, 1, 2);
insert into Agenda VALUES (null, '2022-10-03 14:30', 'Consulta', 2, 2, 2);
insert into Agenda VALUES (null, '2022-10-02 14:30', 'Limpeza', 3, 3, 2);
insert into Agenda VALUES (null, '2022-10-01 14:30', 'Canal', 4, 4, 2);
insert into Agenda VALUES (null, '2022-10-05 14:30', 'Prótese', 5, 5, 2);

select * from Agenda;

create table Pagamento(
pag_id int primary key AUTO_INCREMENT,
pag_parcela varchar (301),
pag_status varchar (301),
pag_forma varchar (300),
pag_data date,
pag_valor double,
id_cai_fk int,
id_des_fk int,
foreign key (id_cai_fk) references Caixa (cai_id),
foreign key (id_des_fk) references Despesa (des_id)
);

INSERT INTO Pagamento VALUES (null, 1, 'Pago', 'Dinheiro', '2022-09-24', 100, 1, 1);
INSERT INTO Pagamento VALUES (null, 2, 'A Pagar', 'Cartão', '2022-09-23', 200, 2, 2);
INSERT INTO Pagamento VALUES (null, 3, 'Pago', 'Depósito Bancário', '2022-09-22', 300, 3, 3);
INSERT INTO Pagamento VALUES (null, 4, 'A Pagar', 'Pix', '2022-09-21', 400, 4, 4);
INSERT INTO Pagamento VALUES (null, 5, 'Pago', 'Dinheiro', '2022-09-20', 500, 5, 5);

select * from Pagamento;

create table Consulta(
con_id int primary key auto_increment,
con_valor double,
con_data_tempo datetime,
id_pac_fk int,
id_odo_fk int,
id_fun_fk int,
id_sal_fk int,
foreign key (id_pac_fk) references Paciente (pac_id),
foreign key (id_odo_fk) references Odontograma (odo_id),
foreign key (id_fun_fk) references Funcionario (fun_id),
foreign key (id_sal_fk) references Sala (sal_id)
);

insert into Consulta VALUES (null, 0, '2022-10-04 15:30', 1, 1, 1, 2);
insert into Consulta VALUES (null, 100, '2022-10-03 15:30', 2, 1, 2, 2);
insert into Consulta VALUES (null, 200, '2022-10-02 15:30', 3, 1, 3, 2);
insert into Consulta VALUES (null, 300, '2022-10-01 15:30', 3, 1, 3, 2);
insert into Consulta VALUES (null, 400, '2022-10-05 15:30', 3, 1, 3, 2);

select * from Consulta;

create table Material(
mat_id int primary key auto_increment,
mat_nome varchar (300),
mat_descricao varchar (1000),
mat_estoque int,
mat_valor double,
mat_tipo varchar (300)
);

INSERT INTO Material (mat_id, mat_nome, mat_descricao, mat_estoque, mat_valor, mat_tipo) VALUES (null, 'Pasta de Dente', 'Pasta de Dente X 100g', 20, 3.20, 'Higiene');
INSERT INTO Material (mat_id, mat_nome, mat_descricao, mat_estoque, mat_valor, mat_tipo) VALUES (null, 'Escova de Dente', 'Escova de Dente X', 3, 1.20, 'Higiene');
INSERT INTO Material (mat_id, mat_nome, mat_descricao, mat_estoque, mat_valor, mat_tipo) VALUES (null, 'Água com Gás', 'Água com Gás', 20, 2.20, 'Água');
INSERT INTO Material (mat_id, mat_nome, mat_descricao, mat_estoque, mat_valor, mat_tipo) VALUES (null, 'Fio Dental', 'Fio Dental', 6, 5.20, 'Higiene');
INSERT INTO Material (mat_id, mat_nome, mat_descricao, mat_estoque, mat_valor, mat_tipo) VALUES (null, 'Escova de Dente 2', 'Escova de Dente Y', 20, 2.10, 'Higiene');

select * from Material;

create table Compra (
com_id int primary key auto_increment,
com_data date,
com_valor double,
id_for_fk int,
foreign key (id_for_fk) references Fornecedor (for_id)
);

INSERT INTO Compra VALUES (null, '2022-09-15', 400, 1);
INSERT INTO Compra VALUES (null, '2022-09-16', 400, 2);
INSERT INTO Compra VALUES (null, '2022-09-17', 400, 3);
INSERT INTO Compra VALUES (null, '2022-09-18', 400, 4);
INSERT INTO Compra VALUES (null, '2022-09-19', 400, 5);

select * from Compra;

create table Material_Compra (
mat_com_id int primary key auto_increment,
id_com_fk int,
id_mat_fk int,
foreign key (id_com_fk) references Compra (com_id),
foreign key (id_mat_fk) references Material (mat_id)
);

INSERT INTO Material_Compra VALUES (null, 1, 1);
INSERT INTO Material_Compra VALUES (null, 2, 2);
INSERT INTO Material_Compra VALUES (null, 3, 3);
INSERT INTO Material_Compra VALUES (null, 4, 4);
INSERT INTO Material_Compra VALUES (null, 5, 5);

SELECT * FROM Material_Compra;

create table Recebimento(
rec_id int primary key auto_increment,
rec_parcela int,
rec_status varchar (300),
rec_forma varchar (300),
rec_data date,
rec_valor double,
id_con_fk int,
id_cai_fk int,
foreign key (id_con_fk) references Consulta (con_id),
foreign key (id_cai_fk) references Caixa (cai_id)
);

INSERT INTO Recebimento VALUES (null, 1, 'A Receber', null, '2022-10-10', 100, 1, 1);
INSERT INTO Recebimento VALUES (null, 2, 'Recebido', null, '2022-10-15', 100, 1, 2);
INSERT INTO Recebimento VALUES (null, 3, 'A Receber', null, '2022-10-20', 100, 1, 3);
INSERT INTO Recebimento VALUES (null, 4, 'Recebido', null, '2022-10-25', 100, 1, 4);
INSERT INTO Recebimento VALUES (null, 5, 'A Receber', null, '2022-10-30', 100, 1, 5);

select * from Recebimento;

create table Procedimento(
pro_id int primary key auto_increment,
pro_valor double,
pro_nome varchar (300),
pro_descricao varchar (1000),
pro_tempo time,
pro_tipo varchar (300),
pro_requisitos varchar (300)
);

INSERT INTO Procedimento VALUES (null, 100, 'Limpeza', 'Limpeza Bucal', '00:30', null, null);
INSERT INTO Procedimento VALUES (null, 600.99, 'Implante', 'Implantação de um dente', '01:00', null, null);
INSERT INTO Procedimento VALUES (null, 200.99, 'Canal', 'Procedimento para fazer um canal', '01:00', null, null);
INSERT INTO Procedimento VALUES (null, 50.99, 'Retirada de Dente', 'Procedimento para retirar um dente', '00:30', null, null);
INSERT INTO Procedimento VALUES (null, 400.99, 'Prótese', 'Procedimento para fazer uma prótese', '00:30', null, null);

select * from Procedimento;

create table Consulta_Procedimento(
con_pro_id int primary key auto_increment,
id_con_fk int,
id_pro_fk int,
foreign key (id_con_fk) references Consulta (con_id),
foreign key (id_pro_fk) references Procedimento (pro_id)
);

insert into Consulta_Procedimento VALUES (null, 1, 5);
insert into Consulta_Procedimento VALUES (null, 2, 4);
insert into Consulta_Procedimento VALUES (null, 3, 3);
insert into Consulta_Procedimento VALUES (null, 4, 2);
insert into Consulta_Procedimento VALUES (null, 5, 1);

select * from Consulta_Procedimento;

create table Material_Consulta (
mat_con_id int primary key auto_increment,
id_con_fk int,
id_mat_fk int,
foreign key (id_con_fk) references Consulta (con_id),
foreign key (id_mat_fk) references Material (mat_id)
);

insert into Material_Consulta VALUES (null, 1, 5);
insert into Material_Consulta VALUES (null, 2, 4);
insert into Material_Consulta VALUES (null, 3, 3);
insert into Material_Consulta VALUES (null, 4, 2);
insert into Material_Consulta VALUES (null, 5, 1);

select * from Material_Consulta;

create table Material_Procedimento(
mat_pro_id int primary key auto_increment,
id_mat_fk int,
id_pro_fk int,
foreign key (id_mat_fk) references Material (mat_id),
foreign key (id_pro_fk) references Procedimento (pro_id)
);

insert into Material_Procedimento VALUES (null, 1, 5);
insert into Material_Procedimento VALUES (null, 2, 4);
insert into Material_Procedimento VALUES (null, 3, 3);
insert into Material_Procedimento VALUES (null, 4, 2);
insert into Material_Procedimento VALUES (null, 5, 1);

select * from Material_Procedimento;