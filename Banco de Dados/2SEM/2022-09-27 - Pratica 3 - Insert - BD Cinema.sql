#Banco de Dados do Cinema

drop database if exists bd_cinema;
create database bd_cinema;
use bd_cinema;

CREATE TABLE Cliente (
    id_cli INT PRIMARY KEY AUTO_INCREMENT,
    nome_cl VARCHAR(300),
    sexo_cli VARCHAR(100),
    data_nasc DATE,
    cpf_cli VARCHAR(100),
    rg_cli VARCHAR(100),
    email_cli VARCHAR(300),
    endereco_cli VARCHAR(300),
    telefone_cli VARCHAR(300),
    cartao_sus_cli VARCHAR(300),
    tipagem_sanguinea_cli VARCHAR(100)
);
INSERT INTO Cliente (id_cli, nome_cl, sexo_cli, data_nasc, cpf_cli, rg_cli, email_cli, endereco_cli, telefone_cli, tipagem_sanguinea_cli) VALUES (null, 'Clara Helena Sebastiana de Paula', 'Feminino', '1985-07-17', '873.195.292-54', '49.322.635-7', 'clara-depaula74@lordello.com.br', 'Rua Manoel das Neves Rufino, 804. Copas Verdes. Ji-Paraná - RO. Brasil.', '(69) 99890-5035', 'AB+');
INSERT INTO Cliente (id_cli, nome_cl, sexo_cli, data_nasc, cpf_cli, rg_cli, email_cli, endereco_cli, telefone_cli, tipagem_sanguinea_cli) VALUES (null, 'Theo Kauê Silveira', 'Masculino', '2004-04-14', '516.430.392-29', '30.351.029-8', 'theo-silveira99@paulistadovale.org.br', 'Rua Luziana, 339. Lagoa. Porto Velho - RO. Brasil.', '(69) 98423-9547', 'A+');
INSERT INTO Cliente (id_cli, nome_cl, sexo_cli, data_nasc, cpf_cli, rg_cli, email_cli, endereco_cli, telefone_cli, tipagem_sanguinea_cli) VALUES (null, 'Jéssica Eloá Yasmin Araújo', 'Feminino', '1948-02-04', '231.290.852-20', '25.563.676-3', 'jessica.eloa.araujo@uniube.br', 'Rua Angico, 246. Caladinho. Porto Velho - RO. Brasil.', '(69) 99345-5678', 'A+');
INSERT INTO Cliente (id_cli, nome_cl, sexo_cli, data_nasc, cpf_cli, rg_cli, email_cli, endereco_cli, telefone_cli, tipagem_sanguinea_cli) VALUES (null, 'Marcelo Benício dos Santos', 'Masculino', '1943-01-06', '442.398.732-58', '18.657.044-2', 'marcelobeniciodossantos@publiout.com.br', 'Beco Alto Paraíso, 910. Panair. Porto Velho - RO. Brasil.', '(69) 99895-2800', 'A-');
INSERT INTO Cliente (id_cli, nome_cl, sexo_cli, data_nasc, cpf_cli, rg_cli, email_cli, endereco_cli, telefone_cli, tipagem_sanguinea_cli) VALUES (null, 'Nicolas Igor Cauã da Mota', 'Masculino', '1954-08-08', '822.414.532-85', '45.115.219-0', 'nicolas-damota70@petrobrais.com.br', 'Avenida Guaporé, 112. Centro. Chupinguaia - RO. Brasil.', '(69) 98161-1073', 'AB-');
select * from Cliente;

