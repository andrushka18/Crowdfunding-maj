CREATE PROCEDURE [dbo].[SP_Utilisateur_Add]
	@nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@nomUtilisateur NVARCHAR(50),
	@password NVARCHAR(50),
	@role NVARCHAR(50)
	
	
AS
	INSERT INTO Utilisateur([Nom],[Prenom],[NomUtilisateur],[Password],[Role])
	OUTPUT inserted.UtilisateurId
	VALUES (@nom,@prenom,@nomUtilisateur,[dbo].SF_HashPassword(@password),(@role))


