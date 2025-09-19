CREATE PROCEDURE [dbo].[SP_Utilisateur_UnsetAdmin]
	@utilisateurId int,
	@idDroit int
AS
		UPDATE [Utilisateur] SET [Role] = 'Utilisateur' WHERE [UtilisateurId] = @utilisateurId 
	