CREATE TABLE Fornecedor (
    id_forn INT PRIMARY KEY AUTO_INCREMENT,
    nome_forn VARCHAR(300),
    razao_Social_forn VARCHAR(300),
    cnpj_forn VARCHAR(300),
    endereco_forn VARCHAR(300),
    email_forn VARCHAR(300),
    telefone_forn VARCHAR(300)
);
INSERT INTO Fornecedor VALUES (null, 'Pizzaria Céu da Boca', 'Clarice e Alana Pizzaria Delivery ME', '77.431.084/0001-42', 'Rua Abunã, 797. Olaria. Porto Velho - RO. Brasil.', 'atendimento@clariceealanapizzariadeliveryme.com.br', '(69) 98564-9634');
INSERT INTO Fornecedor VALUES (null, 'Top Frutas', 'Benjamin e Regina Alimentos Ltda', '14.311.859/0001-26', 'Rua Pérola, 825. Açaí. Ji-Paraná - RO. Brasil.', 'treinamento@benjaminereginaalimentosltda.com.br', '(69) 98923-7750');
INSERT INTO Fornecedor VALUES (null, 'Click Digital', 'Tomás e Manoel Marketing ME', '60.105.180/0001-06', 'Rua Machado de Assis, 693. Setor 06. Ariquemes - RO. Brasil.', 'seguranca@tomasemanoelmarketingme.com.br', '(69) 99143-1141');
INSERT INTO Fornecedor VALUES (null, 'RV Advogados', 'Rayssa e Valentina Advocacia ME', '38.393.634/0001-24', 'Rua Magno Arsolino, 851. Cidade Nova. Porto Velho - RO. Brasil.', 'contabil@rayssaevalentinaadvocaciame.com.br', '(69) 99730-4548');
INSERT INTO Fornecedor VALUES (null, 'Ponto Digital', 'Cláudia e Stefany Informática Ltda', '60.452.907/0001-13', 'Rua Padre Cícero, 800. Jardim Presidencial. Ji-Paraná - RO. Brasil.', 'faleconosco@claudiaestefanyinformaticaltda.com.br', '(69) 99326-7566');
select * from Fornecedor;

CREATE TABLE Despesa (
    id_desp INT PRIMARY KEY AUTO_INCREMENT,
    descricao_desp VARCHAR(300),
    valor_desp FLOAT,
    data_desp DATE,
    parcelas_desp INT,
    vencimento_desp DATE
);
INSERT INTO Despesa (id_desp, descricao_desp, valor_desp, data_desp, parcelas_desp, vencimento_desp) VALUES (null, 'Conta de Luz', 100.99, '2022-09-30', 3, '2022-10-30');
INSERT INTO Despesa (id_desp, descricao_desp, valor_desp, data_desp, parcelas_desp, vencimento_desp) VALUES (null, 'Conta de Água', 80.99, '2022-09-28', 1, '2022-10-30');
INSERT INTO Despesa (id_desp, descricao_desp, valor_desp, data_desp, parcelas_desp, vencimento_desp) VALUES (null, 'Conta de Internet', 200.99, '2022-09-24', 6, '2022-10-30');
INSERT INTO Despesa (id_desp, descricao_desp, valor_desp, data_desp, parcelas_desp, vencimento_desp) VALUES (null, 'Reposição de Estoque', 7000.99, '2022-09-26', 2, '2022-10-30');
INSERT INTO Despesa (id_desp, descricao_desp, valor_desp, data_desp, parcelas_desp, vencimento_desp) VALUES (null, 'Vencimento Funcionários', 24000.99, '2022-09-25', 1, '2022-10-30');
select * from Despesa;

CREATE TABLE Funcionario (
    id_fun INT PRIMARY KEY AUTO_INCREMENT,
    nome_fun VARCHAR(300),
    cpf_fun VARCHAR(100),
    rg_fun VARCHAR(100),
    telefone_fun VARCHAR(100),
    email_fun VARCHAR(300),
    sexo_fun VARCHAR(100),
    funcao_fun VARCHAR(300),
    salario_fun FLOAT,
    horario_entrada_fun TIME,
    horario_saida_fun TIME,
    data_nasc_fun DATE,
    carteira_trabalho VARCHAR(300)
);
INSERT INTO Funcionario (id_fun, nome_fun, sexo_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, telefone_fun) VALUES (null, 'Clarice Evelyn Eloá Souza', 'Feminino', '1959-09-03', '279.368.882-76', '49.941.685-5', 'clariceevelynsouza@kinouchi.com.br', '(69) 99305-1871');
INSERT INTO Funcionario (id_fun, nome_fun, sexo_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, telefone_fun) VALUES (null, 'Gabriela Teresinha Galvão', 'Feminino', '1973-04-18', '884.157.692-88', '47.039.874-7', 'gabriela_teresinha_galvao@tribunaimpressa.com.br', '(69) 99569-2679');
INSERT INTO Funcionario (id_fun, nome_fun, sexo_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, telefone_fun) VALUES (null, 'Letícia Josefa Baptista', 'Feminino', '1995-07-15', '181.264.472-81', '13.071.743-5', 'leticia.josefa.baptista@transtelli.com.br', '(69) 98649-2418');
INSERT INTO Funcionario (id_fun, nome_fun, sexo_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, telefone_fun) VALUES (null, 'Leonardo Leandro Kaique Martins', 'Masculino', '1967-04-13', '656.050.482-44', '21.155.432-7', 'leonardo_martins@acaoi.com.br', '(69) 98417-6668');
INSERT INTO Funcionario (id_fun, nome_fun, sexo_fun, data_nasc_fun, cpf_fun, rg_fun, email_fun, telefone_fun) VALUES (null, 'Benedito Thiago da Rosa', 'Masculino', '1961-09-10', '667.104.542-90', '42.656.376-1', 'benedito_darosa@roche.com', '(69) 99359-1786');
select * from Funcionario;

