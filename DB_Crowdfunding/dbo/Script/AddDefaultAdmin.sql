/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT [Utilisateur] ON;
GO

IF EXISTS(SELECT [UtilisateurId] FROM [Utilisateur] WHERE NomUtilisateur = 'Admin' AND [Password] = dbo.SF_HashPassword('Admin'))
	BEGIN
		DELETE FROM [Utilisateur] WHERE NomUtilisateur = 'Admin' AND [Password] = dbo.SF_HashPassword('Admin');
	END
INSERT INTO Utilisateur([UtilisateurId],[Nom],[Prenom],[NomUtilisateur],[Password],[Role])
	VALUES(0,'Admin','Admin','Admin',dbo.SF_HashPassword('Admin'),'Admin');
GO

SET IDENTITY_INSERT [Utilisateur] OFF;
GO
