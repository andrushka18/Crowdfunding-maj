CREATE TABLE [dbo].[Palier] (
    [IdPalier] INT      IDENTITY (1, 1)     NOT NULL,
    [Montant]  DECIMAL (18)  NULL,
    [Prime]    NVARCHAR (50) NULL,
    [IdProjet] INT NOT NULL,
    CONSTRAINT [PK_Palier] PRIMARY KEY CLUSTERED ([IdPalier] ASC),
    CONSTRAINT [FK_Palier_Projets] FOREIGN KEY ([IdProjet]) REFERENCES [dbo].[Projets] ([IdProjet]) ON DELETE CASCADE,
 );
