CREATE PROCEDURE [dbo].[SP_Produit_CritereEco]
	@CritereEco varchar(50)
	
AS
	SELECT [Id_Produit],
			[NomProduit],
			[Description]
			[PrixProduit],
			[CritereEco],
			[Categorie]
   FROM [Produit]
   WHERE [CritereEco] = @CritereEco