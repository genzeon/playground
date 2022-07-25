CREATE TABLE [dbo].[Toss]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CoinName] nvarchar Not null ,
	[Facingup] bit not null,
	[TryCount] int not null
)
