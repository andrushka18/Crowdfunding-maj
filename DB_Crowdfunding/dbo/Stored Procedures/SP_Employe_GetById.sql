CREATE PROCEDURE [dbo].[PS_Employe_GetById]
	@utilisateurId int,
	@NN int
AS
	SELECT * FROM [Employe] WHERE [NumeroNational] = @NN