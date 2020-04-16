CREATE PROCEDURE [dbo].[SP_Financeur_GetById]
	@financeurId int
AS
	SELECT * FROM [Financeur] WHERE [FinanceurId] = @financeurId