CREATE PROCEDURE [dbo].[SP_Valideur_Update]
	@valideurId INT,
	@status BIT OUTPUT, 
	@commentaire NVARCHAR(MAX)
AS
    
	UPDATE [Valideur] SET  [Commentaire]= @commentaire WHERE [ValideurId] = @valideurId
