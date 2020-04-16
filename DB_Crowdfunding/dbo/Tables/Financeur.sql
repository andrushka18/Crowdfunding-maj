CREATE TABLE [dbo].[Financeur] (
    [FinanceurId]   INT           IDENTITY (1, 1) NOT NULL,
    [UtilisateurId] INT           NOT NULL,
    [IdProjet]      INT           NOT NULL,
    [Montant]       DECIMAL (18)  NOT NULL,
    [Prime]         NVARCHAR (50) NULL,
    CONSTRAINT [PK_Financeur] PRIMARY KEY CLUSTERED ([FinanceurId] ASC),
    CONSTRAINT [FK_Financeur_Droit] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
    CONSTRAINT [FK_Financeur_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Financeur] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdProjet] ASC)
);

