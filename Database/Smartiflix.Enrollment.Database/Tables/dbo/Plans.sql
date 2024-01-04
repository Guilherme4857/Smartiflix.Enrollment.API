CREATE TABLE [dbo].[Plans]
(
	[Name] NVARCHAR(200) NOT NULL,
	[MonthlyValue] MONEY NOT NULL,
	[ClassTotal] INT NOT NULL,

	CONSTRAINT [PK_Plans] PRIMARY KEY ([Name])
)
