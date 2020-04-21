CREATE PROCEDURE [dbo].[SP_Login]
	@nomUtilisateur nvarchar(MAX),
	@password NVARCHAR (MAX)
AS
Begin
	SELECT [UtilisateurId] FROM Utilisateur where NomUtilisateur=@nomUtilisateur and [Password]= [dbo].SF_HashPassword(@password)
End 

