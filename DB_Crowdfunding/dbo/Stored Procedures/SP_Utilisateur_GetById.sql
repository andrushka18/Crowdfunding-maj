CREATE PROCEDURE [dbo].[SP_Utilisateur_GetById]
	@utilisateurId INT
AS
	SELECT [UtilisateurId], [Nom], [Prenom], [NomUtilisateur] [Role] FROM  [Utilisateur] WHERE [UtilisateurId] = @utilisateurId