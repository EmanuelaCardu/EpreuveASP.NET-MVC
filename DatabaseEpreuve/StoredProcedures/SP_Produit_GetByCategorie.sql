CREATE PROCEDURE [dbo].[SP_Produit_GetByCategorie]
	@Categorie varchar(50)
	
AS
	SELECT [Id_Produit],
			[NomProduit],
			[Description]
			[PrixProduit],
			[CritereEco],
			[Categorie]
   FROM [Produit]
   WHERE [Categorie] = @Categorie