CREATE TABLE Caixa (
    id_cai INT PRIMARY KEY AUTO_INCREMENT,
    numero_cai INT,
    data_cai DATE,
    saldo_inicial_cai FLOAT,
    saldo_final_cai FLOAT,
    total_recebimentos_cai FLOAT,
    total_retiradas_cai FLOAT,
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES Funcionario (id_fun)
);
INSERT INTO Caixa VALUES (null, 1, '2022-09-20', 120.25, 300, 200, 220.25, 1);
INSERT INTO Caixa VALUES (null, 2, '2022-09-21', 0, 300, 0, 300, 2);
INSERT INTO Caixa VALUES (null, 3, '2022-09-22', 500, 0, 200, 300, 3);
INSERT INTO Caixa VALUES (null, 4, '2022-09-23', 80, 100, 100, 80, 4);
INSERT INTO Caixa VALUES (null, 5, '2022-09-24', 220.75, 100, 200, 120.75, 5);
select * from Caixa;

CREATE TABLE Pagamento (
    id_pag INT PRIMARY KEY AUTO_INCREMENT,
    valor_pag FLOAT,
    data_pag DATE,
    parcela_pag INT,
    status_pag VARCHAR(300),
    forma_pag VARCHAR(300),
    id_cai_fk INT,
    FOREIGN KEY (id_cai_fk)
        REFERENCES Caixa (id_cai),
    id_desp_fk INT,
    FOREIGN KEY (id_desp_fk)
        REFERENCES Despesa (id_desp)
);
INSERT INTO Pagamento VALUES (null, 100, '2022-09-24', 1, 'Pago', 'Dinheiro', 1, 1);
INSERT INTO Pagamento VALUES (null, 200, '2022-09-23', 2, 'A Pagar', 'Cartão', 2, 2);
INSERT INTO Pagamento VALUES (null, 300, '2022-09-22', 3, 'Pago', 'Depósito Bancário', 3, 3);
INSERT INTO Pagamento VALUES (null, 400, '2022-09-21', 4, 'A Pagar', 'Pix', 4, 4);
INSERT INTO Pagamento VALUES (null, 500, '2022-09-20', 5, 'Pago', 'Dinheiro', 5, 5);
select * from Pagamento;

