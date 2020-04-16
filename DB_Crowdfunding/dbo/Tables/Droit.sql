CREATE TABLE [dbo].[Droit] (
    [IdDroit]  INT           IDENTITY (1, 1) NOT NULL,
    [Role] NVARCHAR (50) NOT NULL DEFAULT 'Utilisateur',
    CONSTRAINT [PK_Droit] PRIMARY KEY CLUSTERED ([IdDroit] ASC),
    CONSTRAINT [CK_Droit] CHECK ([Role]='Utilisateur' OR [Role]='Admin'),
    CONSTRAINT [UK_Droit] UNIQUE NONCLUSTERED ([Role] ASC)
);

