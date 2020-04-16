CREATE PROCEDURE [dbo].[SP_Societe_Add]

	@numeroTVA INT,
	@description NVARCHAR(50)

AS
	INSERT INTO [Societe]([NumeroTVA],[Description]) OUTPUT inserted.NumeroTVA VALUES (@numeroTVA, @description)
