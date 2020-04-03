CREATE PROCEDURE [dbo].[SP_Valideur_Delete]
	@utilisateurId int
AS
	DELETE FROM [Valideur] WHERE [UtilisateurId] = @utilisateurid