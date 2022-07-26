CREATE TABLE [dbo].[Toss]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),
	[CoinName] nvarchar Not null ,
	[Facingup] bit not null,
	[TryCount] int not null
)
