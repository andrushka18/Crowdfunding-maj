CREATE TABLE [dbo].[Valideur] (
    [ValideurId]    INT           IDENTITY (1, 1) NOT NULL,
    [UtilisateurId] INT           NOT NULL,
    [IdProjet]      INT           NOT NULL,
    [Status]        BIT NOT NULL DEFAULT 0,
    [Commentaire]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Valideur] PRIMARY KEY CLUSTERED ([ValideurId] ASC),
    CONSTRAINT [FK_Valideur_Droit] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
    CONSTRAINT [FK_Valideur_Utilisateur] FOREIGN KEY ([UtilisateurId]) REFERENCES [dbo].[Utilisateur] ([UtilisateurId]) ON DELETE CASCADE,
    CONSTRAINT [UK_Valideur] UNIQUE NONCLUSTERED ([UtilisateurId] ASC, [IdProjet] ASC),
    CONSTRAINT [CK_Valideur] CHECK ([Commentaire] IS NULL AND [Status]=(1) OR [Commentaire] IS NULL AND [Status] = (0))
);

