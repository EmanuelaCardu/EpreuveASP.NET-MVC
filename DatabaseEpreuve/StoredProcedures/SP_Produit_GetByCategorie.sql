CREATE PROCEDURE [dbo].[SP_Produit_GetByCategorie]
	@Id_Categorie int
	
AS
	SELECT [Id_Produit],
			[NomProduit],
			[Description],
			[PrixProduit],
			[CritereEco],
			[Id_Categorie]
   FROM [Produit]
   WHERE [Id_Categorie] = @Id_Categorie
