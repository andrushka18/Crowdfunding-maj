CREATE PROCEDURE [dbo].[SP_Societe_Delete]
	@numeroTVA int
AS
	DELETE FROM [Societe] WHERE [NumeroTVA] = @numeroTVA