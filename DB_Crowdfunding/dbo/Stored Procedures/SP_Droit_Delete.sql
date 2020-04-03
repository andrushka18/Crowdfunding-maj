CREATE PROCEDURE [dbo].[SP_Droit_Delete]
	@idDroit int
	
AS
	DELETE FROM [Droit] WHERE [IdDroit]=@idDroit