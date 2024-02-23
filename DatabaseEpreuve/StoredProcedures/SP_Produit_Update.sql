CREATE PROCEDURE [dbo].[SP_Produit_Update]
		@id_produit INT,
	@NomProduit VARCHAR(50),
	@Description VARCHAR (1000),
	@PrixProduit decimal(18,2),
	@CritereEco NVARCHAR(50),
	@Id_Categorie int
AS
	UPDATE [Produit] 
		SET [NomProduit] = @NomProduit ,
			[Description] = @Description ,
			[PrixProduit] = @PrixProduit ,
			[CritereEco] = @CritereEco,
			[Id_Categorie] = @Id_Categorie
		WHERE [Id_Produit] = @Id_Produit 