CREATE PROCEDURE [dbo].[SP_Droit_Update]
	@idDroit int,
	@role int
AS
	UPDATE [Droit] SET [Role]= @role WHERE [IdDroit] = @idDroit