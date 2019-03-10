CREATE TABLE [dbo].[tblClientes] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (50) NULL,
    [CPF]            VARCHAR (15) NULL,
    [Endereco] VARCHAR(50) NULL, 
    [Telefone] VARBINARY(15) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