CREATE TABLE Filme (
    id_film INT PRIMARY KEY AUTO_INCREMENT,
    titulo_film VARCHAR(300),
    sinopse_film VARCHAR(500),
    atores_film VARCHAR(300),
    diretor_film VARCHAR(300),
    genero_film VARCHAR(300),
    classificacao_indicativa_film VARCHAR(300),
    duracao_film TIME
);
INSERT INTO Filme (id_film, titulo_film, sinopse_film, atores_film, diretor_film, genero_film, classificacao_indicativa_film, duracao_film) VALUES (null, 'Um Sonho de Liberdade', 'Dois homens presos se reúnem ao longo de vários anos, encontrando consolo e eventual redenção através de atos de decência comum.', 'Tim Robbins; Morgan Freeman; Bob Gunton', 'Frank Darabont', 'Drama', '16', '02:22');
INSERT INTO Filme (id_film, titulo_film, sinopse_film, atores_film, diretor_film, genero_film, classificacao_indicativa_film, duracao_film) VALUES (null, '12 Homens e uma Sentença', 'Um jurado que se aposenta tenta evitar um erro judicial forçando seus colegas a reconsiderarem as evidências.', 'Henry Fonda; Lee J. Cobb; Martin Balsam', 'Sidney Lumet', 'Drama; Policial;', 'Livre', '01:36');
INSERT INTO Filme (id_film, titulo_film, sinopse_film, atores_film, diretor_film, genero_film, classificacao_indicativa_film, duracao_film) VALUES (null, 'O Poderoso Chefão II', 'Em 1950, Michael Corleone, agora à frente da família, tenta expandir o negócio do crime a Las Vegas, Los Angeles e Cuba. Paralelamente, é revelada a história de Vito Corleone, e de como saiu da Sicília e chegou a Nova Iorque.', 'Al Pacino; Robert De Niro; Robert Duvall', 'Francis Ford Coppola', 'Drama; Policial;', '14', '03:22');
INSERT INTO Filme (id_film, titulo_film, sinopse_film, atores_film, diretor_film, genero_film, classificacao_indicativa_film, duracao_film) VALUES (null, 'Batman: O Cavaleiro das Trevas', 'Quando a ameaça conhecida como O Coringa surge de seu passado, causa estragos e caos nas pessoas de Gotham. O Cavaleiro das Trevas deve aceitar um dos maiores testes para combater a injustiça.', 'Christian Bale; Heath Ledger; Aaron Eckhart', 'Christopher Nolan', 'Drama; Policial; Ação', '12', '02:32');
INSERT INTO Filme (id_film, titulo_film, sinopse_film, atores_film, diretor_film, genero_film, classificacao_indicativa_film, duracao_film) VALUES (null, 'A Lista de Schindler', 'Depois de testemunhar a perseguição dos judaicos na Polônia ocupada pelos alemães durante a Segunda Guerra Mundial, o industrial Oskar Schindler se começa a preocupar com sua força de trabalho judaica.', 'Liam Neeson; Ralph Fiennes; Ben Kingsley', 'Steven Spielberg', 'Drama; História; Biografia', '14', '03:15');
select * from Filme;

CREATE TABLE Sala (
    id_sala INT PRIMARY KEY AUTO_INCREMENT,
    nome_sala VARCHAR(300),
    numero_sala INT,
    capacidade_sala VARCHAR(300),
    local_sala VARCHAR(300)
);
INSERT INTO Sala values (null, 'Sala A', 1, 30, 'A primeira sala.');
INSERT INTO Sala values (null, 'Sala B', 2, 35, 'A segunda sala.');
INSERT INTO Sala values (null, 'Sala C', 3, 80, 'A terceira sala.');
INSERT INTO Sala values (null, 'Sala D', 4, 85, 'A quarta sala.');
INSERT INTO Sala values (null, 'Sala E', 5, 85, 'A quinta sala.');
select * from Sala;

CREATE TABLE Poltrona (
    id_polt INT PRIMARY KEY AUTO_INCREMENT,
    numero_polt INT,
    fileira_polt INT,
    coordenada_polt VARCHAR(100),
    status_polt VARCHAR(100),
    id_sala_fk INT,
    FOREIGN KEY (id_sala_fk)
        REFERENCES Sala (id_sala)
);
INSERT INTO Poltrona (id_polt, numero_polt, fileira_polt, coordenada_polt, status_polt, id_sala_fk) VALUES (null, 1, 1, null, 'Ocupada', 1);
INSERT INTO Poltrona (id_polt, numero_polt, fileira_polt, coordenada_polt, status_polt, id_sala_fk) VALUES (null, 2, 1, null, 'Vazia', 1);
INSERT INTO Poltrona (id_polt, numero_polt, fileira_polt, coordenada_polt, status_polt, id_sala_fk) VALUES (null, 3, 1, null, 'Ocupada', 1);
INSERT INTO Poltrona (id_polt, numero_polt, fileira_polt, coordenada_polt, status_polt, id_sala_fk) VALUES (null, 4, 1, null, 'Vazia', 1);
INSERT INTO Poltrona (id_polt, numero_polt, fileira_polt, coordenada_polt, status_polt, id_sala_fk) VALUES (null, 5, 1, null, 'Vazia', 1);
select * from Poltrona;

