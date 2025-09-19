CREATE TABLE [dbo].[Utilisateur] (
    [UtilisateurId]  INT            IDENTITY (1, 1) NOT NULL,
    [Nom]            NVARCHAR (MAX)  NOT NULL,
    [Prenom]         NVARCHAR (MAX)  NOT NULL,
    [NomUtilisateur] NVARCHAR (320)  NOT NULL,
    [Password]       VARBINARY (MAX) NOT NULL,
    [Role] NVARCHAR(MAX) NULL DEFAULT 'Utilisateur'
    
    CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED ([UtilisateurId] ASC),
    [IsActive] BIT NULL DEFAULT 0, 
    CONSTRAINT CK_Utilisateur_Role CHECK ([Role] = 'Utilisateur' OR [Role] = 'Admin'),
    CONSTRAINT [UK_Utilisateur_NomUtilisateur] UNIQUE NONCLUSTERED ([NomUtilisateur] ASC)
);

