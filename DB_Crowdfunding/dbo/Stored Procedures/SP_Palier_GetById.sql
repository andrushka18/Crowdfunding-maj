CREATE PROCEDURE [dbo].[SP_Palier_GetById]
	@idPalier int
AS
	SELECT * FROM [Palier]JOIN [Projets] ON [Palier].[IdPalier] = [Projets].[IdProjet] WHERE [IdPalier] = @idPalier