CREATE TABLE [dbo].[UserInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AuthUserId] NVARCHAR(128) NOT NULL, 
    [FirstName] NCHAR(50) NOT NULL,
    [LastName] NCHAR(50) NOT NULL,
    [EmailAddress   ] NCHAR(256) NOT NULL,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()
    
)