CREATE TABLE Sessao (
    id_ses INT PRIMARY KEY AUTO_INCREMENT,
    hora_inicio_ses TIME,
    data_ses DATE,
    hora_fim_ses TIME,
    id_sala_fk INT,
    FOREIGN KEY (id_sala_fk)
        REFERENCES Sala (id_sala),
    id_film_fk INT,
    FOREIGN KEY (id_film_fk)
        REFERENCES Filme (id_film)
);
INSERT INTO Sessao VALUES (null, '17:30', '2022-09-27', '19:00', 1, 1);
INSERT INTO Sessao VALUES (null, '17:30', '2022-09-27', '19:00', 2, 2);
INSERT INTO Sessao VALUES (null, '17:30', '2022-09-27', '19:00', 3, 3);
INSERT INTO Sessao VALUES (null, '17:30', '2022-09-27', '19:00', 4, 4);
INSERT INTO Sessao VALUES (null, '17:30', '2022-09-27', '19:00', 5, 5);
select * from Sessao;

CREATE TABLE Ingresso (
    id_ing INT PRIMARY KEY AUTO_INCREMENT,
    valor_ing FLOAT,
    data_ing DATE,
    cod_barras_ing VARCHAR(300),
    id_ses_fk INT,
    FOREIGN KEY (id_ses_fk)
        REFERENCES Sessao (id_ses)
);
INSERT INTO Ingresso (id_ing, valor_ing, data_ing, cod_barras_ing, id_ses_fk) VALUES (null, 20.00, '2022-09-27', '12348901230948712390', 1);
INSERT INTO Ingresso (id_ing, valor_ing, data_ing, cod_barras_ing, id_ses_fk) VALUES (null, 20.00, '2022-09-27', '13456534523459028340', 2);
INSERT INTO Ingresso (id_ing, valor_ing, data_ing, cod_barras_ing, id_ses_fk) VALUES (null, 20.00, '2022-09-27', '57902904592034950234', 3);
INSERT INTO Ingresso (id_ing, valor_ing, data_ing, cod_barras_ing, id_ses_fk) VALUES (null, 20.00, '2022-09-27', '69829083409580495895', 4);
INSERT INTO Ingresso (id_ing, valor_ing, data_ing, cod_barras_ing, id_ses_fk) VALUES (null, 20.00, '2022-09-27', '41591872349874987438', 5);
select * from Ingresso;

CREATE TABLE Venda (
    id_vend INT PRIMARY KEY AUTO_INCREMENT,
    valor_vend FLOAT,
    hora_vend TIME,
    data_vend DATE,
    id_polt_fk INT,
    FOREIGN KEY (id_polt_fk)
        REFERENCES Poltrona (id_polt),
    id_ing_fk INT,
    FOREIGN KEY (id_ing_fk)
        REFERENCES Ingresso (id_ing),
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES Funcionario (id_fun),
    id_cli_fk INT,
    FOREIGN KEY (id_cli_fk)
        REFERENCES Cliente (id_cli)
);
INSERT INTO Venda VALUES (null, 20.00, '16:40', '2022-09-26', 1, 1, 1, 1);
INSERT INTO Venda VALUES (null, 20.00, '12:40', '2022-09-26', 2, 2, 2, 2);
INSERT INTO Venda VALUES (null, 20.00, '15:40', '2022-09-26', 3, 3, 3, 3);
INSERT INTO Venda VALUES (null, 20.00, '12:40', '2022-09-26', 4, 4, 4, 4);
INSERT INTO Venda VALUES (null, 20.00, '18:40', '2022-09-26', 5, 5, 5, 5);
select * from Venda;

