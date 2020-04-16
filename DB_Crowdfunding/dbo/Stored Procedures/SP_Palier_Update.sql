﻿CREATE PROCEDURE [dbo].[SP_Palier_Update]
	@idPalier INT,
	@montant Decimal(10), 
	@prime NVARCHAR(50)
AS
	UPDATE [Palier] SET [Montant] = @montant , [Prime]= @prime WHERE [IdPalier] = @idPalier