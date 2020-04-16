CREATE PROCEDURE [dbo].[SP_Login]
	@nomUtilisateur nvarchar(320),
	@password varbinary (20)
AS
Begin
	SELECT [UtilisateurId], [Nom], [Prenom], [NomUtilisateur], [Role]  FROM Utilisateur where NomUtilisateur=@nomUtilisateur and [Password]= [dbo].SF_HashPassword(@password)
End 
