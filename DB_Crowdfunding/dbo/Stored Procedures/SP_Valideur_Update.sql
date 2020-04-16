CREATE PROCEDURE [dbo].[SP_Valideur_Update]
	@valideurId INT,
	@status NVARCHAR(50), 
	@commentaire NVARCHAR(50)
AS
	UPDATE [Valideur] SET [Status] = @status , [Commentaire]= @commentaire WHERE [ValideurId] = @valideurId
