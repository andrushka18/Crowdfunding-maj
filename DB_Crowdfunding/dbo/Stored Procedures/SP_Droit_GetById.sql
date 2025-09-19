CREATE PROCEDURE [dbo].[SP_Droit_GetById]
	
	@idDroit int
AS
	SELECT [IdDroit], [Role] FROM [Droit] WHERE [IdDroit] = @idDroit