CREATE PROCEDURE [dbo].[SP_Droit_Add]
	@idDroit int,
	@role NVARCHAR(50)
	
AS
	INSERT INTO [Droit] ([IdDroit],[Role]) OUTPUT inserted.IdDroit VALUES (@idDroit, @role)