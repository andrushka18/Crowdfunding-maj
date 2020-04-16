CREATE PROCEDURE [dbo].[SP_Utilisateur_ChangePassword]
	@utilisateurId INT,
	@password NVARCHAR(50)
AS
	UPDATE Utilisateur
		SET [Password] = [dbo].SF_HashPassword(@password)
	WHERE UtilisateurId = @utilisateurId
