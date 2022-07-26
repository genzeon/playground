CREATE TABLE [dbo].[CoinFlip]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CoinName] nvarchar(255) Not Null,
	[FacingUp] bit Not Null,
	[TryCount] int Not Null
)
