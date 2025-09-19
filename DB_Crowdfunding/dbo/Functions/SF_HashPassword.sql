CREATE FUNCTION [dbo].[SF_HashPassword]
(
	@password NVARCHAR(320)
)
RETURNS VARBINARY(32)
AS
BEGIN
	DECLARE @cashCashe NVARCHAR(MAX)
	SET @cashCashe = 'Dru' + @password + 'shka'
	RETURN HASHBYTES(N'SHA2_256',@cashCashe)
END


