CREATE PROCEDURE [dbo].[SP_Utilisateur_IsAdmin]
	@utilisateurId INT,
	@idDroit int,
	@isAdmin BIT OUTPUT
AS
	SET @isAdmin = 0
	SELECT @isAdmin = IIF([Role] = 'Admin', 1, 0) FROM  [Utilisateur]  WHERE [UtilisateurId] =@utilisateurId  
