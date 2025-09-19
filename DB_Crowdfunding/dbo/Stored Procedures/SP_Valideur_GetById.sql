CREATE PROCEDURE [dbo].[SP_Valideur_GetById]
	@valideurId int
AS
	SELECT [ValideurId],[UtilisateurId],[Status],[Commentaire] FROM [Valideur] WHERE [ValideurId] = @valideurId
