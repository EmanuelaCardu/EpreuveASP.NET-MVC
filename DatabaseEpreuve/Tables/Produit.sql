CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomProduit] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(1000) NOT NULL, 
    [PrixProduit] DECIMAL NOT NULL, 
    [CritereEco] VARCHAR(50) NOT NULL, 
    [Categorie] VARCHAR(50) NOT NULL, 

    CONSTRAINT [FK_Produit_CritereEco] FOREIGN KEY ([CritereEco]) REFERENCES [CritereEco]([CritereEco]), 
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Categorie]) REFERENCES [Categorie]([Categorie])
)
