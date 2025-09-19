CREATE PROCEDURE [dbo].[SP_Valideur_Add]

	@status BIT OUTPUT,
	@commentaire NVARCHAR(MAX)

AS
	SET @status= 1
	INSERT INTO [Valideur]([Commentaire]) OUTPUT inserted.ValideurId VALUES (@commentaire)
