CREATE TABLE [dbo].[Inventory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductID] INT NOT NULL,
    [Quantity] INT DEFAULT 1 NOT NULL,
    [PurchasePrice] MONEY NOT NULL, 
    [PurchaseDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    CONSTRAINT [FK_Inventory_ToProduct] FOREIGN KEY (ProductID) REFERENCES Product(Id)
)
