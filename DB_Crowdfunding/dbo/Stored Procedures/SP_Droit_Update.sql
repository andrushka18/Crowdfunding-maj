CREATE PROCEDURE [dbo].[SP_Droit_Update]
	@idDroit int,
	@role NVARCHAR (MAX)
AS
	UPDATE [Droit] SET [Role]= @role WHERE [IdDroit] = @idDroit