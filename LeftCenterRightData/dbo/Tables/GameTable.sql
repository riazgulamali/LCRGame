CREATE TABLE [dbo].[GameTable]
(
	[Id] INT NOT NULL IDENTITY,
    [Userid] NCHAR(128) NOT NULL, 
    [GameId] NCHAR(10) NOT NULL, 
    [GameDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Dice1] INT NOT NULL, 
    [Dice2] INT NOT NULL, 
    [Dice3] INT NOT NULL, 
    [Dice4] INT NOT NULL, 
    [chipValue1] INT NULL,
    [chipValue2] INT NULL,
    [chipValue3] INT NULL,
    [chipValue4] INT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()

)