CREATE TABLE Produto (
    id_prod INT PRIMARY KEY AUTO_INCREMENT,
    nome_prod VARCHAR(300),
    marca_prod VARCHAR(300),
    valor_venda_prod FLOAT,
    valor_compra_prod FLOAT,
    estoque_prod INT,
    tipo_prod VARCHAR(300),
    descricao_prod VARCHAR(300)
);
INSERT INTO Produto (id_prod, nome_prod, marca_prod, valor_venda_prod, valor_compra_prod, estoque_prod, tipo_prod, descricao_prod) VALUES (null, 'Refrigerante Coca-Cola 2L', 'Coca-Cola', 7, 4, 100, 'Frios', 'Refrigerante coca.');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, valor_venda_prod, valor_compra_prod, estoque_prod, tipo_prod, descricao_prod) VALUES (null, 'Pipoca Pequena', 'Campilar', 7, 2, 100, 'Alimentos', 'Pipoca feita na hora. Tamanho pequeno.');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, valor_venda_prod, valor_compra_prod, estoque_prod, tipo_prod, descricao_prod) VALUES (null, 'Pipoca Média', 'Campilar', 10, 3, 100, 'Alimentos', 'Pipoca feita na hora. Tamanho médio.');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, valor_venda_prod, valor_compra_prod, estoque_prod, tipo_prod, descricao_prod) VALUES (null, 'Pipoca Grande', 'Campilar', 13, 4, 100, 'Alimentos', 'Pipoca feita na hora. Tamanho grande.');
INSERT INTO Produto (id_prod, nome_prod, marca_prod, valor_venda_prod, valor_compra_prod, estoque_prod, tipo_prod, descricao_prod) VALUES (null, 'Água com Gás 500 mL', 'Lind\'água', 3, 1, 100, 'Frios', 'Água gaseificada.');
select * from Produto;

CREATE TABLE Venda_Produto (
    id_vend_prod INT PRIMARY KEY AUTO_INCREMENT,
    qtd_itens_vend_prod INT,
    valor_vend_prod FLOAT,
    id_prod_fk INT,
    FOREIGN KEY (id_prod_fk)
        REFERENCES Produto (id_prod),
    id_vend_fk INT,
    FOREIGN KEY (id_vend_fk)
        REFERENCES Venda (id_vend)
);
INSERT INTO Venda_Produto VALUES (null, 2, 14, 1, 5);
INSERT INTO Venda_Produto VALUES (null, 1, 7, 2, 4);
INSERT INTO Venda_Produto VALUES (null, 1, 10, 3, 3);
INSERT INTO Venda_Produto VALUES (null, 1, 13, 4, 2);
INSERT INTO Venda_Produto VALUES (null, 1, 3, 5, 1);
select * from Venda_Produto;

CREATE TABLE Compra (
    id_comp INT PRIMARY KEY AUTO_INCREMENT,
    valor_comp FLOAT,
    hora_comp TIME,
    data_comp DATE,
    id_fun_fk INT,
    FOREIGN KEY (id_fun_fk)
        REFERENCES Funcionario (id_fun),
    id_forn_fk INT,
    FOREIGN KEY (id_forn_fk)
        REFERENCES Fornecedor (id_forn)
);
INSERT INTO Compra VALUES (null, 20.00, '16:40', '2022-09-26', 1, 1);
INSERT INTO Compra VALUES (null, 20.00, '12:40', '2022-09-26', 2, 2);
INSERT INTO Compra VALUES (null, 20.00, '15:40', '2022-09-26', 3, 3);
INSERT INTO Compra VALUES (null, 20.00, '12:40', '2022-09-26', 4, 4);
INSERT INTO Compra VALUES (null, 20.00, '18:40', '2022-09-26', 5, 5);
select * from Compra;

CREATE TABLE Compra_Produto (
    id_vend_comp INT PRIMARY KEY AUTO_INCREMENT,
    qtd_itens_comp_prod INT,
    valor_comp_prod FLOAT,
    id_prod_fk INT,
    FOREIGN KEY (id_prod_fk)
        REFERENCES Produto (id_prod),
    id_comp_fk INT,
    FOREIGN KEY (id_comp_fk)
        REFERENCES Compra (id_comp)
);
INSERT INTO Compra_Produto VALUES (null, 2, 14, 1, 5);
INSERT INTO Compra_Produto VALUES (null, 1, 7, 2, 4);
INSERT INTO Compra_Produto VALUES (null, 1, 10, 3, 3);
INSERT INTO Compra_Produto VALUES (null, 1, 13, 4, 2);
INSERT INTO Compra_Produto VALUES (null, 1, 3, 5, 1);
select * from Compra_Produto;




