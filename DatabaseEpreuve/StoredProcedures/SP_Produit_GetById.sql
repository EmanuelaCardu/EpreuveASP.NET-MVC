CREATE PROCEDURE [dbo].[SP_Produit_GetById]
		@Id_Produit INT
AS
	SELECT	[Id_Produit],
			[NomProduit],
			[Description],
			[PrixProduit],
			[CritereEco],
			[Id_Categorie]
		FROM [Produit]
		WHERE [Id_Produit] = @Id_produit
