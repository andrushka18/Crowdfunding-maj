CREATE PROCEDURE [dbo].[SP_Registration]
	@nom NVARCHAR(MAX), 
    @prenom NVARCHAR(MAX), 
    @nomUtilisateur NVARCHAR(MAX), 
    @password NVARCHAR(MAX)
   
AS
BEGIN
     Declare  @role NVARCHAR(MAX) = 'utilisateur'

    if NOT EXISTS (Select * from [Utilisateur])
        Set @role = 'Admin';

     INSERT INTO [Utilisateur]([Nom], [Prenom], [NomUtilisateur], [Password], [Role]) values (@nom, @prenom, @nomUtilisateur, [dbo].SF_HashPassword(@password), @role)
END
