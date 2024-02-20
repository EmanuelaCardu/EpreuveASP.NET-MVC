CREATE TABLE [dbo].[Media]
(
	[Id_Media] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Url] VARCHAR(50) NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    CONSTRAINT [FK_Media_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit])
)
