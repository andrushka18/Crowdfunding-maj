CREATE PROCEDURE [dbo].[SP_Utilisateur_SetAdmin]
	@utilisateurId int,
	@idDroit int
AS
	 
	UPDATE [Utilisateur] SET [Role] = 'Admin' WHERE [UtilisateurId] = @utilisateurId 
	