CREATE PROCEDURE [dbo].[SP_Utilisateur_Check]
	@nomUtilisateur NVARCHAR(MAX),
	@password NVARCHAR(MAX),
	@utilisateurId INT OUTPUT
	
AS
	

SELECT UtilisateurId FROM Utilisateur WHERE NomUtilisateur = @nomUtilisateur

