CREATE PROCEDURE [dbo].[SP_Projets_Add]
	@nom NVARCHAR(MAX),
	@plafondFinance DECIMAL(10),
	@numeroCompte NVARCHAR(MAX),
	@urlVideo NVARCHAR(MAX)

AS
	INSERT INTO [Projets]([Nom],[PlafondFinance],[NumeroCompte],[UrlVideo]) OUTPUT inserted.IdProjet VALUES (@nom, @plafondFinance, @numeroCompte, @urlVideo)