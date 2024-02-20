CREATE PROCEDURE [dbo].[SP_Produit_GetAll]
AS
	SELECT	[Id_Produit],
			[NomProduit],
			[Description]
			[PrixProduit],
			[CritereEco],
			[Id_Categorie]
		FROM [Produit]
