CREATE PROCEDURE [dbo].[SP_Financeur_Delete]
	@utilisateurId int
AS
	DELETE FROM [Financeur] WHERE [UtilisateurId] = @utilisateurId