CREATE PROCEDURE [dbo].[SP_Utilisateur_Add]
	@nom NVARCHAR(MAX),
	@prenom NVARCHAR(MAX),
	@nomUtilisateur NVARCHAR(MAX),
	@password NVARCHAR(MAX),
	@role NVARCHAR(MAX)
	
	
AS
	INSERT INTO Utilisateur([Nom],[Prenom],[NomUtilisateur],[Password],[Role])
	OUTPUT inserted.UtilisateurId
	VALUES (@nom,@prenom,@nomUtilisateur,[dbo].SF_HashPassword(@password),(@role))


