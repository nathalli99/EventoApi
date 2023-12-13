IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [TB_EVENTOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Data] datetime2 NOT NULL,
    [Local] nvarchar(max) NOT NULL,
    [Artista] nvarchar(max) NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_TB_EVENTOS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artista', N'Classe', N'Data', N'Local', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_EVENTOS]'))
    SET IDENTITY_INSERT [TB_EVENTOS] ON;
INSERT INTO [TB_EVENTOS] ([Id], [Artista], [Classe], [Data], [Local], [Nome])
VALUES (1, N'NCT 127', 1, '2023-01-18T00:00:00.0000000', N'São Paulo, Vibra', N'Neo City: The Link Tour'),
(2, N'NCT DREAM', 1, '2023-07-04T00:00:00.0000000', N'São Paulo, Vibra', N'The Dream Show II: In A Dream'),
(3, N'ATEEZ', 1, '2023-08-26T00:00:00.0000000', N'São Paulo, Allianz Parque', N'The Fellowship: Break the Wall Tour'),
(4, N'Bruno Mars, Post Malone...', 2, '2023-09-02T00:00:00.0000000', N'São Paulo, Autódromo de Interlagos', N'THE TOWN'),
(5, N'aespa', 1, '2023-09-11T00:00:00.0000000', N'São Paulo, Espaço Unimed', N'Synk: Hyper Line Tour'),
(6, N'Evanescence', 1, '2023-10-21T00:00:00.0000000', N'São Paulo, Allianz Parque', N'South American Tour'),
(7, N'RBD', 1, '2023-11-17T00:00:00.0000000', N'São Paulo, Allianz Parque', N'Soy Rebelde Tour'),
(8, N'Taylor Swift', 1, '2023-11-25T00:00:00.0000000', N'São Paulo, Allianz Parque', N'The Eras Tour'),
(9, N'TWICE', 1, '2024-02-07T00:00:00.0000000', N'São Paulo, Allianz Parque', N'Ready To Be'),
(10, N'IVE', 1, '2024-06-26T00:00:00.0000000', N'São Paulo, Espaço Unimed', N'SHOW WHAT I HAVE');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artista', N'Classe', N'Data', N'Local', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_EVENTOS]'))
    SET IDENTITY_INSERT [TB_EVENTOS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231213020426_InitialCreate', N'7.0.0');
GO

COMMIT;
GO

