CREATE PROCEDURE [dbo].[SP_Produit_ByCritereEco]
	@CritereEco varchar(50)
	
AS
	SELECT [Id_Produit],
			[NomProduit],
			[Description]
			[PrixProduit],
			[CritereEco],
			[Id_Categorie]
   FROM [Produit]
   WHERE [CritereEco] = @CritereEco