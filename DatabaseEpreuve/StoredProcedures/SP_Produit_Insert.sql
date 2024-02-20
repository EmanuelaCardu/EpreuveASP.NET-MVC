CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@NomProduit varchar (50),
	@Description varchar (1000),
	@PrixProduit decimal(18,0),
	@CritereEco varchar (50),
	@Id_Categorie int
AS
	INSERT INTO [Produit] ([NomProduit],[Description],[PrixProduit],[CritereEco],[Id_Categorie])
	OUTPUT [inserted].[Id_Produit]
	VALUES (@nomProduit,@description,@PrixProduit,@CritereEco,@Id_Categorie)