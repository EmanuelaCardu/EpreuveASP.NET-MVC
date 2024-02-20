CREATE PROCEDURE [dbo].[SP_Produit_Update]
		@id_produit INT,
	@NomProduit VARCHAR(50),
	@Description VARCHAR (1000),
	@PrixProduit decimal(18,0),
	@CritereEco NVARCHAR(50),
	@Categorie NVARCHAR(50)
AS
	UPDATE [Produit] 
		SET [NomProduit] = @NomProduit ,
			[Description] = @Description ,
			[PrixProduit] = @PrixProduit ,
			[CritereEco] = @CritereEco,
			[Categorie] = @Categorie
		WHERE [Id_Produit] = @id_Produit 