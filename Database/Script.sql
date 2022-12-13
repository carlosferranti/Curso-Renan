use master
GO

DROP DATABASE IF EXISTS Db_Curso
GO

CREATE DATABASE Db_Curso
GO

SELECT Db_Curso FROM master.sys.databases ORDER BY name;
GO
--

use Db_Curso;
GO

IF (EXISTS (SELECT * 
                 FROM INFORMATION_SCHEMA.TABLES 
                 WHERE TABLE_NAME = N'tbUsuario'
				 AND Type = N'U'))
BEGIN
    DROP TABLE 'tbUsuario' CASCADE;
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
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('11122233344', 'Tom B. Erichsen' , 'Skagen 21'       , GETDATE(), '');
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('22233344455', 'Claz P. Silver'  , 'Rider 10'        , GETDATE(), '');
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('33344455566', 'Mary W. Green'   , 'Bradock 38'      , GETDATE(), '');
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('44455566677', 'Mary C. Gray'    , 'Dericky 2308'    , GETDATE(), '');
INSERT INTO tbUsuario (usuario_cpf, usuario_nome, usuario_endereco, usuario_criado, usuario_alterado) VALUES ('55566677788', 'Billy K. Krausen', 'Slitsem Mary,280', GETDATE(), '');


-- RETORNA A TABELA CRIADA COM OS NOVOS DADOS INSERIDOS:

SELECT * FROM tbUsuario
