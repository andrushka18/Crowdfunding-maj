﻿CREATE TABLE [dbo].[Societe] (
    [NumeroTVA]   INT           IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Societe] PRIMARY KEY CLUSTERED ([NumeroTVA] ASC),
    CONSTRAINT [UK_Societe] UNIQUE NONCLUSTERED ([NumeroTVA] ASC)
);

