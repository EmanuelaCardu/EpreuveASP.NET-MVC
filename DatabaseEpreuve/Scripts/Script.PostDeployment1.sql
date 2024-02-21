/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/-- Ajoutez des données fictives pour 5 produits


-- Ajoutez des données fictives pour 5 catégories

INSERT INTO [dbo].[CritereEco] ([CritereEco])
VALUES 
    ('A'),
    ('B'),
    ('C'),
    ('D'),
    ('E');

INSERT INTO [dbo].[Categorie] ([NomCategorie], [Description])
VALUES 
    ('Catégorie 1', 'Description de la catégorie 1'),
    ('Catégorie 2', 'Description de la catégorie 2'),
    ('Catégorie 3', 'Description de la catégorie 3'),
    ('Catégorie 4', 'Description de la catégorie 4'),
    ('Catégorie 5', 'Description de la catégorie 5');








INSERT INTO [dbo].[Produit] ([NomProduit], [Description], [PrixProduit], [CritereEco], [Id_Categorie])
VALUES 
    ('Produit 1', 'Description du produit 1', 10.99, 'A', 1),
    ('Produit 2', 'Description du produit 2', 20.50, 'B', 2),
    ('Produit 3', 'Description du produit 3', 15.75, 'C', 1),
    ('Produit 4', 'Description du produit 4', 30.25, 'D', 3),
    ('Produit 5', 'Description du produit 5', 12.00, 'E', 2);

