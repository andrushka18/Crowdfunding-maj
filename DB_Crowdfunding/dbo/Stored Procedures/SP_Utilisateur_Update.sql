CREATE PROCEDURE [dbo].[SP_Utilisateur_Update]
	@utilisateurId INT,
	@nom NVARCHAR(MAX),
	@prenom NVARCHAR(MAX)
AS
	UPDATE [Utilisateur]
	SET [Nom] = @nom,
		[Prenom] = @prenom
	WHERE [UtilisateurId] = @utilisateurId
