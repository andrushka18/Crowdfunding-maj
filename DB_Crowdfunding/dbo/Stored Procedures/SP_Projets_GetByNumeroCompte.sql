CREATE PROCEDURE [dbo].[SP_Projets_GetByNumeroCompte]
	@numeroCompte NVARCHAR(50)
AS
	SELECT * FROM [Projets] WHERE [NumeroCompte] = @numeroCompte
