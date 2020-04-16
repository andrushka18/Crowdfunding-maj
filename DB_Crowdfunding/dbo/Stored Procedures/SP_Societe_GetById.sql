CREATE PROCEDURE [dbo].[SP_Societe_GetById]
	@numeroTVA int
AS
	SELECT * FROM [Societe] WHERE [NumeroTVA] = @numeroTVA
