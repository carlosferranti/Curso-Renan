-- CUIDADO AO EXECUTAR O SCRIPT INTEIRO, POIS o DATABASE SERÁ TODO APAGADO E RECRIADO
-- USE COM CAUTELA, UTILIZE PARTES DO SCRIPTS CONFORME SUA NECESSIDADE
--
-- Conteúdo de apoio para instalação do Sql Server 2019 e SQL Server Management Studio 2019: https://www.youtube.com/watch?v=LxtLqS-9KYo


use master
GO

DROP DATABASE IF EXISTS Db_Curso
GO

CREATE DATABASE Db_Curso
GO

--use Db_Curso

-- SELECT * FROM master.sys.databases ORDER BY name; -- mostra todos os banco de dados
-- GO
--

use Db_Curso;
GO

IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME = 'tbUsuario'))
BEGIN
    DROP TABLE tbUsuario;
END

CREATE TABLE tbUsuario (
    usuario_id INT PRIMARY KEY IDENTITY (1, 1),
	usuario_cpf VARCHAR (12) NOT NULL,
    usuario_nome VARCHAR (50) NOT NULL,
    usuario_endereco VARCHAR (50) NOT NULL,
    usuario_criado DATETIME,
	usuario_alterado DATETIME,    
    -- CONSTRAINT PK_Usuario PRIMARY KEY (usuario_id)
);

-- ALTER TABLE tbUsuario
-- ADD CONSTRAINT PK_Usuario PRIMARY KEY (usuario_id);
GO
--
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('11122233344', 'Tom B. Erichsen' , 'Skagen 21'       , GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('22233344455', 'Claz P. Silver'  , 'Rider 10'        , GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('33344455566', 'Mary W. Green'   , 'Bradock 38'      , GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('44455566677', 'Mary C. Gray'    , 'Dericky 2308'    , GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('55566677788', 'Billy K. Krausen', 'Slitsem Mary,280', GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('00000000000', 'Renan Simonsen'  , 'Vitory, 98'      , GETDATE(), NULL);
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('11111111111', 'Carlos Tchecovski','New Front,11'    , GETDATE(), NULL);

-- RETORNA A TABELA CRIADA COM OS NOVOS DADOS INSERIDOS:

SELECT * FROM tbUsuario
