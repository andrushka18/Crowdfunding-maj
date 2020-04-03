CREATE PROCEDURE [dbo].[SP_Droit_Add]
	@idDroit int,
	@nomDroit NVARCHAR(50)
	
AS
	INSERT INTO [Droit] ([IdDroit],[NomDroit]) OUTPUT inserted.IdDroit VALUES (@idDroit, @nomDroit)