CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomProduit] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(1000) NOT NULL, 
    [PrixProduit] DECIMAL(18, 2) NOT NULL, 
    [CritereEco] VARCHAR(50) NOT NULL, 
    [Id_Categorie] INT NOT NULL, 

    CONSTRAINT [FK_Produit_CritereEco] FOREIGN KEY ([CritereEco]) REFERENCES [CritereEco]([CritereEco]), 
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Id_Categorie]) REFERENCES [Categorie]([Id_Categorie])
)
