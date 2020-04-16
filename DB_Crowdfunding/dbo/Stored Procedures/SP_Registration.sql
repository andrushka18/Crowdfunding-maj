CREATE PROCEDURE [dbo].[SP_Registration]
	@nom NVARCHAR(50), 
    @prenom NVARCHAR(50), 
    @nomUtilisateur NVARCHAR(320), 
    @password NVARCHAR(20)
   
AS
BEGIN
     Declare  @role NVARCHAR(50) = 'utilisateur'

    if NOT EXISTS (Select * from [Utilisateur])
        Set @role = 'Admin';

     INSERT INTO [Utilisateur]([Nom], [Prenom], [NomUtilisateur], [Password], [Role]) values (@nom, @prenom, @nomUtilisateur, [dbo].SF_HashPassword(@password), @role)
END
