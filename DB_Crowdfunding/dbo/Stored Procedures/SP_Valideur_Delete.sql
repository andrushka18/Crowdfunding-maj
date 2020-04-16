CREATE PROCEDURE [dbo].[SP_Valideur_Delete]
	@valideurId int
AS
	DELETE FROM [Valideur] WHERE [ValideurId] = @valideurId