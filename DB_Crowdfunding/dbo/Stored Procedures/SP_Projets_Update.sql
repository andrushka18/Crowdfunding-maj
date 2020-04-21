CREATE PROCEDURE [dbo].[SP_Projets_Update]
	@idProjet INT,
	@plafondFinance decimal(10),
	@nom NVARCHAR(MAX),
	@urlvideo NVARCHAR(MAX),
	@numeroCompte NVARCHAR(MAX)
AS
	UPDATE [Projets] SET [Nom] = @nom,[PlafondFinance]= @plafondFinance, [NumeroCompte]=@numeroCompte, [UrlVideo]=@urlvideo WHERE [IdProjet] = @idProjet