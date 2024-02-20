CREATE TABLE [dbo].[Panier]
(
	[Id_Commande] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Quantite] INT NOT NULL, 
    [Id_Produit] INT NOT NULL
)
