﻿CREATE TABLE [dbo].[CoinFlip]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(255) NOT NULL,
	[FlipCount] BIT NOT NULL,
	[FacingValue] INT NOT NULL
)
