CREATE TABLE [dbo].[Projets] (
    [IdProjet]       INT           IDENTITY (1, 1) NOT NULL,
    [Nom]            NVARCHAR (50) NOT NULL,
    [PlafondFinance] DECIMAL (18)  NULL,
    [NumeroCompte]   NVARCHAR (MAX) NULL,
    [UrlVideo]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Projets] PRIMARY KEY CLUSTERED ([IdProjet] ASC),
    CONSTRAINT [UK_Projets_Nom] UNIQUE NONCLUSTERED ([Nom] ASC)
);

