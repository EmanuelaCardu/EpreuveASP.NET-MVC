USE [DatabaseEpreuve]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SP_Produit_GetAll]

SELECT	@return_value as 'Return Value'

GO
