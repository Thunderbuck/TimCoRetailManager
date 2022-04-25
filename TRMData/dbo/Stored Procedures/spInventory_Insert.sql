CREATE PROCEDURE [dbo].[spInventory_Insert]
	@ProductID int,
	@Quantity int,
	@PurchasePrice money,
	@PurchaseDate datetime2
AS
begin
	set nocount on;

	insert into dbo.Inventory(ProductID, Quantity, PurchasePrice, PurchaseDate)
	values (@ProductID, @Quantity, @PurchasePrice, @PurchaseDate);
end

