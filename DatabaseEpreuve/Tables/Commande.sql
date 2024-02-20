CREATE TABLE [dbo].[Commande]
(
	[Id_Commande] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Quantite] INT NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    CONSTRAINT [FK_Commande_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit]), 
   
)
