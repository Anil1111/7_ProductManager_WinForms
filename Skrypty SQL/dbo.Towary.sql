CREATE TABLE [dbo].[Towary] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [Kod]              VARCHAR (7)     NOT NULL,
    [Nazwa]            VARCHAR (255)   NOT NULL,
    [Masa]             DECIMAL (14, 3) NULL,
    [JM]               VARCHAR (50)    NULL,
    [Data_Utworzenia]  DATETIME        NULL,
    [Data_Modyfikacji] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);