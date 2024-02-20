CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@NomProduit varchar (50),
	@Description varchar (1000),
	@PrixProduit decimal(18,0),
	@CritereEco varchar (50),
	@Categorie varchar (50)
AS
	INSERT INTO [Produit] ([NomProduit],[Description],[PrixProduit],[CritereEco],[Categorie])
	OUTPUT [inserted].[Id_Produit]
	VALUES (@nomProduit,@description,@PrixProduit,@CritereEco,@Categorie)