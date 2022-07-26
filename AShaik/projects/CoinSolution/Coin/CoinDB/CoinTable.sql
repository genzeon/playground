CREATE TABLE [dbo].[CoinTable]
(
	[Id] INT NOT NULL PRIMARY KEY,

	[Name] nvarchar(255) not null,
	[FaceUp] bit not null ,
	[TossCount] int not null

)
