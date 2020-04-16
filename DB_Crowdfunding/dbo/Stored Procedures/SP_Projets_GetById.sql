CREATE PROCEDURE [dbo].[SP_Projets_GetById]
	@idProjet int
AS
	SELECT * FROM [Projets] WHERE [IdProjet] = @idProjet
