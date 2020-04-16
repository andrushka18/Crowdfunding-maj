CREATE PROCEDURE [dbo].[SP_Palier_GetAll]
AS
	SELECT * FROM [Palier]Join [Projets] ON [Palier].[IdPalier] = [Projets].[IdProjet]