CREATE PROCEDURE [dbo].[SP_Financeur_Update]
	@financeurId INT,
	@montant Decimal(10), 
	@prime NVARCHAR(MAX)
AS
	UPDATE [Financeur] SET [Montant] = @montant , [Prime]= @prime WHERE [FinanceurId] = @financeurId