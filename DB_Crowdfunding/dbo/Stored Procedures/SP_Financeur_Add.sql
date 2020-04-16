CREATE PROCEDURE [dbo].[SP_Financeur_Add]

	@montant Decimal(10),
	@prime NVARCHAR(50)

AS
	INSERT INTO [Financeur]([Montant],[Prime]) OUTPUT inserted.FinanceurId VALUES (@montant, @prime)