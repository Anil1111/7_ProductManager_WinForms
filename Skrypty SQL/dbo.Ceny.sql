CREATE TABLE [dbo].[Ceny] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [CennikId] INT NULL, 
    [TowarId] INT NULL, 
    [Cena]  DECIMAL (10, 2) NOT NULL,
    [Rabat] DECIMAL (5, 2)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Ceny_Cenniki] FOREIGN KEY ([CennikId]) REFERENCES [Cenniki]([Id]), 
    CONSTRAINT [FK_Ceny_ToTable] FOREIGN KEY ([TowarId]) REFERENCES [Towary]([Id])

);