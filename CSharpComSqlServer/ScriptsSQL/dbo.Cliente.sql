﻿CREATE TABLE [dbo].[Cliente]
(
 Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 Nome VARCHAR(50),
 CPF INT,
 Telefone VARCHAR(15),
 Endereco VARCHAR(50)
)
