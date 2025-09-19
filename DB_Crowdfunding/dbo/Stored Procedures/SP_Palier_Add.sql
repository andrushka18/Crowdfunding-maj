CREATE PROCEDURE [dbo].[SP_Palier_Add]

	@montant Decimal(10),
	@prime NVARCHAR(MAX)

AS
	INSERT INTO [Palier]([Montant],[Prime]) OUTPUT inserted.IdPalier VALUES (@montant, @prime)