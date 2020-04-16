CREATE PROCEDURE [dbo].[SP_Utilisateur_Check]
	@nomUtilisateur NVARCHAR(50),
	@password NVARCHAR(50),
	@utilisateurId INT OUTPUT,
	@IsActive BIT OUTPUT
AS
	SET @IsActive = 1;
	IF EXISTS (SELECT UtilisateurId FROM Utilisateur WHERE NomUtilisateur = @nomUtilisateur AND [Password] = dbo.SF_HashPassword(@password))
		SELECT @utilisateurId = UtilisateurId FROM Utilisateur WHERE NomUtilisateur = @nomUtilisateur
RETURN 1
