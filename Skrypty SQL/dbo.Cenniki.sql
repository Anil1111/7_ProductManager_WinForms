CREATE TABLE [dbo].[Cenniki] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nazwa]   VARCHAR (255) NOT NULL,
    [Data_Od] DATETIME      NULL,
    [Data_Do] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);