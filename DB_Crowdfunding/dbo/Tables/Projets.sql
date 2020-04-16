CREATE TABLE [dbo].[Projets] (
    [IdProjet]       INT           IDENTITY (1, 1) NOT NULL,
    [Nom]            NVARCHAR (32) NOT NULL,
    [PlafondFinance] DECIMAL (18)  NULL,
    [NumeroCompte]   NVARCHAR (32) NULL,
    [UrlVideo]       NVARCHAR (32) NULL,
    CONSTRAINT [PK_Projets] PRIMARY KEY CLUSTERED ([IdProjet] ASC),
    CONSTRAINT [UK_Projets_Nom] UNIQUE NONCLUSTERED ([Nom] ASC)
);

