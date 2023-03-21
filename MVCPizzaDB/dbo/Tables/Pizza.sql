CREATE TABLE [dbo].[Pizza]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PizzaID] INT NOT NULL, 
    [PizzaName] NVARCHAR(50) NOT NULL, 
    [PizzaSize] INT NOT NULL, 
    [PizzaPrice] INT NOT NULL
)
