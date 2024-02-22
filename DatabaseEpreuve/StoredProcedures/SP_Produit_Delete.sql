CREATE PROCEDURE [dbo].[SP_Produit_Delete]
	@Id_Produit int
	
AS
	DELETE FROM  [Produit]
	WHERE [Id_Produit] = @Id_Produit
