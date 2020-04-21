CREATE PROCEDURE [dbo].[SP_Projets_GetByNumeroCompte]
	@numeroCompte NVARCHAR(MAX)
AS
	SELECT * FROM [Projets] WHERE [NumeroCompte] = @numeroCompte
