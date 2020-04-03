CREATE PROCEDURE [dbo].[SP_Droit_Update]
	@idDroit int,
	@nomDroit int
AS
	UPDATE [Droit] SET [NomDroit]= @nomDroit WHERE [IdDroit] = @idDroit