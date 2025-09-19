CREATE PROCEDURE [dbo].[SP_Financeur_Delete]
	@financeurId int
AS
	DELETE FROM [Financeur] WHERE [FinanceurId] = @financeurId