CREATE PROCEDURE [dbo].[PS_Employe_GetById]
	@utilisateurId int,
	@NN int
AS
	SELECT UtilisateurId, IdProjet, NumeroNational,NumeroTVA FROM [Employe] WHERE [NumeroNational] = @NN