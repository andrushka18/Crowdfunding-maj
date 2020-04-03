CREATE PROCEDURE [dbo].[SP_Palier_Delete]
	@idPalier int
AS
	DELETE FROM [Palier] WHERE [IdPalier] = @idPalier