CREATE PROCEDURE [dbo].[PS_Employe_Delete]
	@utilisateurId int,
	@NN int
	

AS
	DELETE FROM [Employe] WHERE NumeroNational=@NN