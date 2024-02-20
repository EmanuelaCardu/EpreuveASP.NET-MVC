CREATE TABLE [dbo].[Media]
(
	[Id_Media] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Url] VARCHAR(50) NOT NULL, 
    [Produit] INT NOT NULL, 
    CONSTRAINT [FK_Media_Produit] FOREIGN KEY ([Produit]) REFERENCES [Produit]([Id_Produit])
)
