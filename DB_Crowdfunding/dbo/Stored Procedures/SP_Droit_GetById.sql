CREATE PROCEDURE [dbo].[SP_Droit_GetById]
	
	@idDroit int
AS
	SELECT IdDroit FROM [Droit] WHERE [IdDroit] = @idDroit