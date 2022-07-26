CREATE TABLE [dbo].[CoinToss]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[Name] nvarchar(255) not null,
	[FaceUp] bit not null,
	[TryCount] int not null
)
