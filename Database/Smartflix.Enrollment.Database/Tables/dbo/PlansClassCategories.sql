CREATE TABLE [dbo].[PlansClassCategories]
(
	[ClassCategoriesId] INT NOT NULL,
	[PlanName] NVARCHAR(200) NOT NULL,

	CONSTRAINT [FK_PlansClassCategories_ClassCategories] FOREIGN KEY ([ClassCategoriesId]) REFERENCES [ClassCategories] ([Id]),
	CONSTRAINT [FK_PlansClassCategories_Plans] FOREIGN KEY ([PlanName]) REFERENCES [Plans] ([Name])
)
