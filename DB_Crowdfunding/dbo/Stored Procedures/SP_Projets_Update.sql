CREATE PROCEDURE [dbo].[SP_Projets_Update]
	@idProjet INT,
	@plafondFinance decimal(10),
	@nom NVARCHAR(50),
	@urlvideo NVARCHAR(50),
	@numeroCompte NVARCHAR(50)
AS
	UPDATE [Projets] SET [Nom] = @nom,[PlafondFinance]= @plafondFinance, [NumeroCompte]=@numeroCompte, [UrlVideo]=@urlvideo WHERE [IdProjet] = @idProjet